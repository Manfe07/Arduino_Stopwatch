#include "stopwatch.h"
#include "wiring.h"
#include "settings.h"


//variables
bool armed = false;
bool activeRace = false;

Lane Lane1(Button_L1);
Lane Lane2(Button_L2);
Lane Lane3(Button_L3);

Camera LineCamera(Camera_Triger, photo_duration);

void setup() {
  Serial.begin(9600);

  pinMode(Button_R,INPUT);

  reset();
}//END void setup()

void loop() {
  if(digitalRead(Button_R)){
    armed = true;
    delay(saveTime_long);
  }

  while(armed){
    if(digitalRead(Button_R)){
      armed = false;
      delay(saveTime_short);
    }
    else{
      mainFunction();
    }
  }
}//END void loop()


void reset(){
  start_time = 0;

  Lane1.reset();
  Lane2.reset();
  Lane3.reset();
  
  LineCamera.reset();
}//END void reset()

void mainFunction(){
  if(Lane1.trigered() || Lane2.trigered() || Lane3.trigered()){
    start_time = millis();
    activeRace = true;
    delay(saveTime_long);
  }//END if(-any Button pressed-)

  while(activeRace){
    if(Lane1.trigered()){Lane1.race_finished();LineCamera.takePhoto();}
    if(Lane2.trigered()){Lane2.race_finished();LineCamera.takePhoto();}
    if(Lane3.trigered()){Lane3.race_finished();LineCamera.takePhoto();}

    LineCamera.check();  //check if cameraTriger can be released
    
    if(Lane1.finished && Lane2.finished && Lane3.finished){
      Serial.println(Lane1.duration);
      Serial.println(Lane2.duration);
      Serial.println(Lane3.duration);

      activeRace = false;
      armed = false;
    }//END if(-all finished-)
  }//END while(activeRace)
}//END void mainFunction()

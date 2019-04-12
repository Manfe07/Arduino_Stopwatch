#include "stopwatch.h"
#include "camera.h"
#include "wiring.h"
#include "settings.h"


//variables
bool armed = false;
bool activeRace = false;
unsigned long start_time;

Lane Lane1(Button_L1);
Lane Lane2(Button_L2);
Lane Lane3(Button_L3);

Camera LineCamera(Camera_Triger, photo_duration);

void setup() {
  Serial.begin(9600);
  Serial.println("connected");
  pinMode(Button_R,INPUT);

  reset();
}//END void setup()

void loop() {
  if(digitalRead(Button_R)){
    armed = true;
    Serial.println("armed");
    delay(saveTime_long);
  }

  while(armed){
    if(digitalRead(Button_R)){
      armed = false;
      Serial.println("disarmed");
      delay(saveTime_short);
    }
    else{
      mainFunction();
    }
  }
}//END void loop()


void reset(){
  Serial.println("reset");

  Lane1.reset();
  Lane2.reset();
  Lane3.reset();

  LineCamera.reset();
}//END void reset()


void mainFunction(){
  if(Lane1.trigered() || Lane2.trigered() || Lane3.trigered()){
    Serial.println("start");
    start_time = millis();
    activeRace = true;
    delay(saveTime_long);
  }//END if(-any Button pressed-)

  while(activeRace){
    if(Lane1.trigered()){Lane1.race_finished(start_time);LineCamera.takePhoto();Serial.println("lane1");}
    if(Lane2.trigered()){Lane2.race_finished(start_time);LineCamera.takePhoto();Serial.println("lane2");}
    if(Lane3.trigered()){Lane3.race_finished(start_time);LineCamera.takePhoto();Serial.println("lane3");}

    LineCamera.check();  //check if cameraTriger can be released
    
    if(Lane1.finished && Lane2.finished && Lane3.finished){
      Serial.println("finish");
      activeRace = false;
    }//END if(-all finished-)
  }//END while(activeRace)
  
  while(armed){
    if(digitalRead(Button_R)){
      delay(saveTime_long);
      armed = false;
    }//END if(...)
  }//END while(armed)
}//END void mainFunction()

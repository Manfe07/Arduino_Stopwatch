#include "stopwatch.h"
#include "wiring.h"
#include "settings.h"


//variables
bool armed = false;
bool activeRace = false;

//camera variables
bool cameraTrigered = false;
bool cameraStoped = true;
unsigned long cameraTrigered_time;

Lane Lane1;
Lane Lane2;
Lane Lane3;

void setup() {
  Serial.begin(9600);

  pinMode(Button_L1,INPUT);
  pinMode(Button_L2,INPUT);
  pinMode(Button_L3,INPUT);
  pinMode(Button_R,INPUT);
  pinMode(Camera_Triger, OUTPUT);
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
  armed = false;
  activeRace = false;
  cameraTrigered = false;
 
  start_time = 0;
 
  digitalWrite(Camera_Triger, LOW);

  Lane1.reset();
  Lane2.reset();
  Lane3.reset();
}//END void reset()

void mainFunction(){
  if(digitalRead(Button_L1) || digitalRead(Button_L2) || digitalRead(Button_L3)){
    start_time = millis();
    activeRace = true;
    delay(saveTime_long);
  }//END if(-any Button pressed-)

  while(activeRace){
    if(digitalRead(Button_L1)){
      Lane1.race_finished();
    }//END if(Button_L1 pressed)
    if(digitalRead(Button_L2)){
      Lane2.race_finished();
    }//END if(Button_L2 pressed)
    if(digitalRead(Button_L3)){
      Lane3.race_finished();
    }//END if(Button_L3 pressed)

    checkCamera();  //check if cameraTriger can be released
    
    if(Lane1.finished && Lane2.finished && Lane3.finished){
      Serial.println(Lane1.duration);
      Serial.println(Lane2.duration);
      Serial.println(Lane3.duration);

      activeRace = false;
      armed = false;
      reset();
    }//END if(-all finished-)
  }//END while(activeRace)
}//END void mainFunction()

void takePhoto(){
  if(!cameraTrigered){
    digitalWrite(Camera_Triger, HIGH);
    cameraTrigered = true;
    cameraTrigered_time = millis();
    cameraStoped = false;
  }
}//END void takePhoto()

void checkCamera(){
  if(cameraTrigered && !cameraStoped){
    if((cameraTrigered_time + photo_duration) >= millis)
    {
      digitalWrite(Camera_Triger, LOW);
      cameraStoped = true;
    }
  }
}//END void checkCamera()
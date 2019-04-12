#include "stopwatch.h"
#include "camera.h"
#include "wiring.h"
#include "settings.h"
#include "functions.h"


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
  debug("connected");
  pinMode(Button_R,INPUT_PULLUP);

  reset();
}//END void setup()

void loop() {
  if(!digitalRead(Button_R)){
    armed = true;
    debug("armed");
    wait(Button_R,saveTime_long);
  }

  while(armed){
    mainFunction();
    if(!digitalRead(Button_R)){
      armed = false;
      debug("disarmed");
      wait(Button_R,saveTime_long);
    }
  }
}//END void loop()


void reset(){
  debug("reset");

  Lane1.reset();
  Lane2.reset();
  Lane3.reset();

  LineCamera.reset();
}//END void reset()


void mainFunction(){
  if(Lane1.trigered() || Lane2.trigered() || Lane3.trigered()){
    debug("start");
    start_time = millis();
    activeRace = true;
    delay(saveTime_long);
  }//END if(-any Button pressed-)
  while(activeRace){
    if(Lane1.trigered() && !Lane1.finished){
      Lane1.race_finished(start_time);
      LineCamera.takePhoto();
      debug("lane1");
    }
    if(Lane2.trigered() && !Lane2.finished){
      Lane2.race_finished(start_time);
      LineCamera.takePhoto();
      debug("lane2");
    }
    if(Lane3.trigered() && !Lane3.finished){
      Lane3.race_finished(start_time);
      LineCamera.takePhoto();
      debug("lane3");
    }

    LineCamera.check();  //check if cameraTriger can be released
    
    if(Lane1.finished && Lane2.finished && Lane3.finished){
      debug("finish");
      activeRace = false;

      while(armed){
        if(!digitalRead(Button_R)){
          armed = false;
          wait(Button_R,saveTime_long);
          reset();
        }//END if(...)
      }//END while(armed)
    }//END if(-all finished-)
  }//END while(activeRace)
}//END void mainFunction()

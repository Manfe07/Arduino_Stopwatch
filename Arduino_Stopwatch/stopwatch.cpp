#include "stopwatch.h"
#include <arduino.h>

Lane::Lane(int _pin){
  Lane::pin = pin;
  Lane::finished = false;
  Lane::finish_time = 0;
  pinMode(_pin,INPUT);
}//END Lane::Lane()

bool Lane::trigered(){
  return digitalRead(Lane::pin);
}

void Lane::race_finished(){
  Lane::finish_time = millis();
  Lane::duration = Lane::finish_time - start_time;
  Lane::finished = true;
}//END Lane::race_finished()

void Lane::reset(){
  Lane::finished = false;
  Lane::finish_time = 0;
  Lane::duration = 0;
}//END Lane::reset()

//END Lane

Camera::Camera(int _pin, int _duration){
  Camera::pin = _pin;
  Camera::duration = _duration;
  pinMode(_pin,OUTPUT);
  Camera::trigered = false;
  Camera::stoped = false;
}//END Camera::Camera(...)

void Camera::takePhoto(){
  if(!Camera::trigered){
    digitalWrite(Camera::pin, HIGH);
    Camera::trigered = true;
    Camera::stoped = false;
    Camera::time_trigered = millis();
  }//END if(...)
}//END void Camera::takePhoto()

void Camera::check(){
  if(Camera::trigered && !Camera::stoped){
    if((Camera::time_trigered + Camera::duration) >= millis()){
      digitalWrite(Camera::pin, LOW);
      Camera::stoped = true;
    }//END if(...)
  }//END if(...)
}//END void Camera::check()

void Camera::reset(){
  Camera::stoped = true;
  Camera::trigered = false;
  digitalWrite(Camera::pin, LOW);
}//END void Camera::reset()

//END Camera
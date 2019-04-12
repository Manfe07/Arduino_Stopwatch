#include "camera.h"
#include "functions.h"
#include <arduino.h>

Camera::Camera(int _pin, int _duration){
  Camera::pin = _pin;
  Camera::duration = _duration;
  pinMode(_pin,OUTPUT);
  Camera::trigered = false;
  Camera::stoped = false;
  debug("camera-init");
}//END Camera::Camera(...)

void Camera::takePhoto(){
  if(!Camera::trigered){
    digitalWrite(Camera::pin, HIGH);
    Camera::trigered = true;
    Camera::stoped = false;
    Camera::time_trigered = millis();
    debug("camera-start");
  }//END if(...)
}//END void Camera::takePhoto()

void Camera::check(){
  if(Camera::trigered && !Camera::stoped){
    if((Camera::time_trigered + Camera::duration) >= millis()){
      digitalWrite(Camera::pin, LOW);
      Camera::stoped = true;
    debug("camera-stop");
    }//END if(...)
  }//END if(...)
}//END void Camera::check()

void Camera::reset(){
  Camera::stoped = true;
  Camera::trigered = false;
  digitalWrite(Camera::pin, LOW);
}//END void Camera::reset()

//END Camera
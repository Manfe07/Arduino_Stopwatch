#include "functions.h"
#include <Arduino.h>


void debug(char _text[]){
  if(false){
    Serial.print(millis());
    Serial.print(" - ");
    Serial.println(_text);
  }
}//END void debug(...)


void wait(int _pin, int _time){
  while(!digitalRead(_pin)){}
  delay(_time);
}//END void wait(...)

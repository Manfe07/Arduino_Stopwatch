#include "stopwatch.h"
#include <arduino.h>

Lane::Lane(int _pin){
  Lane::pin = _pin;
  Lane::finished = false;
  Lane::finish_time = 0;
  pinMode(_pin,INPUT_PULLUP);
}//END Lane::Lane()

bool Lane::trigered(){
  return !digitalRead(Lane::pin);
}

void Lane::race_finished(unsigned long start_time){
  Lane::finish_time = millis();
  Lane::duration = (Lane::finish_time - start_time) / 1000;
  Lane::finished = true;
}//END Lane::race_finished()

void Lane::reset(){
  Lane::finished = false;
  Lane::finish_time = 0;
  Lane::duration = 0;
}//END Lane::reset()

//END Lane

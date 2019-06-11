#include "wiring.h"
#include "settings.h"
#include "RS485_bus.h"
#include <Wire.h> 


Bus bus(RS485_Pin);

bool honk_start = true;
bool honk_first = true;
bool honk_finish = true;

int finish_counter = 0;
//horn times
int Horn_Start_Duration = 750;
int Horn_Finish_Duration = 300;

void setup() {
  Serial.begin(9600);
  pinMode(Button, INPUT_PULLUP);  
  pinMode(Horn, OUTPUT);
  pinMode(StatusLED, OUTPUT);
}//END void setup()


void loop() {
  serialEvent();
  if(button_pushed(Button)){
    bus.send(C_mode, M_start);
    wait(Button, 500);
  }
}//END void loop()


bool button_pushed(int _button){
  return !digitalRead(_button);
}//END void button_pushed(...)


void serialEvent() {
  uint8_t code;
  uint16_t value;
  ping(false);
  if (bus.get(code, value)) {
    switch (code) {
      case C_mode:
        switch (value){
          case M_startHorn:
            race_started();
            break;
          case M_finish:
            race_finished();
            break;  
          default:
            break;
        }//END switch(value)
        break;//END case C_mode;
      case C_ping:
        ping(true);
        break;
      default:
        break;
    }//END switch(code)
  }//END if(-data available-)
}//END void serialEvent()


void race_started(){
  honk(Horn, Horn_Start_Duration);
  finish_counter = 0;
}//END race_started()


void race_finished(){
  finish_counter++;
  if(finish_counter == 1 && honk_first){
    honk(Horn, Horn_Finish_Duration);
  }
  else if(finish_counter > 1 && honk_finish){
    honk(Horn, Horn_Finish_Duration);
  }
}//END race_finished


void ping(bool _received){
  static long oldTime;
  long now = millis();
  if(now > oldTime){
    oldTime = now + ping_duration;
    digitalWrite(StatusLED, HIGH);
  }
  if(_received){
    oldTime = now + ping_duration;
    digitalWrite(StatusLED, LOW);
  }
}//END void ping()


void wait(int _pin, int _time){
  while(!digitalRead(_pin)){}
  delay(_time);
}//END void wait(...)

void honk(int _HornPin, int _duration){
  digitalWrite(_HornPin, HIGH);
  delay(_duration);
  digitalWrite(_HornPin, LOW);
  delay(200);
}//END void honk(...)
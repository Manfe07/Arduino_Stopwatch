#include <Arduino.h>

//Define Inputs
#define Button_L1 0
#define Button_L2 0
#define Button_L3 0
#define Button_R  0


bool system_armed = false;
bool active_race = false;

bool button_L1_pressed = false;
bool button_L2_pressed = false;
bool button_L3_pressed = false;
bool button_R_pressed = false;

bool L1_finished = false;
bool L2_finished = false;
bool L3_finished = false;

unsigned long L1_time_finished;
unsigned long L2_time_finished;
unsigned long L3_time_finished;
unsigned long L1_time;
unsigned long L2_time;
unsigned long L3_time;
unsigned long startTime;


void setup() {
  init_IO();
}//END void setup()


void loop() {
  read_Buttons();
  
  //if Red-Button is pressed, arm the system
  if(button_R_pressed){
    system_armed = true;

    //while the system is armed check for a start signal
    while(system_armed){
      read_Buttons(); //continuesly read the buttons

      //if Red-Button pressed again, dissarm the system
      if (button_R_pressed) {
        system_armed = false;
      }
      //else.. check if a Lane-Button is pressed to start the race
      else if(button_L1_pressed || button_L2_pressed || button_L3_pressed)
      {
        startTime = millis(); //save the current start-time
        active_race = true;   //set the race as active

        L1_time_finished = 0;
        L2_time_finished = 0;
        L3_time_finished = 0;

        delay(2000);     // 2 sec. delay to prevent accidentally start and instantly finish

        //while the race is active,...
        while(active_race){
          read_Buttons();     //continuesly read the buttons
          
          if(button_L1_pressed && L1_finished == 0){
            L1_time_finished = millis();
            L1_finished = true;
          }
          if(button_L2_pressed && L2_finished == 0){
            L2_time_finished = millis();
            L2_finished = true;
          }
          if(button_L3_pressed && L3_finished == 0){
            L3_time_finished = millis();
            L3_finished = true;
          }

          if(L1_finished && L2_finished && L3_finished){
            active_race == false;
          }
        }
      }
      system_armed = false;   //disarm the system
      calc_time();
      //calculate the needed time
    }
  }
  
}//END void loop()


void read_Buttons(){
  button_L1_pressed = digitalRead(Button_L1);
  button_L2_pressed = digitalRead(Button_L2);
  button_L3_pressed = digitalRead(Button_L3);
  button_R_pressed = digitalRead(Button_R);
}//END void read_buttons()

void calc_time(){
    L1_time = L1_time_finished - startTime;
    L2_time = L2_time_finished - startTime;
    L3_time = L3_time_finished - startTime;
}//END void calc_time()


void init_IO(){
  pinMode(Button_L1, INPUT);
  pinMode(Button_L2, INPUT);
  pinMode(Button_L3, INPUT);
  pinMode(Button_R, INPUT);
}//END void init_IO()
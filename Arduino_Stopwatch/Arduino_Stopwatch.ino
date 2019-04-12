#include "stopwatch.h"
#include "camera.h"
#include "wiring.h"
#include "settings.h"
#include "functions.h"
#include <Wire.h> 
#include <LiquidCrystal_I2C.h>

LiquidCrystal_I2C lcd(0x27,20,4);  // set the LCD address to 0x27 for a 16 chars and 2 line display


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

  lcd.init();           //init LCD
  lcd.backlight();      //Turn on LCD backlight
  display_message(0);   //display bootscreen
  delay(3000);          //display for 2 sec

  reset();              //reset Stopwatch
  disarm();
}//END void setup()

void loop() {
  if(r_triggered()){
    arm();
    wait(Button_R,saveTime_long);
  }

  while(armed){
    mainFunction();
    if(r_triggered()){
      disarm();
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
    display_message(4);
    delay(saveTime_long);
  }//END if(-any Button pressed-)
  while(activeRace){
    if(Lane1.trigered() && !Lane1.finished){  //Lane1 finish
      Lane1.race_finished(start_time);
      LineCamera.takePhoto();
      lcd.setCursor(1,3);
      lcd.print("HOME ");
      debug("lane1");
    }
    if(Lane2.trigered() && !Lane2.finished){  //Lane2 finish
      Lane2.race_finished(start_time);
      LineCamera.takePhoto();
      lcd.setCursor(7,3);
      lcd.print("HOME ");
      debug("lane2");
    }
    if(Lane3.trigered() && !Lane3.finished){  //Lane3 finish
      Lane3.race_finished(start_time);
      LineCamera.takePhoto();
      lcd.setCursor(13,3);
      lcd.print("HOME ");
      debug("lane3");
    }
    if(r_triggered()){  //race cancled
      reset();
      disarm();
      display_message(3);
    }
    LineCamera.check();  //check if cameraTriger can be released
    print_time();
    if(Lane1.finished && Lane2.finished && Lane3.finished){
      debug("finish");
      display_message(5);
      activeRace = false;

      while(armed){
        if(r_triggered()){
          disarm();
          wait(Button_R,saveTime_long);
          reset();
        }//END if(...)
      }//END while(armed)
    }//END if(-all finished-)
  }//END while(activeRace)
}//END void mainFunction()


void arm(){
  armed = true;
  debug("armed");
  display_message(1);
}//END void arm()

void disarm(){ 
  armed = false;
  debug("disarmed");
  display_message(2);
}//END void disarm()

bool r_triggered(){
  return !digitalRead(Button_R);
}//END bool r_triggered()


void print_time(){
  double rTime = millis() - start_time;
  rTime = rTime / 1000;
  lcd.setCursor(7,1);
  lcd.print(rTime);
}//END void print_time()


void display_message(int _message){
  switch (_message)
  {
    case 0://bootscreen
      lcd.setCursor(0,0);lcd.print("+------------------+");
      lcd.setCursor(0,1);lcd.print("|  Manuel Fehren   |");
      lcd.setCursor(0,2);lcd.print("|  MF-Technologie  |");
      lcd.setCursor(0,3);lcd.print("+------------------+");
      break;

    case 1://armed
      lcd.setCursor(0,0);lcd.print("+------------------+");
      lcd.setCursor(0,1);lcd.print("|      ARMED!      |");
      lcd.setCursor(0,2);lcd.print("|                  |");
      lcd.setCursor(0,3);lcd.print("+------------------+");
      break;

    case 2://disarmed
      lcd.setCursor(0,0);lcd.print("+------------------+");
      lcd.setCursor(0,1);lcd.print("|     DISARMED!    |");
      lcd.setCursor(0,2);lcd.print("|                  |");
      lcd.setCursor(0,3);lcd.print("+------------------+");
      break;

    case 3://race cancled
      lcd.setCursor(0,0);lcd.print("+------------------+");
      lcd.setCursor(0,1);lcd.print("|       RACE       |");
      lcd.setCursor(0,2);lcd.print("|     CANCLED!     |");
      lcd.setCursor(0,3);lcd.print("+------------------+");
      break;

    case 4://race started
      lcd.setCursor(0,0);lcd.print("    ACTIVE RACE     ");
      lcd.setCursor(0,1);lcd.print("                    ");
      lcd.setCursor(0,2);lcd.print("|LANE1|LANE2|LANE3| ");
      lcd.setCursor(0,3);lcd.print("|GOING|GOING|GOING| ");
      break;
  
    case 5://print finish time
      lcd.clear();
      lcd.setCursor(0,0);lcd.print("   RACE FINISHED    ");
      lcd.setCursor(0,1);lcd.print("LANE1:");
      lcd.setCursor(8,1);lcd.print(Lane1.duration);lcd.print(" sec.");
      lcd.setCursor(0,2);lcd.print("LANE2:");
      lcd.setCursor(8,2);lcd.print(Lane2.duration);lcd.print(" sec.");
      lcd.setCursor(0,3);lcd.print("LANE3:");
      lcd.setCursor(8,3);lcd.print(Lane3.duration);lcd.print(" sec.");
      break;

    default:
      break;
  }
}//END display_message(...)

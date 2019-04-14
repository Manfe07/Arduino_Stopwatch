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
  armed = false;
  activeRace = false;
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
      lcd.setCursor(0,3);
      lcd.print("FINISH");
      debug("lane1_finish");
    }
    if(Lane2.trigered() && !Lane2.finished){  //Lane2 finish
      Lane2.race_finished(start_time);
      LineCamera.takePhoto();
      lcd.setCursor(7,3);
      lcd.print("FINISH");
      debug("lane2_finish");
    }
    if(Lane3.trigered() && !Lane3.finished){  //Lane3 finish
      Lane3.race_finished(start_time);
      LineCamera.takePhoto();
      lcd.setCursor(14,3);
      lcd.print("FINISH");
      debug("lane3_finish");
    }
    if(r_triggered()){  //race cancled
      reset();
      disarm();
      display_message(3);
      break;
    }
    LineCamera.check();  //check if cameraTriger can be released
    print_currentTime();
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


void print_currentTime(){
  double rTime = millis() - start_time;
  rTime = rTime / 1000;
  lcd.setCursor(5,1);
  lcd.print(format_time(rTime));
}//END void print_currentTime()


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
      lcd.setCursor(0,2);lcd.print("LANE1 |LANE2 |LANE3 ");
      lcd.setCursor(0,3);lcd.print("GOING |GOING |GOING ");
      break;
  
    case 5://print finish time
      lcd.clear();
      lcd.setCursor(0,0);lcd.print("-------FINISH-------");
      lcd.setCursor(0,1);lcd.print("LANE1:");
      lcd.setCursor(6,1);lcd.print(format_time(Lane1.duration));
      lcd.setCursor(0,2);lcd.print("LANE2:");
      lcd.setCursor(6,2);lcd.print(format_time(Lane2.duration));
      lcd.setCursor(0,3);lcd.print("LANE3:");
      lcd.setCursor(6,3);lcd.print(format_time(Lane3.duration));
      break;

    default:
      break;
  }
}//END display_message(...)


String format_time(double _time){
  String text = "";
  if(_time < 10)
    text = "  ";
  else if(_time <100)
    text = " ";
  else
    text = "";

  text += _time;
  text += "sec.";

  return text;
}
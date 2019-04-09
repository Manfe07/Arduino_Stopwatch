#ifndef STOPWATCH_H
#define STOPWATCH_H

static unsigned long start_time;
    
class Lane{
  public:
    Lane(int);
    bool finished;
    double duration;
    bool trigered(); 
    void race_finished();
    void reset();
  //END public
  private:
    int pin;
    unsigned long finish_time;
  //END private
};//END class LANE{}


class Camera{
  public:
    Camera(int, int);
    void takePhoto();
    void check();
    void reset();
  //END public
  private:
    int pin;
    int duration;
    bool trigered = false;
    bool stoped = true;
    unsigned long time_trigered;
  //END private
};//END class Camera{}
#endif
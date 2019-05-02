#ifndef STOPWATCH_H
#define STOPWATCH_H

class Lane{
  public:
    Lane(int);
    bool finished;
    float duration;
    bool trigered(); 
    void race_finished(unsigned long);
    void reset();
  //END public
  private:
    int pin;
    unsigned long finish_time;
  //END private
};//END class LANE{}

#endif
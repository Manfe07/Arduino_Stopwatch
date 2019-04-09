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

#endif
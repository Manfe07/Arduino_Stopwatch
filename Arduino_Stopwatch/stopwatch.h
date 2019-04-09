#ifndef STOPWATCH_H
#define STOPWATCH_H

static unsigned long start_time;
    
class Lane{
  public:
    //variables
    bool finished;
    double duration;
    bool trigered(); 
    //functions
    Lane(int);
    void race_finished();
    void reset();
  //END public
  private:
    //wiring
    int pin;
    //variables
    unsigned long finish_time;
  //END private
};//END class LANE{}

#endif
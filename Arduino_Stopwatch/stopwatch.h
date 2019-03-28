#ifndef STOPWATCH_H
#define STOPWATCH_H
    
class Lane{
  public:
    //variables
    bool finished;
    double duration; 
    unsigned long start_time;
    //functions
    Lane();
    void race_finish();
    void reset();
  private:
    //variables
    unsigned long finish_time;
};

#endif

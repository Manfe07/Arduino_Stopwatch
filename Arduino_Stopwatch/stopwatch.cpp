#include "stopwatch.h"

Lane::Lane(){
  Lane::finished = false;
  Lane::finish_time = 0;
  Lane::start_time = 0;
}

Lane::race_finished(){
  Lane::finish_time = millis();
  Lane::duration = Lane::finish_time - Lane::start_time;
  Lane::finished = true;
}

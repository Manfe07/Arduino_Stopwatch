#ifndef CAMERA_H
#define CAMERA_H

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
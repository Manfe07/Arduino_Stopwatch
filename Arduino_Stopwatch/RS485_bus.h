#ifndef RS485_BUS_H
#define RS485_BUS_H

#include "arduino.h"

//Validation Bytes
#define start_byte  0xF5
#define stop_byte   0x0D

//Bus Message code
#define C_ping      0x01   //send ping
#define C_mode      0x02   //Counter-Value
#define C_pTime1    0x11   //preview Time1
#define C_pTime2    0x12   //preview Time2
#define C_pTime3    0x13   //preview Time3
#define C_oTime1    0x21   //official Time1
#define C_oTime2    0x22   //official Time2
#define C_oTime3    0x23   //official Time3


// Mode code
#define M_stop      0x0000
#define M_start     0x0001
#define M_arm       0x0002
#define M_disarm    0x0003



class Bus {
  private:
    int enablePin;
  public:
    Bus(int);
    int get(uint8_t&, uint16_t&);
    int send(uint8_t, uint16_t);
};
#endif

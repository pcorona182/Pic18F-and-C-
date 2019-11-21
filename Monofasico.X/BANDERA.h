/*
   File:   BANDERA.h
   Author: Pablo Corona

   Created on 07 de noviembre de 2011, 01:08 PM
 */

typedef struct {
  
    unsigned BAN0        :1;
    unsigned BAN1        :1;
    unsigned BAN2        :1;
    unsigned BAN3        :1;
    unsigned BAN4        :1;
    unsigned BAN5        :1;
    unsigned BAN6        :1;
    unsigned BAN7        :1;
  
}BANDERAS;
//static BANDERAS BANDERA;
BANDERAS BANDERA;


#define BAND0                    BANDERA.BAN0
#define BAND1                    BANDERA.BAN1
#define BAND2                    BANDERA.BAN2
#define BAND3                    BANDERA.BAN3
#define BAND4                    BANDERA.BAN4
#define BAND5                    BANDERA.BAN5
#define BAND6                    BANDERA.BAN6
#define BAND7                    BANDERA.BAN7


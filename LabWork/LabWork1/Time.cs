using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork1
{
    public class Time
    {
        public int hour, min, sec;   //three fields or variable 

        public Time()              //default constructors 
        {
            hour = 1;
            min = 2;
            sec = 30;
        }
        public Time(int hour, int min, int sec)
        {
            this.hour = hour;
            this.min = min;
            this.sec = sec;
        }   
    }

}

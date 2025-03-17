using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Addition
{
    class Time
    {

        //Attributes
        int hour, min, sec;

        //Methods
        public Time()
        {
            this.hour = 0;
            this.min = 0;
            this.sec = 0;
        }
        public Time(int hour, int min, int sec)
        {
            this.hour = hour;
            this.min = min;
            this.sec = sec;
        }
        public string getTime()
        {
            return string.Format("Time : {0}' {1}'' {2}'''", hour, min, sec);
        }

        //Operator overloading
        public static Time operator +(Time t1, Time t2)
        {
            Time t3 = new Time();
            t3.hour = t1.hour + t2.hour;
            t3.min = t1.min + t2.min;
            t3.sec = t1.sec + t2.sec;
            if (t3.sec >= 60)
            {
                t3.sec -= 60;
                t3.min++;
            }
            if (t3.min >= 60)
            {
                t3.min -= 60;
                t3.hour++;
            }
            return t3;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace lab2_Se320
{
    class Time
    {
        //I will declare insrance varible hour,minute and seconde below here..
       private int hour;
       private int minute;
       private int second;

        public Time(int hour,int minute,int second)//Constructor method
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;

        }

        public int Hour { get => hour; set => hour = value; }
        public int Minute { get => minute; set => minute = value; }
        public int Second { get => second; set => second = value; }

        public void displayTime()
        {
            Console.WriteLine(hour+":"+minute+":"+second);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Se307_Lab8_Problem2
{
    class Human : IClimb,ILearn,ISpeak,Ithink
    {
        String name;
        int age;
        public Human(String humanName, int humanAge)
        {

            this.name = humanName;
            this.age = humanAge;
        }

        void IClimb.climb()
        {
            Console.WriteLine("Human can climb");
        }

        void ILearn.learn()
        {
            Console.WriteLine("Human can learn");
        }

        void ISpeak.speak()
        {
            Console.WriteLine("Human can speak");
        }

        void Ithink.think()
        {
            Console.WriteLine("Human can think");
        }
    }
}

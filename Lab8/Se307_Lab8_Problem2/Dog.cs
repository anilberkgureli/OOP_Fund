using System;
using System.Collections.Generic;
using System.Text;

namespace Se307_Lab8_Problem2
{
    class Dog : Animal,ILearn
    {
        public Dog(String dogName ,  int dogLife) : base(dogName, dogLife)
        {
            base.Name = dogName;
            base.LifeExpentancy = dogLife;
        }

        public override void remember()
        {
            Console.WriteLine("Dogs can remember clearly");
        }
        public override void protectOwner()
        {
            Console.WriteLine("Dogs can protect its owner very good!");
        }

         void ILearn.learn()
        {
            Console.WriteLine("Dogs can learn");
        }




    }
}

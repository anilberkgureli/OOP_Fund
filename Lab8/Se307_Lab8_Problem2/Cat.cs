using System;
using System.Collections.Generic;
using System.Text;

namespace Se307_Lab8_Problem2
{
    class Cat: Animal,IClimb 
    {
        public Cat(String catName, int catLife) : base (catName , catLife)
        {
            base.Name = catName;
            base.LifeExpentancy = catLife;
        }

        public override void remember()
        {
            Console.WriteLine("Cat remembers strongly");
        }

        public override void protectOwner()
        {
            Console.WriteLine("Cat can not protect its owner");
        }

         void IClimb.climb()
        {
            Console.WriteLine("Cat can climb");
        }
    }
}

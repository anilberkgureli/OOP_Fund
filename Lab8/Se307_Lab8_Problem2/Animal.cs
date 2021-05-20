using System;
using System.Collections.Generic;
using System.Text;

namespace Se307_Lab8_Problem2
{
   public abstract class Animal
    {
        String name;
        int lifeExpentancy;

        public string Name { get => name; set => name = value; }
        public int LifeExpentancy { get => lifeExpentancy; set => lifeExpentancy = value; }

        public Animal(String AnimalName,int animalLife)
        {
            this.Name = AnimalName;
            this.LifeExpentancy = animalLife;
        }

        public abstract void remember();

        public abstract void protectOwner();


    }
}

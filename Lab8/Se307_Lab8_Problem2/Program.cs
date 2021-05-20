using System;

namespace Se307_Lab8_Problem2
{
    class Program
    {
        static void Main(string[] args)
        {

            ISpeak ahmet = new Human("ahmet",15);
            ahmet.speak();

            Ithink mehmet = new Human("mehmet", 25);
            mehmet.think();

            IClimb burak = new Human("burak", 18);
            burak.climb();

            ILearn merve = new Human("merve" , 20);
            merve.learn();

            IClimb pamuk = new Cat("pamuk",12);
            pamuk.climb();

            ILearn hera = new Dog("hera", 15);
            hera.learn();
            
        }
    }
}

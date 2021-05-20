using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_Se307_Problem7
{
    class ActivityRoom
    {
        private int numberOfPeople; //instance variable of number of people in the activity room
        private int capacity; //instance variable of the capacity of the activity room
        private int cumulativeAgeOfPeople; //instance variable of the total age of the people in the activity room

        public int NumberOfPeople { get => numberOfPeople; set => numberOfPeople = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public int CumulativeAgeOfPeople { get => cumulativeAgeOfPeople; set => cumulativeAgeOfPeople = value; }
        

        public ActivityRoom(int numberOfPeople, int capacity, int cumulativeAgeOfPeople)
        {
            this.numberOfPeople = numberOfPeople;
            this.capacity = capacity;
            this.cumulativeAgeOfPeople = cumulativeAgeOfPeople;
        }

       public int age;
       public int Age { get => age; set => age = value; }
        public void validityCheck()
        {
            if (numberOfPeople < 0 || numberOfPeople>capacity)
            {
                Console.WriteLine("You entered an invalid value!");
                Console.WriteLine("*****Program is terminating*****");
                Environment.Exit(0);
            }
            if (capacity<4 || capacity>12)
            {
                Console.WriteLine("Room capacitiy is overloaded!");
                Console.WriteLine("*****Program is terminating*****");
                Environment.Exit(0);
            }
            if (cumulativeAgeOfPeople<0) {
                Console.WriteLine("You entered an invalid value!");
                Console.WriteLine("*****Program is terminating*****");
                Environment.Exit(0);
            }
            
        }
        
        public void acceptAPerson() {

            age = Console.Read();
          
            if (numberOfPeople < capacity )
            {
                Console.WriteLine("Accepted");
                numberOfPeople++;
            }
        
            else if (age >= 13)
            {
              
                Console.WriteLine("Accepted");
                numberOfPeople++;
            }
            else 
            
                Console.WriteLine("Rejected!");
            
            

           

        }
        public void leaveFromRoom() {
            Console.WriteLine("A person is leaving the activity room");
            numberOfPeople--;

            
        }

        public bool isRoomFull()
        {
            if (numberOfPeople == capacity)
            {
                return true;
            }
            else
                return false;
        }
        public double calculateAverageAgeOfPeople()
        {
            return cumulativeAgeOfPeople / numberOfPeople;
        }

        public void displayActivityRoomInfo()
        {
            Console.WriteLine("Number of people in the room: "+numberOfPeople);
            Console.WriteLine("Average age of the people: "+calculateAverageAgeOfPeople());
            Console.WriteLine("Total capacity of the room: "+capacity);
        }
       
    }
}

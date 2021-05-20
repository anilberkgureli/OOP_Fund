using System;

namespace Lab2_Se307_Problem7
{
    class ActivityRoomTest
    {
        static void Main(string[] args)
        {
            ActivityRoom act = new ActivityRoom(4,8,73);
            act.validityCheck();

           
            Console.WriteLine("\n*****Welcome to the activity room*****\n");
            
            Console.WriteLine("\nCurrently room info for beginning...\n");
            act.displayActivityRoomInfo();
            Console.WriteLine("\nHow old the person want to get in the activity room?\n");
            //ActivityRoom.Age = Console.Read();

            act.acceptAPerson();
            act.displayActivityRoomInfo();
            Console.WriteLine();          

            act.leaveFromRoom();
            act.displayActivityRoomInfo();
        }
    }
}

using System;
using System.Collections;
namespace Se307_Lab3_Problem2
{
    class Program
    {
        static void Main(string[] args)
        {

            HardwareStore hware = new HardwareStore();

            int number=0;
            do
            {


                try
                {
                    hware.DisplayMenu();

                    number = Convert.ToInt32(Console.ReadLine());

                    switch (number)
                    {
                        case 1:
                            Console.WriteLine("Please enter a hardware component (Please use uppercase letters)");
                            string hardwareComponent = Console.ReadLine();

                            if( hware.GetComponentbyName(hardwareComponent)== null)
                            {
                                Console.WriteLine("You entered an invalid entry");
                            }
                            else{
                                hware.GetComponentbyName(hardwareComponent).ListProducts();
                            }
                             break;
                        case 2:
                            Console.WriteLine("Get hardware component list");
                            foreach (Component c in hware.ComponentList)
                            {
                                Console.Write(c.Name + ", ");
                            }
                            break;

                        case 3:
                            Console.WriteLine("Please enter a hardware component");
                            hardwareComponent = Console.ReadLine();
                            int numberForEdit;
                            Console.WriteLine("Do you want to add or remowe product?");
                            numberForEdit = Convert.ToInt32(Console.ReadLine());
                            switch (numberForEdit)
                            {
                                case 1:
                                    Console.WriteLine("Please input name of the product");
                                    string newProductName = Console.ReadLine();
                                    if (hware.GetComponentbyName(hardwareComponent) == null)
                                    {
                                        Console.WriteLine("You entered an invalid entry");
                                    }
                                    else
                                    {
                                        hware.GetComponentbyName(hardwareComponent).ProductList.Add(newProductName);
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("Specify product position");
                                    int numberForDeleteIndex = Convert.ToInt32(Console.ReadLine());
                                    if (hware.GetComponentbyName(hardwareComponent) == null)
                                    {
                                        Console.WriteLine("You entered an invalid entry");
                                    }
                                    else
                                    {
                                        hware.GetComponentbyName(hardwareComponent).ProductList.RemoveAt(numberForDeleteIndex - 1); // We are doing this because array indexes start from 0 
                                    }
                                    
                                    break;
                            }
                            break;
                    }
                }
                
                catch (NullReferenceException)
                {
                    Console.WriteLine("You entered an invalid data");
                }
                catch (FormatException)
                {
                    Console.WriteLine("You entered a wrong data format");
                }
                catch 
                {
                    Console.WriteLine("Unexpected error happened");
                }
            } while (number != -1);
                Console.WriteLine("Exiting...");
                Console.WriteLine("Program is terminating");
            

            
            
        }
    }
}

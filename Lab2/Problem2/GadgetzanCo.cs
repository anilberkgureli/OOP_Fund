using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_Se320_Problem2
{
    class GadgetzanCo
    {
        private int productNumber;
        private string productName;
        private double unitPrice;
        private int quantity;
        

        // I will create get and set mehtods below...
        public int ProductNumber { get => productNumber; set => productNumber = value; }
        public string ProductName { get => productName; set => productName = value; }
        public double UnitPrice { get => unitPrice; set => unitPrice = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        //Now I will create constructor method below here...
        public GadgetzanCo(int productNumber,string productName,double unitPrice,int quantity)  //The constructor method
        {
            this.productNumber = productNumber;
            this.ProductName = productName;
            this.unitPrice = unitPrice;
            this.quantity = quantity;
        }

        public double calculateCost()  //Method for compute total cost of the item.
        {
            return quantity * unitPrice;
            
        }

        public void displayCost()
        {
            Console.WriteLine("Product number: "+productNumber);
            Console.WriteLine("Product name: " + productName);
            Console.WriteLine("Unit Price: " + unitPrice);
            Console.WriteLine("Quantity: " + quantity);
            Console.WriteLine("Total cost: "+calculateCost());
        }


    }
}

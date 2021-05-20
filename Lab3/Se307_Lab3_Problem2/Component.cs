using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Se307_Lab3_Problem2
{
    class Component
    {
        private string name;
        private ArrayList productList = new ArrayList();

        public Component(string name,ArrayList productList)
        {
            this.name = name;
            this.productList = productList;
        }

        public void ListProducts()
        {

            foreach (String c in this.ProductList)
            {
                Console.Write(c+ ", ");
            }
            
        }
        public string Name { get => name; set => name = value; }
        public ArrayList ProductList { get => productList; set => productList = value; }
    }
}

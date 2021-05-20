using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Brake
    {
        private String type;

        public string Type { get => type; set => type = value; }

        public Brake(String type)//constructor method
        {
            this.type = type;
        }

        public void apply()
        {
            Console.WriteLine("Break Applied");
        }

    }
}

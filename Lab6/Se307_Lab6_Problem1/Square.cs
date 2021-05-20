using System;
using System.Collections.Generic;
using System.Text;

namespace Se307_Lab6_Problem1
{
    class Square : Rectangle
    {
        private int sideLength;
        public Square(int sideLength) : base(sideLength,sideLength)
        {
            this.SideLength = sideLength;
        }

        public int SideLength { get => sideLength; set => sideLength = value; }
    }
}

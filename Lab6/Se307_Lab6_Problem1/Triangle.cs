using System;
using System.Collections.Generic;
using System.Text;

namespace Se307_Lab6_Problem1
{
    class Triangle : Shape
    {
        private int sideLengtA;
        private int sideLengtB;
        private int sideLengtC;

        public Triangle(int sideLengtA, int sideLengthB, int sideLengthC)
        {
            this.SideLengtA = sideLengtA;
            this.SideLengtB = sideLengtB;
            this.SideLengtC = sideLengtC;
        }

        public int SideLengtA { get => sideLengtA; set => sideLengtA = value; }
        public int SideLengtB { get => sideLengtB; set => sideLengtB = value; }
        public int SideLengtC { get => sideLengtC; set => sideLengtC = value; }
    }
    
    
 }

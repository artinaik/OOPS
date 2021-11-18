using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    abstract class Abstraction
    {
        public abstract double Area();
        
    }
    class Rectangle:Abstraction
    {
        public double length = 20;
        public double width = 10;
        public override double Area()
        {
            return length * width;
        }
    }
}

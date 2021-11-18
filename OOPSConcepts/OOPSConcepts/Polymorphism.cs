using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    class Polymorphism
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public double add(int a, double b)
        {
            return a + b;
        }
        public int add(int a, int b,int c)
        {
            return a + b + c;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OOPS Concepts");
            Console.WriteLine("1)Inheritance");
            AvarageMarks avarageMarksobj = new AvarageMarks();
            avarageMarksobj.FindAvg();
            Console.ReadKey();

        }
    }
}

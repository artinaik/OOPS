using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    class Inheritance
    {
       public double mathMarks =55.5;
       public double englishMarks=60;
       public double hindiMarks = 64.5;
       public double scienceMarks =70;
        public double totalMarks;
        public double Total()
        {
            totalMarks = mathMarks + englishMarks + hindiMarks + scienceMarks;
            return totalMarks;
        }
    }
    class AvarageMarks:Inheritance
    {
        public double avg;
        public void FindAvg()
        {
            Total();
            avg = totalMarks / 4;
            Console.WriteLine("Avarage marks is " + avg);
        }
    }
}

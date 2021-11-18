using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    class WhileLoop
    {
        int num = 1;
        public void Power()
        {
            while (num <= 10)
            {
                Console.WriteLine(Math.Pow(2, num));
                num++;
            }
        }
    }
}

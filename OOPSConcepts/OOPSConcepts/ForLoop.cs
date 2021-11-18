using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    class ForLoop
    {
        public void Power()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
        }
    }
}

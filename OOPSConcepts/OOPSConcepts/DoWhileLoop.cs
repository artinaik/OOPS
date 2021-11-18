using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    class DoWhileLoop
    {
        int i = 1;
        public void Power()
        {
            do
            {
                Console.WriteLine(Math.Pow(2, i));
                i++;
            } while (i <= 10);
        }
    }
}

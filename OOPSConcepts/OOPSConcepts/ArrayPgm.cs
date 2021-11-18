using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    class ArrayPgm
    {
        public void FindMax()
        {
            int[] arr = new int[] { 35, 28, 20, 89, 63, 45, 12 };
            int greater = 0;
            int small = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);

                if (arr[i] > arr[0])
                {
                    greater = arr[i];
                }
                else
                {
                    small = arr[i];

                }
            }

            Console.WriteLine("Greater number in an array is" + greater);
            Console.WriteLine("Smaller number in an array is " + small);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    class SwitchCase
    {
        public void Operation()
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int choice = 0;
            Console.WriteLine("1)Addition");
            Console.WriteLine("2)Substraction");
            Console.WriteLine("3)Multiplication");
            Console.WriteLine("4)Division");
            Console.WriteLine("Enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your choice");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    num3 = num1 + num2;
                    Console.WriteLine("Addition is " + num3);
                    break;
                case 2:
                    num3 = num1 - num2;
                    Console.WriteLine("Substraction is " + num3);
                    break;
                case 3:
                    num3 = num1 * num2;
                    Console.WriteLine("Multiplication is " + num3);
                    break;
                case 4:
                    num3 = num1 / num2;
                    Console.WriteLine("Division is " + num3);
                    break;
                default:
                    Console.WriteLine("Wrong Choice");
                    break;

            }
        }
    }
}
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
            /*Console.WriteLine("1)Inheritance");
            AvarageMarks avarageMarksobj = new AvarageMarks();
            avarageMarksobj.FindAvg();

            Console.WriteLine("2)Polymorphism");
            Polymorphism polymorphismobj = new Polymorphism();
            Console.WriteLine(polymorphismobj.add(25, 45));
            Console.WriteLine(polymorphismobj.add(25, 12.54));
            Console.WriteLine(polymorphismobj.add(12, 47, 34));

            Console.WriteLine("3)Abstraction");
            Rectangle rectangleobj = new Rectangle();
            Console.WriteLine("Area of rectangle is  " +rectangleobj.Area());

            Console.WriteLine("4)IfElse statement");
            Console.WriteLine("Greater number program");
            IfElse ifElseobj = new IfElse();
            ifElseobj.Max();
            
            Console.WriteLine("\n5)SwitchCase statement");
            Console.WriteLine("Airthmetic operations");
            SwitchCase switchCaseobj = new SwitchCase();
            switchCaseobj.Operation();
            
            Console.WriteLine("\n6)While Loop ");
            WhileLoop whileLoopobj = new WhileLoop();
            whileLoopobj.Power();

            Console.WriteLine("\n7)Do While Loop ");
            DoWhileLoop dowhileLoopobj = new DoWhileLoop();
            dowhileLoopobj.Power(); 

            Console.WriteLine("\n8)For Loop ");
            ForLoop forLoopobj = new ForLoop();
            forLoopobj.Power();*/

            Console.WriteLine("\n9)Array program for greater number");
            ArrayPgm arrayPgmobj = new ArrayPgm();
            arrayPgmobj.FindMax();
            Console.ReadKey();

        }
    }
}

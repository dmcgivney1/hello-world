using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {


            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;

           
            }

            for ( int index = 0; index <10; index ++)
            {
                Console.WriteLine($"Hello World!  The index is {index}");
            }








            Console.ReadKey();

        }


        static void maths()
        { 
            Console.WriteLine("Hello, world!");
            //Console.WriteLine("This is now in the First_edit branch");
            //Console.WriteLine(" merging to main");

            //double a = 5;
            //double b = 4;
            //double c = 2;
            //double d = (a + b) / c;
            //Console.WriteLine(d);

            double e = 19;
            double f = 23;
            double g = 8;
            double h = (e + f) / g;
            Console.WriteLine(h);


            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");


            double third = 1.0 / 3.0;
            Console.WriteLine(third);

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);




            Console.ReadLine();
        }

        static void testlimits()
        {
                  int a = 7;
        int b = 4;
        int c = 3;
        int d = (a + b) / c;
        int e = (a + b) % c;
        Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");


            int max = int.MaxValue;
        int min = int.MinValue;
        Console.WriteLine($"The range of integers is {min} to {max}");


            int what = max + 3;
        Console.WriteLine($"An example of overflow: {what}");

            }

}
}

using System;
using System.Runtime.CompilerServices;

namespace Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {

            PyramidShape();


        }

        static void PyramidShape()

        {
            Console.WriteLine("Select an odd number");
            int n = 5;

            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    Console.Write("   ");

                }
                for (int k = 1; k <= 2*i-1; k++)
                {
                    Console.Write("*" + "  ");

                }
                Console.WriteLine();
            }
        }
       

    }
}

        
   


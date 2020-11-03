using System;

namespace Excercise
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i += 10)
            {
                for (int j = i; j < i + 10; j++)
                {
                    Console.Write(" {0} ", j.ToString("D2"));
                }
                Console.WriteLine("end of j Loop");
            }

            Console.WriteLine("end of i Loop");

            Console.ReadLine();
        }
    }
    }


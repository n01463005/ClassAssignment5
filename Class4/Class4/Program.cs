using System;
using System.Reflection.Metadata.Ecma335;

namespace Class4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 20;
            int num3 = 20;
            string be = "He";
            string be1 = "eH";
            //int result = num1 == num3 ? 50 : 100; // this is called ternary operator.
            //Console.WriteLine(result);
           int result = num1 += num3;
            Console.WriteLine(result);

            num1++;
            Console.WriteLine(num1);
            ++num1;
            Console.WriteLine(num1);
            int answer = 2 * ++num1;
            Console.WriteLine(answer);
            Console.WriteLine(num1);

            if (be == be1)
                Console.WriteLine("Equal");
            else
                Console.WriteLine("notequal");

        }
    }
}

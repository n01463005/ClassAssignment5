using System;

namespace Class4Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 42, 58, 32, 13 };
            for (int x = 0; x < 5; x++)
                Console.Write(numbers[x] + " , ");
            
            // OR
            foreach (var n in numbers)
                Console.Write(n + " ' ' ");
            Console.ReadLine();


            int number = 41;

            if (number % 2 == 0)
                Console.WriteLine("even");
            else
            {
                if (number % 3 == 0)
                    Console.WriteLine("Multiple of 3");
                else
                    Console.WriteLine("odd");
            }
            switch(number)
            {
                case 40: Console.WriteLine("even");
                    break;
                case 41: Console.WriteLine("odd");
                    break;
                default: Console.WriteLine("Ok");
                    break;
            }
            while (number < 50)
            {
                Console.Write(number + " , ");
                number++;
            }
        }

    }
}

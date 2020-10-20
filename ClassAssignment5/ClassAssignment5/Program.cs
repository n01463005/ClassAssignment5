using System;

namespace ClassAssignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            
            
        }
        private static void Add()
        {
            Console.WriteLine("Type a number ");

            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Select + operator ");

            string Add = Console.ReadLine();

            Console.Write("Type a number ");

            double b = Convert.ToDouble(Console.ReadLine());

           if (Add == "+")
            {
                Console.Write(a + b);
            }
           else
            {
                Console.WriteLine("invalid statment");
            }
            Console.ReadLine();
           


           
        }
        

    }
}

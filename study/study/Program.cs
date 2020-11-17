using System;
using System.Security.Cryptography.X509Certificates;

namespace study
{
    class Program
    {
        static void Main(string[] args)
        {
            Maths();

        }
        public static void Maths()
        {
            Console.WriteLine("Choose mathematical operation");
            Console.WriteLine("Option 1 Addition");
            Console.WriteLine("option 2 subractrion");
            Console.WriteLine("option 3 Multiplication");
            Console.WriteLine("Option 4 Divition");
            string result = Console.ReadLine();
            if (result == "1")
            {
                Addition();
            }
            else if(result == "2")
                {

                Subtraction();
            }
            else if (result == "3")
            {
                Multiplication();
            }
            else if (result == "4")
            {
                Division();
            }
            else
            {
                Console.WriteLine("Error");
            }

        }
        public static void Addition()
        {
            Console.WriteLine("Select numbers to Add them");
            string input = Console.ReadLine();
            string[] ParseDann = input.Split('+');
            int result = 0;
            foreach(string x in ParseDann)
            {
                int y = 1;
                if (int.TryParse(x, out y))
                {
                    
                    result += y;
                }
            }
            Console.WriteLine(result);
        }
        public static void Subtraction()
        {
            Console.WriteLine("Select numbers to apply subtraction");
            string input = Console.ReadLine();
            string[] ParseBetty = input.Split('-');
            int result = 0;
            foreach(string x in ParseBetty)
            {
                int y = 0;
                if (int.TryParse(x,  out y))
                {
                    result = result - y;
                        
                }
            }
            Console.WriteLine(result);
        }
        public static void Multiplication()
        {
            Console.WriteLine("Select numbers to multiplay");
            string Haile = Console.ReadLine();
            string[] ParseHailu = Haile.Split('*');
            int result = 0;
            foreach(string x in ParseHailu)
            {
                int y = 0;
                if (int.TryParse(x, out y))
                {
                    result = y * result;
                }
            }
            Console.WriteLine(result);
        }
        public static void Division()
        {
            Console.WriteLine("Select numbers to apply Division");
            string judy = Console.ReadLine();
            string[] ParseJudey = judy.Split('/');
            int result = 0;
            foreach (string x in ParseJudey)
            {
                int y = 0;
                if(int.TryParse(x, out y))
                {
                    result /= y;
                }
            }
            Console.WriteLine(result);
        }
        
    }
}

using System;

namespace Class4Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //throw new Exception(); 
            try
            {
                Console.WriteLine(DividexByY(0, 0));
            }
            catch (Exception e)
            {
                Console.WriteLine("You can't divide by zero");
            }
        }
        private static decimal DividexByY(int x , int y)
        {
            
            
                return x / y;

            
           
        }

    }
}

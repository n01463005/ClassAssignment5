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
            string input = Console.ReadLine();
            string[] parseString = input.Split('+');
            int result = 0;
            foreach (string x in parseString)
            {
                int y = Convert.ToInt32(x);
                result = y + result;
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
  }        // if (int.TryParse(Console.ReadLine(), out n))
         //   {
   }            
           /*  //   if (int.TryParse(Console.ReadLine(), out i))
                {
                    sum = i + n;
                    Console.Write("The sum of the numbers is :");
                    Console.WriteLine(sum);
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                Console.WriteLine("enter a valid number");
                return false;
            }
            */
               
         /*   double a = Convert.ToDouble(Console.ReadLine());

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
           */


           
        
        

    


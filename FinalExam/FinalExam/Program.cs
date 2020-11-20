using System;

namespace FinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            Adult adult = new Adult();
            Child child = new Child();


            foreach (child in Child)
            {

            }

        }

        public class Parent
        {
            Array[,] String = new Array[,] { firstname, lastname };

        }

        public class Adult:Parent
        {
            string firstname, lastname;
            
            public Adult()
            {
              string  name = firstname + lastname;
                
            }
        }
        
        public class Child:Parent
        {
            string firstname, lastname;
        }
        

    }
    
}

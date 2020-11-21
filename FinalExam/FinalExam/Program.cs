using System;

namespace FinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            Adult adult = new Adult();
            adult.FName = Paul;
            adult.LName = Peter;
            Child child = new Child();
            child.FName = winta;
            child.LName = Samiel;

        Parent[] Names = new Parent[] {adult,child};
            foreach (Parent N in Names)
            {
                    N.Name();
            }

        }

        public Interface Parent
        {
           public void Name();            

        }

        public class Adult:Parent
        {
           public  string firstname, lastname;
            
            public void Name()
            {
              Console.Write(FName);
                Console.Write(LName);
                
            }
        }
        
        public class Child:Parent
        {
           public string firstname, lastname;
            public void Name()
            {
                Console.Write(FName);
                Console.Write(LName);
             }
        

         }
    
}

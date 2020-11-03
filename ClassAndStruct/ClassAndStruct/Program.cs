using System;

namespace ClassAndStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Betty", "Kidane");
            Console.WriteLine(person1);

            Console.WriteLine(person1.GetFirstName());
            person1.SetFirstName("Betty");

            person1.City = "Keren";

            Console.WriteLine(Person.Galaxy);

            int[] myList = { 1, 2, 3, 4, 5 };
            int factor = 3;
            Example.MultiplyArray(myList, factor);
            for (int i = 0; i < myList.Length; i++) ;
            Console.WriteLine(myList[i]);
            Console.WriteLine(factor);
        }
        public class Example
        {
            public static void MultiplyArray(int [] array, int factor)
            {
                for (int i = 0; i < array.Length; i++)
                    array[i] *= factor;
                factor++;
            }


        }
       public class Person
        {

           private string FirstName;
            private string LastName;
           public string City;
            public static string Galaxy = "Mars";
            public Person(string FirstName, string LastName)
            {
                this.FirstName = FirstName;
                this.LastName = LastName;
            }
            public void SetFirstName(String FName)
            {
                FirstName = FName;
            }
            public string GetFirstName()
            {
                return FirstName;
            }
        }
    }
}

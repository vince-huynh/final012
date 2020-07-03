using System;

namespace final
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] arr = new Person[2];
            arr[0] = new Adult();
            arr[0].FirstName = "adult firstname";
            arr[0].LastName = "adult lastname";

            arr[1] = new Child();
            arr[1].FirstName = "child firstname";
            arr[1].LastName = "child last name";

            foreach (Person x in arr)
            {
                Console.WriteLine(x.Display());
            }
        }

        public abstract class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Display()
            {
                return FirstName + " " + LastName;
            }
        }

        public class Adult : Person
        {
        }

        public class Child : Person
        {
        }
    }
}

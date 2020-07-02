using System;

namespace final
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeClass test = new SomeClass();
            test.SomeClassMethod();
        }

        public class SomeClass 
        {
            public void SomeClassMethod()
            {
                Console.WriteLine("Hello World!");
            }
        }
    }
}

using System;

namespace ConsoleApp3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Andrey";
            byte MyAge = 15;
            bool HaveIPet = false;
            double MyShoeSize = 42.7;

         Console.WriteLine("My name is" + MyName);
         Console.WriteLine("My age is " + MyAge);
         Console.WriteLine("Do I have pet?" + HaveIPet);
         Console.WriteLine("My shoe size is" + MyShoeSize);

         Console.ReadKey();
        }
    }
}

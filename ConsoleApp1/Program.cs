// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main1(string[] args)
        {
            string name = "Damiën";
            char surname = 'M';
            int age = 23;
            Console.WriteLine(name + " " + surname + " and my age is " + age);
            Console.WriteLine(name.Length);
            Console.WriteLine(name.ToUpper());
            Test1();
        }
        private static void Test1()
        {
            int x = 35;
            int y = 23;
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }
        }


       
    }
    
}

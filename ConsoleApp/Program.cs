using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person p1 = new Person("Vage", 19);
            p1.PrintInfo();
            p1.Age = -1;
            p1.Age = 27;
        }
    }
}

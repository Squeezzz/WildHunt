using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person p1 = new Person("Vage", "LastName1", 19);
            p1.PrintInfo();
            p1.Age = -1;
            p1.Age = 27;

            Weapon weapon = new Weapon(5, 2f, 10);
            weapon.Damage += 10;
            weapon.Distance = 1000;
            weapon.ReloadTime -= -10;
            Console.WriteLine(weapon.Shoot());
        }
    }
}

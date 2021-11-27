using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon = new Weapon(5, 2f, 10);
            weapon.Damage += 10;
            weapon.Distance = 1000;
            weapon.ReloadTime -= -10;
            Console.WriteLine(weapon.Shoot());
        }
    }
}

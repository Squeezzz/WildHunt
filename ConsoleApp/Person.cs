using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Person
    {
        private int _age;

        public string Name { get; set; }

        public int Age
        {
            get { return _age; }
            set { _age = value > 0 ?value : 0; PrintActualAge(); }
        }

        public Person() { }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Type: {this.GetType()}\nName: {Name}\nAge:{Age}");
        }

        public void PrintActualAge()
        {
            Console.WriteLine($"From actual age message: {Age}");
        }
    }
}

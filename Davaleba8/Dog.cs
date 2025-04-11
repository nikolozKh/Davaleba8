using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Davaleba8
{
    internal class Dog
    {
        private string _name;
        private string _breed;
        private int _age;

        public string Name { get { return _name; } set { _name = value; } }
        public string Breed { get { return _breed; } set { _breed = value; } }
        public int Age { get { return _age; } set { _age = value; } }
        public Dog(string name, string breed, int age)
        {
            _name = name;
            _breed = breed;
            _age = age;
          
        }
        public void Print()
        {
            Console.WriteLine($"Dog Name: {Name}");
            Console.WriteLine($"Breed: {Breed}");
            Console.WriteLine($"Age: {Age}");
        }
    }
}

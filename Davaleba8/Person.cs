using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Davaleba8
{
    internal class Person
    {

        private string _name;
        private DateTime _birthDate;
        private string _email;
        private string _password;
        private int _age;

        public string Name { get { return _name; } }
        public DateTime BirthDate { get { return _birthDate; } }
        public string Email { get { return _email; } }
        public string Password { get { return _password; } }

        public int Age
        {
            get
            {
                return _age;
            }
        }


        public Person(string name, DateTime birthDate, string email, string password )
        {
            _name = name;
            _birthDate = birthDate;
            _email = email;
            _password = password;
            _age = 2025 - birthDate.Year;

        }



        public void print()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Birth Date: {BirthDate}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Password: {Password}");
            Console.WriteLine($"Age: {Age}");
        }
    }

}

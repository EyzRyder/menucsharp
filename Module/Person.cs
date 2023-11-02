using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace menucsharp.Module
{
    public class Person
    {
        public Person ()
        {

        }
        public Person (string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }
        private string _name;
        private int _age;
        public string Name
        {
            get => _name.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome nao pode ser vazio");
                }
                _name = value;
            }
        }

        public string LastName { get; set; }

        public string FullName => ($"{Name} {LastName}").ToUpper();
        public int Age
        {
            get => _age;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade nao pode ser menor que zero");
                }
                _age = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {FullName}, Idade {Age}");
        }
    }
}
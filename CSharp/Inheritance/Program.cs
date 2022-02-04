using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer()
                {
                    FirstName = "Kutluhan"
                },
                new Student()
                {
                    FirstName = "kutluhan"
                },
                new Person()
                {
                    FirstName = "Azafli"
                }
            };

            foreach (var Person in persons)
            {
                Console.WriteLine(Person.FirstName);
            }

            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer:Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }

}

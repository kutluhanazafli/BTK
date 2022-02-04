using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Customer
    {
        protected int id {get; set; }
        
        private int id;
    }

    class Student
    {
        public void Save()
        {
            Customer customer = new Customer();

        }
    }

    internal class Course
    {
        public string Name { get; set; }
    }
}



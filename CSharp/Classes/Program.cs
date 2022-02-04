﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Kutluhan";
            customer.LastName = "Azafli";
            customer.City = "Mersin";

            Customer customer2 = new Customer
            {
                Id = 2,City = "Ankara", FirstName = "Kutluhan", LastName = "Azafli"
            };

            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }
}

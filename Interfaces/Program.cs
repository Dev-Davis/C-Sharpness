﻿using InterfaceExample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IProductModel> cart = AddProducts();
            Customer customer = GetCustomer();

            foreach (IProductModel prod in cart)
            {
                prod.ShipItem(customer);
            }

            Console.ReadLine();
        }


        private static Customer GetCustomer()
        {
            return new Customer
            {
                FirstName = "Dot",
                LastName = "Dang",
                Address = "22 Jump Street",
                City = "Nashville",
                Email = "something@sexy.com",
                PhoneNumber = "555-777-9311"
            };
        }

        private static List<IProductModel> AddProducts()
        {
            List<IProductModel> output = new List<IProductModel>();

            output.Add(new Products { Name = "Portable Monitor" });
            output.Add(new Products { Name = "PlayStation 4 Controller" });
            output.Add(new Products { Name = "External SSD" });
            output.Add(new DigitalProduct { Name = "Mastering C# in Visual Studio" });

            return output;
        }
    }
}

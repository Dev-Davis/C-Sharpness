using InterfaceExample.Model;
using Interfaces.Models;
using System;
using System.Collections.Generic;

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

                if (prod is IDigitalProductModel digital)
                {
                    Console.WriteLine($"For the { digital.Name } you have {digital.TotalDownloadsLeft } downloads left.");
                }
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
            //output.Add(new CourseProductModel { Name = "Mastering Life" });

            return output;
        }
    }
}

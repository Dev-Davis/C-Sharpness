using InterfaceExample.Model;
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
            List<Products> cart = AddProducts();
            Customer customer = GetCustomer();

            foreach (Products prod in cart)
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
                Address = "4501 Packard Drive",
                City = "Nashville",
                Email = "something@sexy.com",
                PhoneNumber = "555-555-5555"
            };
        }

        private static List<Products> AddProducts()
        {
            List<Products> output = new List<Products>();

            output.Add(new Products { Name = "Portable Monitor" });
            output.Add(new Products { Name = "PlayStation 4 Controller" });
            output.Add(new Products { Name = "External SSD" });

            return output;
        }
    }
}

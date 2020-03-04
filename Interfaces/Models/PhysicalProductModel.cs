using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.Model
{
    class Products : IProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool HasOrderBeenShipped { get; private set; }

        public void ShipItem(Customer customer)
        {
            if (HasOrderBeenShipped == false)
            {
                Console.WriteLine($"Your { Name } has been shipped to { customer.Address } in { customer.City }. ");
                HasOrderBeenShipped = true;
            }
        }
    }
}

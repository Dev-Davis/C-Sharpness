using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.Model
{
    public class DigitalProduct : IProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool HasOrderBeenShipped { get; private set; }

        public int TotalDownloadsLeft { get; private set; } = 5;

        public void ShipItem(Customer customer)
        {
            if (HasOrderBeenShipped == false)
            {
                Console.WriteLine($"Your { Name } has been emailed to { customer.Email }. ");
                TotalDownloadsLeft -= 1;
                if (TotalDownloadsLeft < 1)
                {
                    HasOrderBeenShipped = true;
                    TotalDownloadsLeft = 0;
                }
            }   
        }
    }
}

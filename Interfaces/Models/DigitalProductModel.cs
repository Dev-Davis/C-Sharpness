using Interfaces.Models;
using System;

namespace InterfaceExample.Model
{
    public class DigitalProduct : IProductModel, IDigitalProductModel

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

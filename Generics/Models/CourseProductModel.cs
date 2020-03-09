using InterfaceExample.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Models
{
    public class CourseProductModel : IProductModel
    {
        public int Id { get ; set; }
        public string Name { get; set; }

        public bool HasOrderBeenCompleted { get; private set; }

        public void ShipItem(Customer customer)
        {
            if (!HasOrderBeenCompleted)
            {
                Console.WriteLine($"Added the { Name } course to { customer.FirstName }'s account." );
                HasOrderBeenCompleted = true;
            }
        }
    }
}

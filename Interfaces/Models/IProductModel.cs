using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.Model
{
    public interface IProductModel
    {
        int Id { get; set; }
        string Name { get; set; }
        bool HasOrderBeenCompleted { get; }

        void ShipItem(Customer customer);
    }
}

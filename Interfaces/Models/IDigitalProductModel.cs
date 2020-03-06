using InterfaceExample.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Models
{
    public interface IDigitalProductModel : IProductModel
    {
        int TotalDownloadsLeft { get; }
    }
}

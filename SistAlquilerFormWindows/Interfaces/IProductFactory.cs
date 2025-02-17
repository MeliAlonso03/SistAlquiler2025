using SistAlquilerFormWindows.Interfaces;
using SistAlquilerFormWindows.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistAlquilerFormWindows.Factory
{
    internal interface IProductFactory
    {
        RentableProduct CreateRent(string name, DateTime start, DateTime end, decimal price, IRentableObject rentableObject);
    }
}

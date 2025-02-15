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
        RentableProduct CreateRent<T>(string name, DateTime startDateTime, DateTime endDateTime, decimal precio, T additionalObject);
    }
}

using SistAlquilerFormWindows.Models.Interfaces;
using SistAlquilerFormWindows.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistAlquilerFormWindows.Factory
{
    internal class CarFactory : IProductFactory
    {

        public RentableProduct CreateRent<T>(string name, DateTime startDateTime, DateTime endDateTime, decimal precio, T additionalObject)
        {
            if (additionalObject is Car car)
            {
                return new RentCar(name, startDateTime, endDateTime, precio, car);
            }
            throw new ArgumentException("El objeto adicional no es un Car válida.");
        }

    }
}

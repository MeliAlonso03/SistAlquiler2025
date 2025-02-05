using SistAlquilerFormWindows.Models.Interfaces;
using SistAlquilerFormWindows.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistAlquilerFormWindows.Factory
{
    internal class WashingMachineFactory : IProductFactory
    {

        public IRentableProduct CreateProduct<T>(string name, DateTime startDateTime, DateTime endDateTime, decimal precio, T additionalObject, IPriceStrategy priceStrategy)
        {
            if (additionalObject is WashingMachine washing)
            {
                return new RentWashingMachine(name, startDateTime, endDateTime, precio, washing, priceStrategy);
            }
            throw new ArgumentException("El objeto adicional no es un Wahing Machine válida.");
        }
    }
}

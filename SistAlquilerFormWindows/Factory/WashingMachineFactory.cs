﻿using SistAlquilerFormWindows.Models.Interfaces;
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

        public IRentableProduct CreateProduct<T>(string name, DateTime startDateTime, DateTime endDateTime, T additionalObject)
        {
            if (additionalObject is WashingMachine washing)
            {
                return new RentWashingMachine(name, startDateTime, endDateTime, washing);
            }
            throw new ArgumentException("El objeto adicional no es un Wahing Machine válida.");
        }
    }
}

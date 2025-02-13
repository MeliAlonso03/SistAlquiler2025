﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistAlquilerFormWindows.Models.Interfaces
{
    public interface IRentableProduct
    {
        string Name { get; }
        DateTime DateTimeStart { get; }
        DateTime EndDateTime { get; }
        decimal PrecioxHora { get; }
        decimal Precio {  get; }
        IPriceStrategy PriceStrategy { get; }
        decimal CalcularPrecioAlquiler();
        void Rent();
        string GetDetails();
    }
}

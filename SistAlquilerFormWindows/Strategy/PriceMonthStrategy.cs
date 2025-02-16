using SistAlquilerFormWindows.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SistAlquilerFormWindows.Models.PriceStrategy
{
    internal class PriceMonthStrategy : IPriceStrategy
    {
        private readonly decimal _precioPorHora;

        public PriceMonthStrategy(decimal precioPorHora)
        {
            _precioPorHora = precioPorHora;
        }
        public decimal CalcularPrecio(int horas)
        {
            decimal precioTotal = _precioPorHora * horas;
            precioTotal -= precioTotal * 0.10m;
            return precioTotal;
        }
    }
}

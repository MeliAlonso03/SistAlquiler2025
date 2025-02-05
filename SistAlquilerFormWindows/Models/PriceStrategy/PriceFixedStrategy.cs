using SistAlquilerFormWindows.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistAlquilerFormWindows.Models.PriceStrategy
{
    internal class PriceFixedStrategy : IPriceStrategy
    {
        private readonly decimal _precioPorHora;

        public PriceFixedStrategy(decimal precioPorHora)
        {
            _precioPorHora = precioPorHora;
        }
        public decimal CalcularPrecio(int horas)
        {
            return _precioPorHora * horas;
        }
    }
}

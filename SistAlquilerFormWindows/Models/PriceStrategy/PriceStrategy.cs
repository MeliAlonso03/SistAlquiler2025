using SistAlquilerFormWindows.Models.Interfaces;
using SistAlquilerFormWindows.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistAlquilerFormWindows.Models.PriceStrategy
{
    public class PriceStrategySelector
    {
        public IPriceStrategy estrategiaPrecio(DateTime _dateTimeStart, DateTime _dateTimeFinish, decimal precioXHora)
        {
            int duracionHoras = AlquilerDuracionCalculator.CalcularHorasAlquiler(_dateTimeStart, _dateTimeFinish);
            IPriceStrategy priceStrategy = null;

            switch (duracionHoras)
            {
                case int horas when horas > 24:
                    priceStrategy = new PriceMonthStrategy(precioXHora);
                    break;
                case int horas when horas < 24:
                    priceStrategy = new PriceFixedStrategy(precioXHora);
                    break;
                case 24:
                    priceStrategy = new PriceFixedStrategy(precioXHora);
                    break;
            }

            return priceStrategy;
        }
    }
}

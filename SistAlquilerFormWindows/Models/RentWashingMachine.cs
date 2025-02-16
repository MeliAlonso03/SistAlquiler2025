using SistAlquilerFormWindows.Models.Interfaces;
using SistAlquilerFormWindows.Models.PriceStrategy;
using SistAlquilerFormWindows.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistAlquilerFormWindows.Models
{
    public class RentWashingMachine : RentableProduct
    {
        public WashingMachine Washing { get; private set; }

        public RentWashingMachine(string name, DateTime dateTimeStart, DateTime endDateTime, decimal precioXHora, WashingMachine washing)
            : base(name, dateTimeStart, endDateTime, precioXHora) // Llama al constructor de la clase base
        {
            Washing = washing;
        }

        public override void Rent()
        {
            if (!Washing.IsAvailable(DateTimeStart, EndDateTime))
                throw new InvalidOperationException("El auto no está disponible en las fechas seleccionadas.");

            Washing.Rent(DateTimeStart, EndDateTime);

        }

        public override string GetDetails()
        {
            return "Producto: {Name}, Marca: {Washing.Brand}, Precio Total: {CalcularPrecioAlquiler()}";
        }

        public override decimal CalcularPrecioAlquiler()
        {
            _PriceStrategy = _PriceStrategySelector.estrategiaPrecio(DateTimeStart, EndDateTime, PrecioxHora);
            int horas = AlquilerDuracionCalculator.CalcularHorasAlquiler(DateTimeStart, EndDateTime);
            Precio = _PriceStrategy.CalcularPrecio(horas);
            return Precio;
        }

        public override string ToString()
        {
            return $"Lavarropa{Washing}";
        }
    }

}


using SistAlquilerFormWindows.Models.Interfaces;
using SistAlquilerFormWindows.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SistAlquilerFormWindows.Models
{
    internal class RentWashingMachine : RentableProduct
    {
        public WashingMachine Washing { get; private set; }

        public RentWashingMachine(string name, DateTime dateTimeStart, DateTime endDateTime, decimal precioXHora, WashingMachine washing, IPriceStrategy priceStrategy)
            : base(name, dateTimeStart, endDateTime, precioXHora, priceStrategy) // Llama al constructor de la clase base
        {
            Washing = washing;
        }

        public override void Rent()
        {
            if (!Washing.Available)
                throw new InvalidOperationException("Washing machine is not available.");
            Washing.Available = false;
        }

        public override string GetDetails()
        {
            return $"[ID {Id}] Producto: {Name}, Marca: {Washing.Brand}, Precio Total: {CalcularPrecioAlquiler()}";
        }

        public override decimal CalcularPrecioAlquiler()
        {
            int horas = AlquilerDuracionCalculator.CalcularHorasAlquiler(DateTimeStart, EndDateTime);
            Precio = PriceStrategy.CalcularPrecio(horas);
            return Precio;
        }

        public override string ToString()
        {
            return $"[ID {Id}] {Washing}";
        }
    }

}


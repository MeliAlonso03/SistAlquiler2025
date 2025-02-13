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
    internal class RentWashingMachine : IRentableProduct
    {
        public string Name { get; private set; }
        public WashingMachine Washing {  get; private set; }

        public DateTime DateTimeStart { get; private set; }

        public DateTime EndDateTime { get; private set; }
        public decimal PrecioxHora { get; set; }

        public IPriceStrategy PriceStrategy { get; set; }
        public decimal Precio { get; set; }
        public RentWashingMachine(string name, DateTime dateTimeStart, DateTime endDateTime, decimal precioXHora, WashingMachine washing, IPriceStrategy priceStrategy)
        {
            Name = name;
            DateTimeStart = dateTimeStart;
            EndDateTime = endDateTime;
            PrecioxHora = precioXHora;
            Washing = washing;
            PriceStrategy = priceStrategy;
        }
        public void Rent()
        {
            if (!Washing.Available)
                throw new InvalidOperationException("Washing machine is not available");
            Washing.Available = false;
        }

        public string GetDetails()
        {
            return $"Usuario: {Name}, Brand: {Washing.Brand}, Daily Rate: {CalcularPrecioAlquiler()}";
        }

        public decimal CalcularPrecioAlquiler()
        {
            int horas = AlquilerDuracionCalculator.CalcularHorasAlquiler(DateTimeStart, EndDateTime);
            Precio = PriceStrategy.CalcularPrecio(horas);
            return Precio;
        }

    }
}

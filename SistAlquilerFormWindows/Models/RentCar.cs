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
    internal class RentCar : IRentableProduct
    {
        public string Name { get; private set; }
        public Car car { get; private set; }

        public DateTime DateTimeStart { get; private set; }

        public DateTime EndDateTime { get; private set; }

        public decimal PrecioxHora { get; set; }

        public IPriceStrategy PriceStrategy { get; set; }
        public decimal Precio { get; set; }
        public RentCar(string name, DateTime dateTimeStart, DateTime endDateTime, decimal precioXHora, Car car, IPriceStrategy priceStrategy)
        {
            Name = name;
            DateTimeStart = dateTimeStart;
            this.car = car ?? throw new ArgumentNullException(nameof(car), "Car no puede ser null");
            EndDateTime = endDateTime;
            PrecioxHora = precioXHora;
            PriceStrategy = priceStrategy ?? throw new ArgumentNullException(nameof(priceStrategy), "PriceStrategy no puede ser null");
        }
        public void Rent()
        {
            if (!car.Available)
                throw new InvalidOperationException("Car is not available");
        }

        public string GetDetails()
        {
            return $"Usuario: {Name}, License Plate: {car.LicensePlate}, Daily Rate: ${CalcularPrecioAlquiler()}";
        }

        public decimal CalcularPrecioAlquiler()
        {
            int horas = AlquilerDuracionCalculator.CalcularHorasAlquiler(DateTimeStart, EndDateTime);
            Precio = PriceStrategy.CalcularPrecio(horas);
            return Precio;
        }
        public override string ToString()
        {
            return car.ToString();
        }
    }
}

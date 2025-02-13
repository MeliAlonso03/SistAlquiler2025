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
    internal class RentCar : RentableProduct
    {
        public Car Car { get; private set; }

        public RentCar(string name, DateTime dateTimeStart, DateTime endDateTime, decimal precioXHora, Car car, IPriceStrategy priceStrategy)
            : base(name, dateTimeStart, endDateTime, precioXHora, priceStrategy) // Llamamos al constructor de la clase base
        {
            Car = car ?? throw new ArgumentNullException(nameof(car), "Car no puede ser null");
        }

        public override void Rent()
        {
            if (!Car.Available)
                throw new InvalidOperationException("El auto no está disponible.");
            Car.Available = false;
        }

        public override string GetDetails()
        {
            return $"[ID {Id}] Usuario: {Name}, Auto: {Car.LicensePlate}, Precio Total: ${CalcularPrecioAlquiler()}";
        }

        public override decimal CalcularPrecioAlquiler()
        {
            int horas = AlquilerDuracionCalculator.CalcularHorasAlquiler(DateTimeStart, EndDateTime);
            Precio = PriceStrategy.CalcularPrecio(horas);
            return Precio;
        }

        public override string ToString()
        {
            return $"[ID {Id}] {Car}";
        }
    }
}

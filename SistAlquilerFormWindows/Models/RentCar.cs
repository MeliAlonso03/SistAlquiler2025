using SistAlquilerFormWindows.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistAlquilerFormWindows.Models
{
    internal class RentCar : IRentableProduct
    {
        public string Name { get; private set; }
        public Car car { get; private set; }
        public bool IsAvailable { get; private set; } = true;

        public DateTime DateTimeStart { get; private set; }

        public DateTime EndDateTime { get; private set; }

        public RentCar(string name, DateTime dateTimeStart, DateTime endDateTime, Car car)
        {
            Name = name;
            DateTimeStart = dateTimeStart;
            this.car = car;
            EndDateTime = endDateTime;
        }
        public void Rent()
        {
            if (!car.Available)
                throw new InvalidOperationException("Car is not available");
        }

        public void Return()
        {
            IsAvailable = true;
        }

        public string GetDetails()
        {
            return $"Usuario: {Name}, License Plate: {car.LicensePlate}, Daily Rate: ${DateTimeStart}";
        }
    }
}

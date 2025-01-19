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

        public RentCar(string name, DateTime dateTimeStart, Car car)
        {
            Name = name;
            DateTimeStart = dateTimeStart;
            this.car = car;
        }
        public void Rent()
        {
            if (!IsAvailable)
                throw new InvalidOperationException("Car is not available");
            IsAvailable = false;
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

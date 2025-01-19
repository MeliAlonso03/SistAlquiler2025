using SistAlquilerFormWindows.Models.Interfaces;
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
        public bool IsAvailable { get; private set; } = true;
        public WashingMachine Washing {  get; private set; }

        public DateTime DateTimeStart { get; private set; }

        public DateTime EndDateTime { get; private set; }

        public RentWashingMachine(string name, DateTime dateTimeStart, WashingMachine washing)
        {
            Name = name;
            DateTimeStart = dateTimeStart;
            Washing = washing;
        }
        public void Rent()
        {
            if (!IsAvailable)
                throw new InvalidOperationException("Washing machine is not available");
            IsAvailable = false;
        }

        public void Return()
        {
            IsAvailable = true;
        }

        public string GetDetails()
        {
            return $"Usuario: {Name}, Brand: {Washing.Brand}, Model: {Washing.Model}, ID: {Washing.UniqueId}, Daily Rate: {DateTimeStart}";
        }
    }
}

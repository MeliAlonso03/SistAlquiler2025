using SistAlquilerFormWindows.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SistAlquilerFormWindows.Models
{
    public class Car 
    {
        private static int _nextId = 1;
        public int Id { get; }
        public string LicensePlate { get; private set; }
        public string Model { get; private set; }
        public bool Available { get; set; } = true;
        public List<(DateTime Start, DateTime End)> RentalPeriods { get; private set; } = new List<(DateTime, DateTime)>();

        public Car(string model, string licensePlate)
        {
            Id = _nextId++;
            LicensePlate = licensePlate;
            Model = model;
        }

        // Método para verificar disponibilidad en un rango de fechas
        public bool IsAvailable(DateTime start, DateTime end)
        {
            if (!RentalPeriods.Any()) // Si no hay rentas, está disponible
                return true;

            return !RentalPeriods.Any(r => (start < r.End) && (end > r.Start));
        }

        // Método para marcar como alquilado
        public void Rent(DateTime start, DateTime end)
        {
            if (!IsAvailable(start, end))
                throw new InvalidOperationException("El auto no está disponible en las fechas seleccionadas.");

            RentalPeriods.Add((start, end));
            Available = false;
        }
        public void CancelRent(DateTime start, DateTime end)
        {
            RentalPeriods.RemoveAll(r => r.Start == start && r.End == end);

            // Si no hay más períodos de renta, marcar el auto como disponible
            if (!RentalPeriods.Any())
            {
                Available = true;
            }
        }
        public virtual void ActualizarDatos(string newLicense, string newModel)
        {
            LicensePlate = newLicense;
            Model = newModel;
        }

        public override string ToString()
        {
            return  LicensePlate +" "+ Model;
        }
    }
}

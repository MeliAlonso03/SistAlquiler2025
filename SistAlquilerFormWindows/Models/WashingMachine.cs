using SistAlquilerFormWindows.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistAlquilerFormWindows.Models
{
    public class WashingMachine
    {
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public string UniqueId { get; private set; }
        public bool Available { get; set; } = true;
        public List<(DateTime Start, DateTime End)> RentalPeriods { get; private set; } = new List<(DateTime, DateTime)>();

        public WashingMachine( string brand, string model, string uniqueId)
        {
            Brand = brand;
            Model = model;
            UniqueId = uniqueId;
        }
        // Método para verificar disponibilidad en un rango de fechas
        public bool IsAvailable(DateTime start, DateTime end)
        {
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
        public override string ToString()
        {
            return Brand+ "Model: " +Model+ "UniqueId: " +UniqueId;
        }


    }
}

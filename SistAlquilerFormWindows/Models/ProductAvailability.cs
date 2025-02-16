using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistAlquilerFormWindows.Models
{
    public abstract class ProductAvailability
    {
        public bool Available { get; set; } = true;
        public List<(DateTime Start, DateTime End)> RentalPeriods { get; private set; } = new List<(DateTime, DateTime)>();
        public bool IsAvailable(DateTime start, DateTime end)
        {
            if (!RentalPeriods.Any()) // Si no hay rentas, está disponible
                return true;

            return !RentalPeriods.Any(r => (start < r.End) && (end > r.Start));
        }

        // Método para marcar como alquilado
        public virtual void Rent(DateTime start, DateTime end)
        {
            if (!IsAvailable(start, end))
                throw new InvalidOperationException("El auto no está disponible en las fechas seleccionadas.");

            RentalPeriods.Add((start, end));
            Available = false;
        }
        public virtual void CancelRent(DateTime start, DateTime end)
        {
            RentalPeriods.RemoveAll(r => r.Start == start && r.End == end);

            // Si no hay más períodos de renta, marcar el objeto como disponible
            if (!RentalPeriods.Any())
            {
                Available = true;
            }
        }
    }
}

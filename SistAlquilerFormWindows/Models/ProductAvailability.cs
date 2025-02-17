using SistAlquilerFormWindows.Interfaces;
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
            Console.WriteLine($"Verificando disponibilidad para {start} - {end}");
            foreach (var period in RentalPeriods)
            {
                Console.WriteLine($"Rango ocupado: {period.Start} - {period.End}");
                if (start < period.End && end > period.Start)
                {
                    Console.WriteLine("Conflicto detectado. No disponible.");
                    return false;
                }
            }
            Console.WriteLine("Disponible.");
            return true;
        }

        public virtual bool Rent(DateTime start, DateTime end)
        {
            if (!IsAvailable(start, end))
            {
                throw new InvalidOperationException($"El objeto no está disponible desde {start} hasta {end}.");
            }

            RentalPeriods.Add((start, end));
            Available = false;
            Console.WriteLine($"Alquiler registrado: {start} - {end}");
            return true;
        }

        public virtual void CancelRent(DateTime start, DateTime end)
        {
            RentalPeriods.RemoveAll(r => r.Start == start && r.End == end);
            if (!RentalPeriods.Any())
            {
                Available = true;
            }
            Console.WriteLine($"Alquiler cancelado: {start} - {end}");
        }
        public virtual void UpdateRental(DateTime newStart, DateTime newEnd, decimal newPrice, IRentableObject newProduct)
        {
            Console.WriteLine($"Intentando actualizar la renta con un nuevo producto...");
            CancelRent(newStart, newEnd);

            if (!newProduct.IsAvailable(newStart, newEnd))
            {
                throw new InvalidOperationException($"El nuevo producto no está disponible en las fechas seleccionadas: {newStart} - {newEnd}.");
            }

            newProduct.Rent(newStart, newEnd);
            Console.WriteLine($"Renta actualizada a {newStart} - {newEnd} con nuevo producto.");
        }
    }
}

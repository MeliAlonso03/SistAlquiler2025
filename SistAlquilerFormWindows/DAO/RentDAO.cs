using SistAlquilerFormWindows.Models;
using SistAlquilerFormWindows.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistAlquilerFormWindows.DAO
{
    public class RentDAO
    {
        public List<RentableProduct> rents = new List<RentableProduct>();
        private readonly Dictionary<int, RentableProduct> _rentas = new Dictionary<int, RentableProduct>();

        public void GuardarRenta(RentableProduct renta)
        {
            rents.Add(renta);
        }

        public RentableProduct ObtenerRentaPorId(int rentId)
        {
            return rents.FirstOrDefault(r => r.Id == rentId);
        }

        public void ActualizarRenta(RentableProduct renta)
        {
            var rentaExistente = ObtenerRentaPorId(renta.Id);
            if (rentaExistente != null)
            {
                rentaExistente.ActualizarDatos(renta.DateTimeStart, renta.EndDateTime, renta.PrecioxHora, renta.Name);
            }
        }

        public void EliminarRenta(int rentId)
        {
            var renta = ObtenerRentaPorId(rentId);
            if (renta != null)
            {
                rents.Remove(renta);
            }
        }
        public RentableProduct ObtenerRenta(int rentId)
        {
            return _rentas.ContainsKey(rentId) ? _rentas[rentId] : null;
        }

        public void ActualizarRenta(int rentId, RentableProduct nuevaRenta)
        {
            if (!_rentas.ContainsKey(rentId))
            {
                throw new InvalidOperationException("No se puede actualizar. La renta no existe.");
            }

            _rentas[rentId] = nuevaRenta;
            Console.WriteLine($"Renta {rentId} actualizada con nuevo producto y fechas.");
        }
    }
}

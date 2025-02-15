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
        private List<RentableProduct> rentas = new List<RentableProduct>();

        public void GuardarRenta(RentableProduct renta)
        {
            rentas.Add(renta);
        }

        public RentableProduct ObtenerRentaPorId(int rentId)
        {
            return rentas.FirstOrDefault(r => r.Id == rentId);
        }

        public void ActualizarRenta(RentableProduct renta)
        {
            var rentaExistente = ObtenerRentaPorId(renta.Id);
            if (rentaExistente != null)
            {
                rentaExistente.ActualizarDatos(renta.DateTimeStart, renta.EndDateTime, renta.PrecioxHora);
            }
        }

        public void EliminarRenta(int rentId)
        {
            var renta = ObtenerRentaPorId(rentId);
            if (renta != null)
            {
                rentas.Remove(renta);
            }
        }
    }
}

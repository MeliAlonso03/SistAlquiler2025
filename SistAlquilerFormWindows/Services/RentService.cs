using SistAlquilerFormWindows.DAO;
using SistAlquilerFormWindows.Models;
using SistAlquilerFormWindows.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistAlquilerFormWindows.Services
{
    public class RentService
    {
        public RentDAO _RentDAO;
        public RentService()
        {
            _RentDAO = new RentDAO();
        }
        public void AddRent(RentableProduct product)
        {
            _RentDAO.rents.Add(product);
        }

        internal List<RentableProduct> GetAllRent()
        {
            return _RentDAO.rents;
        }
        public void ActualizarRenta(int rentId, DateTime newStart, DateTime newFinish, decimal newPrice)
        {
            var renta = _RentDAO.ObtenerRentaPorId(rentId);
            if (renta == null) throw new InvalidOperationException("Renta no encontrada.");

            renta.ActualizarDatos(newStart, newFinish, newPrice);
            _RentDAO.ActualizarRenta(renta);
        }

        public void EliminarRenta(int rentId)
        {
            _RentDAO.EliminarRenta(rentId);
        }
    }
}

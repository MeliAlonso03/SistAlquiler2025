using SistAlquilerFormWindows.Controllers;
using SistAlquilerFormWindows.DAO;
using SistAlquilerFormWindows.Factory;
using SistAlquilerFormWindows.Interfaces;
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
        private readonly RentDAO _rentDAO;
        private readonly GenericProductFactory _factory;

        public RentService(GenericProductFactory factory)
        {
            _rentDAO = new RentDAO();
            _factory = factory;
        }

        public RentableProduct AddRent(string name, DateTime start, DateTime end, decimal price, IRentableObject rentableObject)
        {
            var rent = _factory.CreateRent(name, start, end, price, rentableObject);
            _rentDAO.GuardarRenta(rent);
            return rent;
        }

        public List<RentableProduct> GetAllRentals() => _rentDAO.rents.ToList();

        public void UpdateRent(int rentId, DateTime newStart, DateTime newFinish, decimal newPrice, string newName)
        {
            var rent = _rentDAO.ObtenerRentaPorId(rentId) ?? throw new InvalidOperationException("Renta no encontrada.");
            rent.ActualizarDatos(newStart, newFinish, newPrice, newName);
            _rentDAO.ActualizarRenta(rent);
        }

        public void DeleteRent(int rentId)
        {
            var rent = _rentDAO.ObtenerRentaPorId(rentId) ?? throw new InvalidOperationException("Renta no encontrada.");
            rent.CancelRent(rent.DateTimeStart, rent.EndDateTime);
            _rentDAO.EliminarRenta(rentId);
        }

        internal RentableProduct GetById(int rentId)
        {
            return _rentDAO.ObtenerRentaPorId(rentId) ?? throw new InvalidOperationException("Renta no encontrada.");
        }
    }
}

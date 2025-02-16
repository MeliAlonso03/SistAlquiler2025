using SistAlquilerFormWindows.Controllers;
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
        public ManagmentFactory _factory = new ManagmentFactory();
        public RentService()
        {
            _RentDAO = new RentDAO();
        }
        public RentableProduct AddRent(RentableProduct product)
        {
            _RentDAO.GuardarRenta(product);
            return product;
        }


        internal List<RentableProduct> GetAllRent()
        {
            return _RentDAO.rents.ToList();
        }
        public void ActualizarRenta(int rentId, DateTime newStart, DateTime newFinish, decimal newPrice, string newName)
        {
            var renta = _RentDAO.ObtenerRentaPorId(rentId);
            if (renta == null) throw new InvalidOperationException("Renta no encontrada.");

            renta.ActualizarDatos(newStart, newFinish, newPrice, newName);
            _RentDAO.ActualizarRenta(renta);
        }

        public void EliminarRenta(int rentId)
        {
            var renta = _RentDAO.ObtenerRentaPorId(rentId);
            if (renta == null) throw new InvalidOperationException("Renta no encontrada.");

            switch (renta)
            {
                case RentCar _rentCar:
                    _rentCar.Car.CancelRent(renta.DateTimeStart, renta.EndDateTime);
                    break;
                case RentWashingMachine _rentWashingMachine:
                    _rentWashingMachine.Washing.CancelRent(renta.DateTimeStart, renta.EndDateTime);
                    break;

            }

            _RentDAO.EliminarRenta(rentId);
        }

        internal RentableProduct BuscarRenta(int rentID)
        {
            RentableProduct renta = _RentDAO.ObtenerRentaPorId(rentID);
            return renta;
        }
    }
}

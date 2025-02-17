using SistAlquilerFormWindows.Factory;
using SistAlquilerFormWindows.Interfaces;
using SistAlquilerFormWindows.Models;
using SistAlquilerFormWindows.Models.Interfaces;
using SistAlquilerFormWindows.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistAlquilerFormWindows.Controllers
{
    public class RentController
    {
        private readonly RentService _rentService;
        public RentController(GenericProductFactory factory)
        {
            _rentService = new RentService(factory);
        }

        public RentableProduct AddRent(string name, DateTime start, DateTime end, decimal price, IRentableObject rentableObject)
            => _rentService.AddRent(name, start, end, price, rentableObject);

        public List<RentableProduct> GetAllRents() => _rentService.GetAllRentals();
        public RentableProduct GetRentById(int rentId) => _rentService.GetById(rentId);
        public void ModifyRent(int rentId, DateTime newStart, DateTime newEnd, decimal newPrice, string newName)
        {
            try
            {
                _rentService.UpdateRent(rentId, newStart, newEnd, newPrice, newName);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error al modificar renta: {ex.Message}");
                throw;
            }
        }
        public void ModifyRentWithProduct(int rentId, DateTime newStart, DateTime newEnd, decimal newPrice, IRentableObject newProduct)
        {
            try
            {
                _rentService.UpdateRentWithProduct(rentId, newStart, newEnd, newPrice, newProduct);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error al modificar renta: {ex.Message}");
                throw;
            }
        }
        public void DeleteRent(int rentId) => _rentService.DeleteRent(rentId);
    }
}

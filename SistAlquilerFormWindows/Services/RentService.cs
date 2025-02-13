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
    }
}

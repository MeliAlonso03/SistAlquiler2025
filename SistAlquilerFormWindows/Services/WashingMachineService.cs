using SistAlquilerFormWindows.DAO;
using SistAlquilerFormWindows.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistAlquilerFormWindows.Services
{
    internal class WashingMachineService
    {
        public WashingMachineDAO _washingDAO;
        public WashingMachineService() 
        {
            _washingDAO = new WashingMachineDAO();
        }
        public void AddWashingMachin(string brand, string model, string uniqueId)
        {
            WashingMachine newWashing = new WashingMachine(brand, model, uniqueId);
            _washingDAO.washingMachines.Add(newWashing);
        }

        internal List<WashingMachine> GetAllWashingMachine()
        {
            return _washingDAO.washingMachines;
        }
    }
}

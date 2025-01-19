using SistAlquilerFormWindows.Models;
using SistAlquilerFormWindows.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistAlquilerFormWindows.Controllers
{
    internal class WashingMachineController
    {
        private static WashingMachineController _instance;
        private static readonly object _lock = new object();
        private readonly WashingMachineService washingService;
        public WashingMachineController()
        {
            washingService = new WashingMachineService();
        }
        public static WashingMachineController Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock) // Asegura que solo se inicialice una vez
                    {
                        if (_instance == null)
                        {
                            _instance = new WashingMachineController();
                        }
                    }
                }
                return _instance;
            }
        }
        public void AddWashingMachine(string brand, string model, string uniqueId)
        {
            washingService.AddWashingMachin(brand, model, uniqueId);
        }

        public List<WashingMachine> GetAllCars()
        {
            return washingService.GetAllWashingMachine();
        }
    }
}

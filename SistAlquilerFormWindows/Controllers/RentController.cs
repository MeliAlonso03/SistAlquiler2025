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
        // Instancia única
        private static RentController _instance;

        // Lock para seguridad en entornos multihilo
        private static readonly object _lock = new object();

        // Servicio utilizado por el controlador
        private readonly RentService rentService;

        // Constructor privado para evitar instanciación externa
        private RentController()
        {
            rentService = new RentService();
        }

        // Propiedad para acceder a la instancia única
        public static RentController Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock) // Asegura que solo se inicialice una vez
                    {
                        if (_instance == null)
                        {
                            _instance = new RentController();
                        }
                    }
                }
                return _instance;
            }
        }
        public void AddRent(IRentableProduct product)
        {
            rentService.AddRent(product);
        }

        public List<IRentableProduct> GetAllCars()
        {
            return rentService.GetAllRent();
        }
    }
}

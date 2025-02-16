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
        public RentableProduct AddRent(RentableProduct renta)
        {
            return rentService.AddRent(renta);
        }

        public List<RentableProduct> GetAllCars()
        {
            return rentService.GetAllRent();
        }
        public void ModificarRenta(int rentId, DateTime newStart, DateTime newFinish, decimal newPrice, string newName)
        {
            rentService.ActualizarRenta(rentId, newStart, newFinish, newPrice, newName);
        }

        public void BorrarRenta(int rentId)
        {
            rentService.EliminarRenta(rentId);
        }

        internal RentableProduct BuscarRenta(int rentID)
        {
            return rentService.BuscarRenta(rentID);
        }
    }
}

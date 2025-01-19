using SistAlquilerFormWindows.Models;
using SistAlquilerFormWindows.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistAlquilerFormWindows.Controllers
{
    public class CarController
    {
        // Instancia única
        private static CarController _instance;

        // Lock para seguridad en entornos multihilo
        private static readonly object _lock = new object();

        // Servicio utilizado por el controlador
        private readonly CarService carService;

        // Constructor privado para evitar instanciación externa
        private CarController()
        {
            carService = new CarService();
        }

        // Propiedad para acceder a la instancia única
        public static CarController Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock) // Asegura que solo se inicialice una vez
                    {
                        if (_instance == null)
                        {
                            _instance = new CarController();
                        }
                    }
                }
                return _instance;
            }
        }

        // Métodos de la clase
        public void AddCar(string licensePlate, string model)
        {
            carService.AddCar(licensePlate, model);
        }

        public List<Car> GetAllCars()
        {
            return carService.GetAllCars();
        }
    }

}

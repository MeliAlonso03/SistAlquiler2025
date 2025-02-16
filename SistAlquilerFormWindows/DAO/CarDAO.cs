using SistAlquilerFormWindows.Models;
using SistAlquilerFormWindows.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistAlquilerFormWindows.DAO
{
    internal class CarDAO
    {
        public List<Car> cars = new List<Car>();

        public Car ObtenerAutoPorId(int carId)
        {
            return cars.FirstOrDefault(r => r.Id == carId);
        }

        public void ActualizarAuto(Car _car)
        {
            var autoExistente = ObtenerAutoPorId(_car.Id);
            if (autoExistente != null)
            {
                autoExistente.ActualizarDatos(_car.LicensePlate, _car.Model);
            }
        }

        public void EliminarAuto(int autoId)
        {
            var _car = ObtenerAutoPorId(autoId);
            if (_car != null)
            {
                cars.Remove(_car);
            }
        }
    }
}

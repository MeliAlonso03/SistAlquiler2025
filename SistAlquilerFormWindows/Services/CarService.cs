using SistAlquilerFormWindows.DAO;
using SistAlquilerFormWindows.Models;
using SistAlquilerFormWindows.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SistAlquilerFormWindows.Services
{
    internal class CarService
    {
        public CarDAO carsDAO;

        public CarService()
        {
            carsDAO = new CarDAO();
        }

        public void AddCar(string LicensePlate, string model)
        {
            Car newCar = new Car(model, LicensePlate);
            carsDAO.cars.Add(newCar);
        }

        internal List<Car> GetAllCars()
        {
            return carsDAO.cars;
        }
        public void ActualizarAuto(int autoId, string newLicense, string newModel)
        {
            var auto = carsDAO.ObtenerAutoPorId(autoId);
            if (auto == null) return;

            auto.ActualizarDatos(newLicense, newModel);
            carsDAO.ActualizarAuto(auto);
        }

        public void EliminarAuto(int autoId)
        {
            carsDAO.EliminarAuto(autoId);
        }

        internal Car BuscarAuto(int autoID)
        {
            Car auto = carsDAO.ObtenerAutoPorId(autoID); 
            return auto;
        }
    }
}

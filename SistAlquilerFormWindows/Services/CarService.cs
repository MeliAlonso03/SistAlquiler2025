using SistAlquilerFormWindows.DAO;
using SistAlquilerFormWindows.Models;
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
    }
}

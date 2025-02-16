using SistAlquilerFormWindows.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SistAlquilerFormWindows.Models
{
    public class Car : ProductAvailability
    {
        private static int _nextId = 1;
        public int Id { get; }
        public string LicensePlate { get; private set; }
        public string Model { get; private set; }
        public Car(string model, string licensePlate)
        {
            Id = _nextId++;
            LicensePlate = licensePlate;
            Model = model;
        }

        public virtual void ActualizarDatos(string newLicense, string newModel)
        {
            LicensePlate = newLicense;
            Model = newModel;
        }

        public override string ToString()
        {
            return  LicensePlate +" "+ Model;
        }
    }
}

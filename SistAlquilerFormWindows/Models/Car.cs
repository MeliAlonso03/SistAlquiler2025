using SistAlquilerFormWindows.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistAlquilerFormWindows.Models
{
    public class Car 
    {
        public string LicensePlate { get; private set; }
        public string Model { get; private set; }
        public bool Available { get; set; } = true;

        public Car(string model, string licensePlate)
        {
            Model = model;
            LicensePlate = licensePlate;
        }

        public override string ToString()
        {
            return  LicensePlate+ Model;
        }
    }
}

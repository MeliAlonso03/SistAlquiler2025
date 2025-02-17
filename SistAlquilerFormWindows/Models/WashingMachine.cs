using SistAlquilerFormWindows.Interfaces;
using SistAlquilerFormWindows.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistAlquilerFormWindows.Models
{
    public class WashingMachine : ProductAvailability, IRentableObject
    {
        private static int _nextId = 1;
        public int Id { get; }
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public string UniqueId { get; private set; }

        public WashingMachine( string brand, string model, string uniqueId)
        {
            Id = _nextId++;
            Brand = brand;
            Model = model;
            UniqueId = uniqueId;
        }
        
        public virtual void ActualizarDatos(string newBrand, string newModel, string newUniqueId)
        {
            Brand = newBrand;
            Model = newModel;
            UniqueId = newUniqueId;
        }
        public override string ToString()
        {
            return Brand+ "  " +Model+ "  " +UniqueId;
        }


    }
}

using SistAlquilerFormWindows.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistAlquilerFormWindows.Models
{
    internal class WashingMachine
    {
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public string UniqueId { get; private set; }
        public bool Available { get; private set; } = true;

        public WashingMachine( string brand, string model, string uniqueId)
        {
            Brand = brand;
            Model = model;
            UniqueId = uniqueId;
        }
        public override string ToString()
        {
            return "Ava: "+ Available+ "Brand: " +Brand+ "Model: " +Model+ "UniqueId: " +UniqueId;
        }


    }
}

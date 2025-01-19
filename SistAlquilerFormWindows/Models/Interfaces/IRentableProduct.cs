using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistAlquilerFormWindows.Models.Interfaces
{
    internal interface IRentableProduct
    {
        string Name { get; }
        DateTime DateTimeStart { get; }
        DateTime EndDateTime { get; }
        bool IsAvailable { get; }
        void Rent();
        void Return();
        string GetDetails();
    }
}

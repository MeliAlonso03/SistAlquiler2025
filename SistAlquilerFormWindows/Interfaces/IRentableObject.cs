using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistAlquilerFormWindows.Interfaces
{
    public interface IRentableObject
    {
        bool IsAvailable(DateTime start, DateTime end);
        bool Rent(DateTime start, DateTime end);
        void CancelRent(DateTime start, DateTime end);
    }
}

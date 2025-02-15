using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistAlquilerFormWindows.Models.Interfaces
{
    public interface IPriceStrategy
    {
        decimal CalcularPrecio(int horas);
    }
}

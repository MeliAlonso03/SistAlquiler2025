using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistAlquilerFormWindows.Services
{
    public class AlquilerDuracionCalculator
    {
        public static int CalcularHorasAlquiler(DateTime fechaInicio, DateTime fechaFin)
        {
            TimeSpan duracion = fechaFin - fechaInicio;
            int duracionHoras = (int)Math.Ceiling(duracion.TotalHours);
            return duracionHoras;
        }
    }
}

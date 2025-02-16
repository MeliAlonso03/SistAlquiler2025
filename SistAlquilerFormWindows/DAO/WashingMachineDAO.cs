using SistAlquilerFormWindows.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistAlquilerFormWindows.DAO
{
    internal class WashingMachineDAO
    {
        public List<WashingMachine> washingMachines = new List<WashingMachine>();
        public WashingMachine ObtenerLavarropaPorId(int WashId)
        {
            return washingMachines.FirstOrDefault(r => r.Id == WashId);
        }

        public void ActualizarLavarropa(WashingMachine washingMachine)
        {
            var lavarropaExistente = ObtenerLavarropaPorId(washingMachine.Id);
            if (lavarropaExistente != null)
            {
                lavarropaExistente.ActualizarDatos(washingMachine.Brand, washingMachine.Model, washingMachine.UniqueId);
            }
        }

        public void EliminarLavarropa(int washId)
        {
            var _wash = ObtenerLavarropaPorId(washId);
            if (_wash != null)
            {
                washingMachines.Remove(_wash);
            }
        }
    }
}

using SistAlquilerFormWindows.Controllers;
using SistAlquilerFormWindows.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistAlquilerFormWindows
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GenericProductFactory factory = new GenericProductFactory();
            Application.Run(new Inicio(Form1.GetInstance(factory)));

        }
    }
}

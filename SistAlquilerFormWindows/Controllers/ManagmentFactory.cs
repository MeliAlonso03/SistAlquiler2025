using SistAlquilerFormWindows.DAO;
using SistAlquilerFormWindows.Factory;
using SistAlquilerFormWindows.Models;
using SistAlquilerFormWindows.Models.Interfaces;
using SistAlquilerFormWindows.Models.PriceStrategy;
using SistAlquilerFormWindows.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SistAlquilerFormWindows.Controllers
{
    public class ManagmentFactory
    {
        private Dictionary<string, IProductFactory> factories;
        RentableProduct product;

        public ManagmentFactory()
        {
            InitializeFactories();
        }
        private void InitializeFactories()
        {
            factories = new Dictionary<string, IProductFactory>
            {
                { "Car", new CarFactory() },
                { "Washing Machine", new WashingMachineFactory() }
            };
        }


        public RentCar AlquilarAuto(string productType, string name, DateTime dateTimeStart, DateTime dateTimeFinish, decimal precioXHora, Car selectedCar)
        {
            if (!selectedCar.IsAvailable(dateTimeStart, dateTimeFinish))
            {
                MessageBox.Show("El auto ya está alquilado en esas fechas.", "Disponibilidad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            product = factories[productType].CreateRent(name, dateTimeStart, dateTimeFinish, precioXHora, selectedCar);
            product.Rent();
            return (RentCar)product;
        }

        public RentWashingMachine AlquilarWashingMachine(string productType, string name, DateTime dateTimeStart, DateTime dateTimeFinish, decimal precioXHora, WashingMachine selectedWashingMachine)
        {
            if (!selectedWashingMachine.IsAvailable(dateTimeStart, dateTimeFinish))
            {
                MessageBox.Show("El Lavarropa ya está alquilado en esas fechas.", "Disponibilidad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            product = factories[productType].CreateRent(name, dateTimeStart, dateTimeFinish, precioXHora, selectedWashingMachine);
            product.Rent();
            return (RentWashingMachine)product;
        }
    }
}

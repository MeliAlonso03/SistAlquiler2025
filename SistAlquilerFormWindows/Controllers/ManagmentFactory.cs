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
    internal class ManagmentFactory
    {
        private Dictionary<string, IProductFactory> factories;
        private IPriceStrategy priceStrategy;
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


        public IPriceStrategy estrategiaPrecio(DateTime _dateTimeStart, DateTime _dateTimeFinish, decimal precioXHora)
        {
            int duracionHoras = AlquilerDuracionCalculator.CalcularHorasAlquiler(_dateTimeStart, _dateTimeFinish);
            IPriceStrategy priceStrategy = null;

            switch (duracionHoras)
            {
                case int horas when horas > 24:
                    priceStrategy = new PriceMonthStrategy(precioXHora);
                    break;
                case int horas when horas < 24:
                    priceStrategy = new PriceFixedStrategy(precioXHora);
                    break;
                case 24:
                    priceStrategy = new PriceFixedStrategy(precioXHora);  
                    break;
            }

            return priceStrategy;
        }

        public RentCar AlquilarAuto(string productType, string name, DateTime dateTimeStart, DateTime dateTimeFinish, decimal precioXHora, Car selectedCar)
        {
            if (!selectedCar.IsAvailable(dateTimeStart, dateTimeFinish))
            {
                MessageBox.Show("El auto ya está alquilado en esas fechas.", "Disponibilidad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            priceStrategy = estrategiaPrecio(dateTimeStart, dateTimeFinish, precioXHora);
            product = factories[productType].CreateRent(name, dateTimeStart, dateTimeFinish, precioXHora, selectedCar, priceStrategy);
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
            priceStrategy = estrategiaPrecio(dateTimeStart, dateTimeFinish, precioXHora);
            product = factories[productType].CreateRent(name, dateTimeStart, dateTimeFinish, precioXHora, selectedWashingMachine, priceStrategy);
            product.Rent();
            return (RentWashingMachine)product;
        }
    }
}

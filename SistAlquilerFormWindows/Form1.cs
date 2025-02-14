using SistAlquilerFormWindows.Controllers;
using SistAlquilerFormWindows.DAO;
using SistAlquilerFormWindows.Factory;
using SistAlquilerFormWindows.Models;
using SistAlquilerFormWindows.Models.Interfaces;
using SistAlquilerFormWindows.Models.PriceStrategy;
using SistAlquilerFormWindows.Services;
using SistAlquilerFormWindows.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SistAlquilerFormWindows
{
    public partial class Form1 : Form
    {
        private static Form1 instance;

        private Dictionary<string, IProductFactory> factories;
        private RentController rentController = RentController.Instance;
        private WashingMachineController _washingMachineController = WashingMachineController.Instance;
        private CarController _carController = CarController.Instance;
        private ManagmentFactory _managment = new ManagmentFactory();


        private Form1()
        {
            InitializeComponent();
            InitializeFactories();
            InitializeComboBox();
            UpdateCarComboBox();
            UpdateWashingComboBox();
            UpdateProductList();
        }
        public static Form1 GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Form1();
            }
            return instance;
        }
        private void InitializeComboBox()
        {
            cmbProductType.Items.AddRange(new string[] { "Car", "Washing Machine" });
            cmbProductType.SelectedIndex = 0;
        }

        private void InitializeFactories()
        {
            factories = new Dictionary<string, IProductFactory>
            {
                { "Car", new CarFactory() },
                { "Washing Machine", new WashingMachineFactory() }
            };
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(out decimal pricePerHour)) return;

            string productType = cmbProductType.Text;
            string name = txtName.Text;
            DateTime startDate = dateTimeStart.Value;
            DateTime finishDate = dateTimeFinish.Value;

            try
            {
                var product = CreateProduct(productType, name, startDate, finishDate, pricePerHour);

                UpdateUIAfterProductAdded(product);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool ValidateInput(out decimal pricePerHour)
        {
            pricePerHour = 0;

            if (!decimal.TryParse(txtPriceXHora.Text, out pricePerHour) || pricePerHour <= 0)
            {
                MessageBox.Show("Please enter a valid price per hour.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a valid name for the product.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (dateTimeStart.Value >= dateTimeFinish.Value)
            {
                MessageBox.Show("The start date must be earlier than the finish date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void UpdateUIAfterProductAdded(RentableProduct product)
        {
            if (product != null)
            {
                rentController.AddRent(product);
                //products.Add(product);
                UpdateProductList();
                ClearInputs();
            }
        }
        private RentableProduct CreateProduct(string productType, string name, DateTime startDate, DateTime finishDate, decimal pricePerHour)
        {
            switch (productType)
            {
                case "Car":
                    return CreateCarProduct(name, startDate, finishDate, pricePerHour);
                case "Washing Machine":
                    return CreateWashingMachineProduct(name, startDate, finishDate, pricePerHour);
                default:
                    MessageBox.Show("Invalid product type", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
            }
        }

        private RentableProduct CreateCarProduct(string name, DateTime startDate, DateTime finishDate, decimal pricePerHour)
        {
            if (cmbCar.SelectedItem is Car selectedCar)
            {
                var rentedCar = _managment.AlquilarAuto("Car", name, startDate, finishDate, pricePerHour, selectedCar);
                if (rentedCar == null)
                {
                    MessageBox.Show("El auto no está disponible en esas fechas.", "Error de disponibilidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                return rentedCar;
            }
            MessageBox.Show("Por favor seleccione un auto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }

        private RentableProduct CreateWashingMachineProduct(string name, DateTime startDate, DateTime finishDate, decimal pricePerHour)
        {
            if (cmbWashing.SelectedItem is WashingMachine selectedMachine)
            {
                return _managment.AlquilarWashingMachine("Washing Machine", name, startDate, finishDate, pricePerHour, selectedMachine);
            }
            MessageBox.Show("Please select a valid washing machine from the list.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }

        private void UpdateProductList()
        {
            lVRent.Items.Clear();
            List<RentableProduct> rents = rentController.GetAllCars();

            foreach (var rent in rents)
            {
                // Suponiendo que rent tiene una propiedad "Usuario" y "Objeto"
                ListViewItem item = new ListViewItem(rent.Name); // clUsuario
                item.SubItems.Add(rent.ToString()); // clObjeto
                item.SubItems.Add(rent.CalcularPrecioAlquiler().ToString());
                // Agregar el elemento al ListView
                lVRent.Items.Add(item);
            }
        }
        private void ClearInputs()
        {
            txtName.Clear();
            txtPriceXHora.Clear();
        }
        public int GetCarCount()
        {
            return _carController.GetAllCars().Count;
        }

        public int GetWashingMachineCount()
        {
            return _washingMachineController.GetAllCars().Count;
        }

        private void cmbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbProductType.Text)
            {
                case "Car":
                    lblWashing.Visible = cmbWashing.Visible = false;
                    lblCar.Visible = cmbCar.Visible = true;
                    break;

                case "Washing Machine":
                    lblWashing.Visible = cmbWashing.Visible = true;
                    lblCar.Visible = cmbCar.Visible = false;
                    break;

                default:
                    MessageBox.Show("Invalid product type");
                    return;
            }
        }

        public void UpdateCarComboBox()
        {
            cmbCar.Items.Clear();
            cmbCar.Items.AddRange(_carController.GetAllCars().ToArray());

        }
        public void UpdateWashingComboBox()
        {
            cmbWashing.Items.Clear();
            cmbWashing.Items.AddRange(_washingMachineController.GetAllCars().ToArray());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cmbCar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

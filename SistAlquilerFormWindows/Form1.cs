using SistAlquilerFormWindows.Controllers;
using SistAlquilerFormWindows.Factory;
using SistAlquilerFormWindows.Models;
using SistAlquilerFormWindows.Models.Interfaces;
using SistAlquilerFormWindows.Models.PriceStrategy;
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
        private List<IRentableProduct> products;
        private WashingMachineController _washingMachineController = WashingMachineController.Instance;
        private CarController _carController = CarController.Instance;
        private ManagmentFactory _managment = new ManagmentFactory();


        private Form1()
        {
            InitializeComponent();
            InitializeFactories();
            InitializeComboBox();
            products = new List<IRentableProduct>();
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

        private void UpdateUIAfterProductAdded(IRentableProduct product)
        {
            if (product != null)
            {
                products.Add(product);
                UpdateProductList();
                ClearInputs();
            }
        }
        private IRentableProduct CreateProduct(string productType, string name, DateTime startDate, DateTime finishDate, decimal pricePerHour)
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

        private IRentableProduct CreateCarProduct(string name, DateTime startDate, DateTime finishDate, decimal pricePerHour)
        {
            if (cmbCar.SelectedItem is Car selectedCar)
            {
                return _managment.AlquilarAuto("Car", name, startDate, finishDate, pricePerHour, selectedCar);
            }
            MessageBox.Show("Please select a valid car from the list.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }

        private IRentableProduct CreateWashingMachineProduct(string name, DateTime startDate, DateTime finishDate, decimal pricePerHour)
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
            lstProducts.Items.Clear();
            foreach (var product in products)
            {
                string productType = product.GetType().Name; 
                lstProducts.Items.Add($"{productType}: {product.GetDetails()}");
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

    }
}

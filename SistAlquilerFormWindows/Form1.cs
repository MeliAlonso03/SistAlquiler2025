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
            if (!TryGetValidatedInput(out string productType, out string name, out DateTime startDate, out DateTime finishDate, out decimal pricePerHour))
                return;

            try
            {
                var product = CreateProduct(productType, name, startDate, finishDate, pricePerHour);
                UpdateUIAfterProductAdded(product);
            }
            catch (ArgumentException ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private bool TryGetValidatedInput(out string productType, out string name, out DateTime startDate, out DateTime finishDate, out decimal pricePerHour)
        {
            productType = cmbProductType.Text;
            name = txtName.Text;
            startDate = dateTimeStart.Value;
            finishDate = dateTimeFinish.Value;

            if (!ValidateInput(out pricePerHour))
            {
                return false;
            }

            return true;
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message);
        }

        private bool ValidateInput(out decimal pricePerHour)
        {
            pricePerHour = 0;

            if (!ValidatePrice(out pricePerHour) ||
                !ValidateProductName() ||
                !ValidateDates())
            {
                return false;
            }

            return true;
        }

        private bool ValidatePrice(out decimal pricePerHour)
        {
            if (!decimal.TryParse(txtPriceXHora.Text, out pricePerHour) || pricePerHour <= 0)
            {
                ShowErrorMessage("Please enter a valid price per hour.");
                return false;
            }
            return true;
        }

        private bool ValidateProductName()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                ShowErrorMessage("Please enter a valid name for the product.");
                return false;
            }
            return true;
        }

        private bool ValidateDates()
        {
            if (dateTimeStart.Value >= dateTimeFinish.Value)
            {
                ShowErrorMessage("The start date must be earlier than the finish date.");
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
            var product = GenerateProduct(productType, name, startDate, finishDate, pricePerHour);

            if (product == null)
            {
                ShowErrorMessage("Invalid product type");
            }

            return product;
        }

        private RentableProduct GenerateProduct(string productType, string name, DateTime startDate, DateTime finishDate, decimal pricePerHour)
        {
            switch (productType)
            {
                case "Car":
                    return CreateCarProduct(name, startDate, finishDate, pricePerHour);
                case "Washing Machine":
                    return CreateWashingMachineProduct(name, startDate, finishDate, pricePerHour);
                default:
                    return null;
            }
        }


        private RentableProduct CreateCarProduct(string name, DateTime startDate, DateTime finishDate, decimal pricePerHour)
        {
            var selectedCar = GetSelectedCar();
            if (selectedCar == null) return null;

            return RentCar(name, startDate, finishDate, pricePerHour, selectedCar);
        }

        private RentableProduct CreateWashingMachineProduct(string name, DateTime startDate, DateTime finishDate, decimal pricePerHour)
        {
            var selectedMachine = GetSelectedWashingMachine();
            if (selectedMachine == null) return null;

            return RentWashingMachine(name, startDate, finishDate, pricePerHour, selectedMachine);
        }

        // Obtiene el auto seleccionado
        private Car GetSelectedCar()
        {
            if (cmbCar.SelectedItem is Car selectedCar)
            {
                return selectedCar;
            }

            ShowErrorMessage("Por favor seleccione un auto válido.");
            return null;
        }

        // Obtiene la lavadora seleccionada
        private WashingMachine GetSelectedWashingMachine()
        {
            if (cmbWashing.SelectedItem is WashingMachine selectedMachine)
            {
                return selectedMachine;
            }

            ShowErrorMessage("Please select a valid washing machine from the list.");
            return null;
        }
        private RentableProduct RentCar(string name, DateTime startDate, DateTime finishDate, decimal pricePerHour, Car car)
        {
            var rentedCar = _managment.AlquilarAuto("Car", name, startDate, finishDate, pricePerHour, car);

            if (rentedCar == null)
            {
                ShowErrorMessage("El auto no está disponible en esas fechas.");
            }

            return rentedCar;
        }

        private RentableProduct RentWashingMachine(string name, DateTime startDate, DateTime finishDate, decimal pricePerHour, WashingMachine machine)
        {
            var rentedMachine = _managment.AlquilarWashingMachine("Washing Machine", name, startDate, finishDate, pricePerHour, machine);

            if (rentedMachine == null)
            {
                ShowErrorMessage("El Lavarropa no está disponible en esas fechas.");
            }

            return rentedMachine;
        }

        private void UpdateProductList()
        {
            var rents = GetRentableProducts();
            var listViewItems = ConvertToListViewItems(rents);
            RefreshListView(listViewItems);
        }

        private List<RentableProduct> GetRentableProducts()
        {
            return rentController.GetAllCars();
        }

        private List<ListViewItem> ConvertToListViewItems(List<RentableProduct> rents)
        {
            var items = new List<ListViewItem>();

            foreach (var rent in rents)
            {
                var item = new ListViewItem(rent.Name);
                item.SubItems.Add(rent.ToString());
                item.SubItems.Add(rent.CalcularPrecioAlquiler().ToString());
                items.Add(item);
            }

            return items;
        }

        private void RefreshListView(List<ListViewItem> items)
        {
            lVRent.Items.Clear();
            lVRent.Items.AddRange(items.ToArray());
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


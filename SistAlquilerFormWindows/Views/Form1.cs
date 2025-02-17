using SistAlquilerFormWindows.Controllers;
using SistAlquilerFormWindows.DAO;
using SistAlquilerFormWindows.Factory;
using SistAlquilerFormWindows.Interfaces;
using SistAlquilerFormWindows.Models;
using SistAlquilerFormWindows.Models.Interfaces;
using SistAlquilerFormWindows.Models.PriceStrategy;
using SistAlquilerFormWindows.Services;
using SistAlquilerFormWindows.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistAlquilerFormWindows
{
    public partial class Form1 : Form
    {
        private static Form1 _instance;
        private static readonly object _lock = new object();

        private readonly RentController _rentController;
        private WashingMachineController _washingMachineController = WashingMachineController.Instance;
        private CarController _carController = CarController.Instance;


        private Form1(GenericProductFactory factory)
        {
            InitializeComponent();
            _rentController = new RentController(factory);
            InitializeComboBox();
            UpdateCarComboBox();
            UpdateWashingComboBox();
            UpdateProductList();
        }

        private void InitializeComboBox()
        {
            cmbProductType.Items.AddRange(new string[] { "Car", "Washing Machine" });
            cmbProductType.SelectedIndex = 0;
        }


        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(out string name, out DateTime start, out DateTime end, out decimal price))
                return;

            IRentableObject rentableObject = GetSelectedRentableObject();
            if (rentableObject == null)
            {
                MessageBox.Show("Seleccione un producto válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                UpdateUIAfterProductAdded(name, start, end, price, rentableObject);
                UpdateProductList();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error de Alquiler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
                MessageBox.Show("Ocurrió un error inesperado. Consulte la consola para más detalles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private bool ValidateInputs(out string name, out DateTime start, out DateTime end, out decimal price)
        {
            name = txtName.Text;
            start = dateTimeStart.Value;
            end = dateTimeFinish.Value;
            price = 0;

            if (!ValidatePrice(out price) ||
                !ValidateProductName() ||
                !ValidateDates())
            {
                return false;
            }

            return true;
        }

        private IRentableObject GetSelectedRentableObject()
        {
            switch (cmbProductType.SelectedItem)
            {
                case "Car":
                    var carSelected = GetSelectedCar();
                    return carSelected as IRentableObject;
                case "Washing Machine":
                    var WashingMachineSelected = GetSelectedWashingMachine();
                    return WashingMachineSelected as IRentableObject;
                default:
                return null;
            }
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message);
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
            if (dateTimeStart.Value < DateTime.Now)
            {
                ShowErrorMessage("La fecha ingresada no es válida. Debe ser igual o posterior a la fecha y hora actual.");
                return false;
            }
            if (dateTimeStart.Value >= dateTimeFinish.Value )
            {
                ShowErrorMessage("The start date must be earlier than the finish date.");
                return false;
            }
            return true;
        }

        private void UpdateUIAfterProductAdded(string name, DateTime start, DateTime end, decimal price, IRentableObject rentableObject)
        {
            _rentController.AddRent(name, start, end, price, rentableObject);
            UpdateProductList();
            ClearInputs();
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

        //// Obtiene la lavadora seleccionada
        private WashingMachine GetSelectedWashingMachine()
        {
            if (cmbWashing.SelectedItem is WashingMachine selectedMachine)
            {
                return selectedMachine;
            }

            ShowErrorMessage("Please select a valid washing machine from the list.");
            return null;
        }

        private void UpdateProductList()
        {
            lVRent.Items.Clear();
            foreach (var rent in _rentController.GetAllRents())
            {
                var item = new ListViewItem(rent.Name);
                item.SubItems.Add(rent.ToString());
                item.SubItems.Add(rent.CalcularPrecioAlquiler().ToString());
                item.SubItems.Add(rent.Id.ToString());
                item.Tag = rent.Id;
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


        private void btnEditRent_Click(object sender, EventArgs e)
        {

            if (!ValidateInputs(out string name, out DateTime start, out DateTime end, out decimal price))
                return;

            //IRentableObject newProduct = GetSelectedRentableObject();
            //if (newProduct == null)
            //{
            //    MessageBox.Show("Seleccione un nuevo producto válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            try
            {
                int rentId = SelectedItem();
                _rentController.ModifyRent(rentId, start, end, price, name);
                UpdateProductList();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error de Edición", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
                MessageBox.Show("Ocurrió un error inesperado. Consulte la consola para más detalles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int SelectedItem()
        {
            if (lVRent.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una Renta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            ListViewItem selectedItem = lVRent.SelectedItems[0];
            int rentId = Convert.ToInt32(selectedItem.Tag);
            return rentId;
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            int rentId = SelectedItem();
            RentableProduct renta = _rentController.GetRentById(rentId);
            ShowItemDetails(renta);
        }

        private void ShowItemDetails(RentableProduct renta)
        {
            txtName.Text = renta.Name;
            dateTimeStart.Value = renta.DateTimeStart;
            dateTimeFinish.Value = renta.EndDateTime;
            txtPriceXHora.Text = Convert.ToDecimal(renta.PrecioxHora).ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rentId = SelectedItem();
            if (rentId == 0) return;
            _rentController.DeleteRent(rentId);
            UpdateProductList();
        }

        internal static Form1 GetInstance(GenericProductFactory factory)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                lock (_lock)
                {
                    if (_instance == null || _instance.IsDisposed)
                    {
                        _instance = new Form1(factory);
                    }
                }
            }
            return _instance;
        }
    }
}


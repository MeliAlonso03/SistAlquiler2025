using SistAlquilerFormWindows.Controllers;
using SistAlquilerFormWindows.Models;
using SistAlquilerFormWindows.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SistAlquilerFormWindows.Views
{
    public partial class CreateCar : Form
    {
        private readonly CarController _carController;
        private readonly Form1 _form1;
        private readonly Inicio _inicio;
        public CreateCar(Form1 form1, Inicio inicio)
        {
            InitializeComponent();
            _form1 = form1;
            _inicio = inicio;
            _carController = CarController.Instance;
            UpdateProductList();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            string model = txtModelCar.Text;
            string licencePlate = txtLicencePlate.Text;

            _carController.AddCar(licencePlate, model);
            UpdateProductList();
            ClearInputs();
            _form1.UpdateCarComboBox();
        }


        private void UpdateProductList()
        {
            lvCar.Items.Clear();
            List<Car> cars = _carController.GetAllCars();

            foreach (var car in cars)
            {
                ListViewItem item = new ListViewItem(car.LicensePlate);
                item.SubItems.Add(car.Model);
                item.Tag = car.Id;
                lvCar.Items.Add(item);
            }
        }

        private void ClearInputs()
        {
            txtModelCar.Clear();
            txtLicencePlate.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            _inicio.Show();
        }

        private void btnUpdateCar_Click(object sender, EventArgs e)
        {
            int carId = SelectedItem();
            string model = txtModelCar.Text;
            string licensePlate = txtLicencePlate.Text;
            if (!ValidateInput()) return;
            _carController.ModificarAuto(carId, licensePlate, model);
            UpdateProductList();
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            int carId = SelectedItem();
            _carController.BorrarAuto(carId);
            UpdateProductList();
        }
        private int SelectedItem()
        {
            if (lvCar.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un auto para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            ListViewItem selectedItem = lvCar.SelectedItems[0];
            int carId = Convert.ToInt32(selectedItem.Tag);
            return carId;
        }
        private bool ValidateInput()
        {
            if (!ValidateLicensePlate() ||
                !ValidateModel())
            {
                return false;
            }

            return true;
        }
        private bool ValidateLicensePlate()
        {
            if (string.IsNullOrWhiteSpace(txtLicencePlate.Text))
            {
                ShowErrorMessage("Please enter a valid License Plate for the product.");
                return false;
            }
            return true;
        }
        private bool ValidateModel()
        {
            if (string.IsNullOrWhiteSpace(txtModelCar.Text))
            {
                ShowErrorMessage("Please enter a valid Model for the product.");
                return false;
            }
            return true;
        }
        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void btnVerDatos_Click(object sender, EventArgs e)
        {
            int carID = SelectedItem();
            Car car = _carController.BuscarAuto(carID);
            if (car == null) return;
            ShowItemDetails(car);
        }

        private void ShowItemDetails(Car car)
        {
            txtLicencePlate.Text = car.LicensePlate;
            txtModelCar.Text = car.Model;
        }
    }
}

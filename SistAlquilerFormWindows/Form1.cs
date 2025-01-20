using SistAlquilerFormWindows.Controllers;
using SistAlquilerFormWindows.Factory;
using SistAlquilerFormWindows.Models;
using SistAlquilerFormWindows.Models.Interfaces;
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
        private Dictionary<string, IProductFactory> factories;
        private List<IRentableProduct> products;
        private WashingMachineController _washingMachineController = WashingMachineController.Instance;
        private CarController _carController = CarController.Instance;

        public Form1()
        {
            InitializeComponent();
            InitializeFactories();
            InitializeComboBox();
            products = new List<IRentableProduct>();

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
            string productType = cmbProductType.Text;
            string name = txtName.Text;
            DateTime _dateTimeStart = dateTimeStart.Value;
            DateTime _dateTimeFinish = dateTimeFinish.Value;


            try
            {
                IRentableProduct product;

                switch (productType)
                {
                    case "Car":
                        // Obtén el objeto seleccionado del ComboBox
                        if (cmbCar.SelectedItem is Car selectedCar)
                        {
                            product = factories[productType].CreateProduct(name, _dateTimeStart, _dateTimeFinish, selectedCar);
                        }
                        else
                        {
                            MessageBox.Show("Please select a valid car from the list.");
                            return;
                        }
                        break;

                    case "Washing Machine":
                        // Obtén el objeto seleccionado del ComboBox
                        if (cmbWashing.SelectedItem is WashingMachine selectedMachine)
                        {
                            product = factories[productType].CreateProduct(name, _dateTimeStart, _dateTimeFinish, selectedMachine);
                        }
                        else
                        {
                            MessageBox.Show("Please select a valid washing machine from the list.");
                            return;
                        }
                        break;

                    default:
                        MessageBox.Show("Invalid product type");
                        return;
                }

                products.Add(product);
                UpdateProductList();
                ClearInputs();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateProductList()
        {
            lstProducts.Items.Clear();
            foreach (var product in products)
            {
                lstProducts.Items.Add(product.GetDetails());
            }
        }
        private void ClearInputs()
        {
            txtName.Clear();
            txtDailyRate.Clear();
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

        private void btnAddCars_Click(object sender, EventArgs e)
        {
            CreateCar carForm = new CreateCar(this);
            carForm.ShowDialog();
        }

        private void btnAddWashingMachine_Click(object sender, EventArgs e)
        {
            CreateWashingMachine washing = new CreateWashingMachine(this);
            washing.ShowDialog();
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
    }
}

using SistAlquilerFormWindows.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistAlquilerFormWindows.Views
{
    public partial class CreateWashingMachine : Form
    {
        private readonly WashingMachineController _washingController;
        private readonly Form1 _form1;
        private readonly Inicio _inicio;
        public CreateWashingMachine(Form1 form1, Inicio inicio)
        {
            InitializeComponent();
            _form1 = form1;

            // Obtiene la instancia única del controlador
            _washingController = WashingMachineController.Instance;
            _inicio = inicio;
        }

        private void btnAddWashingMachine_Click(object sender, EventArgs e)
        {
            string brand = txtBrand.Text;
            string model = txtModel.Text;
            string uniqueId = txtUniqueId.Text;

            if (string.IsNullOrWhiteSpace(brand) || string.IsNullOrWhiteSpace(model) || string.IsNullOrWhiteSpace(uniqueId))
            {
                MessageBox.Show("All fields are required. Please fill in all the details.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            _washingController.AddWashingMachine(brand, model, uniqueId);
            UpdateProductList();
            ClearInputs();
            _form1.UpdateWashingComboBox();
        }

        private void UpdateProductList()
        {
            lstWashingMachine.Items.Clear();
            lstWashingMachine.Items.AddRange(_washingController.GetAllCars().ToArray());
        }

        private void ClearInputs()
        {
            txtBrand.Clear();
            txtModel.Clear();
            txtUniqueId.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            _inicio.Show();
        }
    }
}

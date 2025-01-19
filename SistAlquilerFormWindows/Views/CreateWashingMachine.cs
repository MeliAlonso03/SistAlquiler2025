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
        public CreateWashingMachine(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;

            // Obtiene la instancia única del controlador
            _washingController = WashingMachineController.Instance;
        }

        private void btnAddWashingMachine_Click(object sender, EventArgs e)
        {
            string Brand = txtBrand.Text;
            string Model = txtModel.Text;
            string UniqueId = txtUniqueId.Text;

            _washingController.AddWashingMachine(Brand, Model, UniqueId);
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
    }
}

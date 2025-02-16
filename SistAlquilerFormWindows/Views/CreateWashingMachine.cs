using SistAlquilerFormWindows.Controllers;
using SistAlquilerFormWindows.Models;
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
            if (!ValidateInput()) return;
            string brand = txtBrand.Text;
            string model = txtModel.Text;
            string uniqueId = txtUniqueId.Text;

            _washingController.AddWashingMachine(brand, model, uniqueId);
            UpdateProductList();
            ClearInputs();
            _form1.UpdateWashingComboBox();
        }

        private void UpdateProductList()
        {
            lvWashing.Items.Clear();
            List<WashingMachine> washings = _washingController.GetAllCars();

            foreach (var washing in washings)
            {
                ListViewItem item = new ListViewItem(washing.Brand);
                item.SubItems.Add(washing.Model);
                item.SubItems.Add(washing.UniqueId);
                item.Tag = washing.Id;
                lvWashing.Items.Add(item);
            }
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

        private void btnUpdateWashingMachine_Click(object sender, EventArgs e)
        {
            int washingMachinId = SelectedItem();
            string newModel = txtModel.Text;
            string newBrand = txtBrand.Text;
            string newUniqueId = txtUniqueId.Text;
            if (!ValidateInput()) return;
            _washingController.ModificarLavarropa(washingMachinId, newBrand, newModel, newUniqueId);
            UpdateProductList();

        }
        private int SelectedItem()
        {
            if (lvWashing.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un Lavarropa para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            ListViewItem selectedItem = lvWashing.SelectedItems[0];
            int washingMachineId = Convert.ToInt32(selectedItem.Tag);
            return washingMachineId;
        }
        private bool ValidateInput()
        {
            if (!ValidateModel() ||
                !ValidateUniqueID()||
                !ValidateBrand())
            {
                return false;
            }

            return true;
        }

        private bool ValidateBrand()
        {
            if (string.IsNullOrWhiteSpace(txtBrand.Text))
            {
                ShowErrorMessage("Please enter a valid Brand for the product.");
                return false;
            }
            return true;
        }

        private bool ValidateUniqueID()
        {
            if (string.IsNullOrWhiteSpace(txtUniqueId.Text))
            {
                ShowErrorMessage("Please enter a valid Unique ID for the product.");
                return false;
            }
            return true;
        }

        private bool ValidateModel()
        {
            if (string.IsNullOrWhiteSpace(txtModel.Text))
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

        private void btnEliminarWashingMachine_Click(object sender, EventArgs e)
        {
            int washingMachineId = SelectedItem();
            _washingController.BorrarLavarropa(washingMachineId);
            UpdateProductList();
        }

        private void btnVerDatos_Click(object sender, EventArgs e)
        {
            int washingMachineId = SelectedItem();
            WashingMachine lavarropa = _washingController.BuscarLavarropa(washingMachineId);
            if (lavarropa == null) return;
            ShowItemDetails(lavarropa);
        }

        private void ShowItemDetails(WashingMachine lavarropa)
        {
            txtBrand.Text = lavarropa.Brand;
            txtModel.Text = lavarropa.Model;
            txtUniqueId.Text = lavarropa.UniqueId;
        }
    }
}

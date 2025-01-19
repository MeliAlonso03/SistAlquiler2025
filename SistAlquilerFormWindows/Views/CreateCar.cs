using SistAlquilerFormWindows.Controllers;
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

namespace SistAlquilerFormWindows.Views
{
    public partial class CreateCar : Form
    {
        private readonly CarController _carController;
        private readonly Form1 _form1;
        public CreateCar(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;

            // Obtiene la instancia única del controlador
            _carController = CarController.Instance;
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            string model = txtModelCar.Text;
            string licencePlate = txtLicencePlate.Text;

            _carController.AddCar(licencePlate, model); // Usa la instancia del campo global
            UpdateProductList();
            ClearInputs();
            _form1.UpdateCarComboBox();
        }

        private void UpdateProductList()
        {
            lstCars.Items.Clear();
            lstCars.Items.AddRange(_carController.GetAllCars().ToArray()); // Usa el campo global
        }

        private void ClearInputs()
        {
            txtModelCar.Clear();
            txtLicencePlate.Clear();
        }
    }
}

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

namespace SistAlquilerFormWindows
{
    public partial class Inicio : Form
    {
        private Form1 _form1;

        public Inicio(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
            btnRent.Enabled = false;
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            CreateCar carForm = new CreateCar(_form1, this);
            carForm.ShowDialog();
            UpdateRentButton();
        }

        private void btnAddWashingMachine_Click(object sender, EventArgs e)
        {
            CreateWashingMachine washing = new CreateWashingMachine(_form1, this);
            washing.ShowDialog();
            UpdateRentButton();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            Form1 form = Form1.GetInstance(); 
            form.Show();
            form.BringToFront();
        }
        private void UpdateRentButton()
        {
            bool hasCars = _form1.GetCarCount() > 0;
            bool hasWashingMachines = _form1.GetWashingMachineCount() > 0;

            btnRent.Enabled = hasCars || hasWashingMachines;
        }

    }
}

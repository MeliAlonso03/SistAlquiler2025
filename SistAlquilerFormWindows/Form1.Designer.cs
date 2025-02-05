namespace SistAlquilerFormWindows
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPriceXHora = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDailyRate = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.btnAddCars = new System.Windows.Forms.Button();
            this.btnAddWashingMachine = new System.Windows.Forms.Button();
            this.lblCar = new System.Windows.Forms.Label();
            this.cmbCar = new System.Windows.Forms.ComboBox();
            this.cmbWashing = new System.Windows.Forms.ComboBox();
            this.lblWashing = new System.Windows.Forms.Label();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFinish = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtPriceXHora
            // 
            this.txtPriceXHora.Location = new System.Drawing.Point(156, 258);
            this.txtPriceXHora.Name = "txtPriceXHora";
            this.txtPriceXHora.Size = new System.Drawing.Size(100, 22);
            this.txtPriceXHora.TabIndex = 9;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(34, 75);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 16);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(131, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 11;
            // 
            // lblDailyRate
            // 
            this.lblDailyRate.AutoSize = true;
            this.lblDailyRate.Location = new System.Drawing.Point(37, 264);
            this.lblDailyRate.Name = "lblDailyRate";
            this.lblDailyRate.Size = new System.Drawing.Size(82, 16);
            this.lblDailyRate.TabIndex = 10;
            this.lblDailyRate.Text = "Price X Hora";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(156, 311);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(90, 34);
            this.btnAddProduct.TabIndex = 12;
            this.btnAddProduct.Text = "add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // cmbProductType
            // 
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Location = new System.Drawing.Point(52, 22);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(157, 24);
            this.cmbProductType.TabIndex = 13;
            this.cmbProductType.SelectedIndexChanged += new System.EventHandler(this.cmbProductType_SelectedIndexChanged);
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.ItemHeight = 16;
            this.lstProducts.Location = new System.Drawing.Point(402, 12);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(375, 308);
            this.lstProducts.TabIndex = 14;
            // 
            // btnAddCars
            // 
            this.btnAddCars.Location = new System.Drawing.Point(450, 328);
            this.btnAddCars.Name = "btnAddCars";
            this.btnAddCars.Size = new System.Drawing.Size(133, 90);
            this.btnAddCars.TabIndex = 15;
            this.btnAddCars.Text = "Add Cars";
            this.btnAddCars.UseVisualStyleBackColor = true;
            this.btnAddCars.Click += new System.EventHandler(this.btnAddCars_Click);
            // 
            // btnAddWashingMachine
            // 
            this.btnAddWashingMachine.Location = new System.Drawing.Point(589, 328);
            this.btnAddWashingMachine.Name = "btnAddWashingMachine";
            this.btnAddWashingMachine.Size = new System.Drawing.Size(133, 90);
            this.btnAddWashingMachine.TabIndex = 16;
            this.btnAddWashingMachine.Text = "Add \r\nWahing Machine";
            this.btnAddWashingMachine.UseVisualStyleBackColor = true;
            this.btnAddWashingMachine.Click += new System.EventHandler(this.btnAddWashingMachine_Click);
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Location = new System.Drawing.Point(37, 178);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(31, 16);
            this.lblCar.TabIndex = 17;
            this.lblCar.Text = "Car:";
            // 
            // cmbCar
            // 
            this.cmbCar.FormattingEnabled = true;
            this.cmbCar.Location = new System.Drawing.Point(156, 178);
            this.cmbCar.Name = "cmbCar";
            this.cmbCar.Size = new System.Drawing.Size(121, 24);
            this.cmbCar.TabIndex = 18;
            // 
            // cmbWashing
            // 
            this.cmbWashing.FormattingEnabled = true;
            this.cmbWashing.Location = new System.Drawing.Point(156, 209);
            this.cmbWashing.Name = "cmbWashing";
            this.cmbWashing.Size = new System.Drawing.Size(121, 24);
            this.cmbWashing.TabIndex = 20;
            // 
            // lblWashing
            // 
            this.lblWashing.AutoSize = true;
            this.lblWashing.Location = new System.Drawing.Point(37, 209);
            this.lblWashing.Name = "lblWashing";
            this.lblWashing.Size = new System.Drawing.Size(114, 16);
            this.lblWashing.TabIndex = 19;
            this.lblWashing.Text = "WashingMachine:";
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeStart.Location = new System.Drawing.Point(36, 100);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(269, 22);
            this.dateTimeStart.TabIndex = 21;
            // 
            // dateTimeFinish
            // 
            this.dateTimeFinish.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimeFinish.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeFinish.Location = new System.Drawing.Point(36, 128);
            this.dateTimeFinish.Name = "dateTimeFinish";
            this.dateTimeFinish.Size = new System.Drawing.Size(269, 22);
            this.dateTimeFinish.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimeFinish);
            this.Controls.Add(this.dateTimeStart);
            this.Controls.Add(this.cmbWashing);
            this.Controls.Add(this.lblWashing);
            this.Controls.Add(this.cmbCar);
            this.Controls.Add(this.lblCar);
            this.Controls.Add(this.btnAddWashingMachine);
            this.Controls.Add(this.btnAddCars);
            this.Controls.Add(this.lstProducts);
            this.Controls.Add(this.cmbProductType);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDailyRate);
            this.Controls.Add(this.txtPriceXHora);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPriceXHora;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDailyRate;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.ComboBox cmbProductType;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.Button btnAddCars;
        private System.Windows.Forms.Button btnAddWashingMachine;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.ComboBox cmbCar;
        private System.Windows.Forms.ComboBox cmbWashing;
        private System.Windows.Forms.Label lblWashing;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.DateTimePicker dateTimeFinish;
    }
}


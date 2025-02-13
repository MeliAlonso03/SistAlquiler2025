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
            this.lblCar = new System.Windows.Forms.Label();
            this.cmbCar = new System.Windows.Forms.ComboBox();
            this.cmbWashing = new System.Windows.Forms.ComboBox();
            this.lblWashing = new System.Windows.Forms.Label();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFinish = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lVRent = new System.Windows.Forms.ListView();
            this.clUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clObjeto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtPriceXHora
            // 
            this.txtPriceXHora.Location = new System.Drawing.Point(183, 318);
            this.txtPriceXHora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPriceXHora.Name = "txtPriceXHora";
            this.txtPriceXHora.Size = new System.Drawing.Size(121, 22);
            this.txtPriceXHora.TabIndex = 9;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(52, 133);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 16);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(183, 124);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 22);
            this.txtName.TabIndex = 11;
            // 
            // lblDailyRate
            // 
            this.lblDailyRate.AutoSize = true;
            this.lblDailyRate.Location = new System.Drawing.Point(52, 321);
            this.lblDailyRate.Name = "lblDailyRate";
            this.lblDailyRate.Size = new System.Drawing.Size(85, 16);
            this.lblDailyRate.TabIndex = 10;
            this.lblDailyRate.Text = "Price X Hora:";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddProduct.Font = new System.Drawing.Font("Consolas", 15F);
            this.btnAddProduct.Location = new System.Drawing.Point(103, 383);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(123, 46);
            this.btnAddProduct.TabIndex = 12;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // cmbProductType
            // 
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Location = new System.Drawing.Point(77, 71);
            this.cmbProductType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(192, 24);
            this.cmbProductType.TabIndex = 13;
            this.cmbProductType.SelectedIndexChanged += new System.EventHandler(this.cmbProductType_SelectedIndexChanged);
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Location = new System.Drawing.Point(52, 242);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(31, 16);
            this.lblCar.TabIndex = 17;
            this.lblCar.Text = "Car:";
            // 
            // cmbCar
            // 
            this.cmbCar.FormattingEnabled = true;
            this.cmbCar.Location = new System.Drawing.Point(183, 233);
            this.cmbCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCar.Name = "cmbCar";
            this.cmbCar.Size = new System.Drawing.Size(121, 24);
            this.cmbCar.TabIndex = 18;
            this.cmbCar.SelectedIndexChanged += new System.EventHandler(this.cmbCar_SelectedIndexChanged);
            // 
            // cmbWashing
            // 
            this.cmbWashing.FormattingEnabled = true;
            this.cmbWashing.Location = new System.Drawing.Point(183, 271);
            this.cmbWashing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbWashing.Name = "cmbWashing";
            this.cmbWashing.Size = new System.Drawing.Size(121, 24);
            this.cmbWashing.TabIndex = 20;
            // 
            // lblWashing
            // 
            this.lblWashing.AutoSize = true;
            this.lblWashing.Location = new System.Drawing.Point(52, 274);
            this.lblWashing.Name = "lblWashing";
            this.lblWashing.Size = new System.Drawing.Size(114, 16);
            this.lblWashing.TabIndex = 19;
            this.lblWashing.Text = "WashingMachine:";
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeStart.Location = new System.Drawing.Point(115, 171);
            this.dateTimeStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(189, 22);
            this.dateTimeStart.TabIndex = 21;
            // 
            // dateTimeFinish
            // 
            this.dateTimeFinish.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimeFinish.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeFinish.Location = new System.Drawing.Point(115, 201);
            this.dateTimeFinish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeFinish.Name = "dateTimeFinish";
            this.dateTimeFinish.Size = new System.Drawing.Size(189, 22);
            this.dateTimeFinish.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 180);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label3.Location = new System.Drawing.Point(489, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 39);
            this.label3.TabIndex = 26;
            this.label3.Text = "Rented";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Consolas", 15F);
            this.btnBack.Location = new System.Drawing.Point(623, 386);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 38);
            this.btnBack.TabIndex = 27;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lVRent
            // 
            this.lVRent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clUser,
            this.clObjeto,
            this.clPrice});
            this.lVRent.HideSelection = false;
            this.lVRent.Location = new System.Drawing.Point(373, 83);
            this.lVRent.Name = "lVRent";
            this.lVRent.Size = new System.Drawing.Size(379, 257);
            this.lVRent.TabIndex = 28;
            this.lVRent.UseCompatibleStateImageBehavior = false;
            this.lVRent.View = System.Windows.Forms.View.Details;
            // 
            // clUser
            // 
            this.clUser.Text = "Usuario";
            this.clUser.Width = 90;
            // 
            // clObjeto
            // 
            this.clObjeto.Text = "Objeto";
            this.clObjeto.Width = 122;
            // 
            // clPrice
            // 
            this.clPrice.Text = "Precio";
            this.clPrice.Width = 113;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lVRent);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeFinish);
            this.Controls.Add(this.dateTimeStart);
            this.Controls.Add(this.cmbWashing);
            this.Controls.Add(this.lblWashing);
            this.Controls.Add(this.cmbCar);
            this.Controls.Add(this.lblCar);
            this.Controls.Add(this.cmbProductType);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDailyRate);
            this.Controls.Add(this.txtPriceXHora);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.ComboBox cmbCar;
        private System.Windows.Forms.ComboBox cmbWashing;
        private System.Windows.Forms.Label lblWashing;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.DateTimePicker dateTimeFinish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView lVRent;
        private System.Windows.Forms.ColumnHeader clUser;
        private System.Windows.Forms.ColumnHeader clObjeto;
        private System.Windows.Forms.ColumnHeader clPrice;
    }
}


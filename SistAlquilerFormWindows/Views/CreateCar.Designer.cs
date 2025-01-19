namespace SistAlquilerFormWindows.Views
{
    partial class CreateCar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLicensePlate = new System.Windows.Forms.Label();
            this.txtLicencePlate = new System.Windows.Forms.TextBox();
            this.txtModelCar = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.lstCars = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblLicensePlate
            // 
            this.lblLicensePlate.AutoSize = true;
            this.lblLicensePlate.Location = new System.Drawing.Point(54, 44);
            this.lblLicensePlate.Name = "lblLicensePlate";
            this.lblLicensePlate.Size = new System.Drawing.Size(91, 16);
            this.lblLicensePlate.TabIndex = 0;
            this.lblLicensePlate.Text = "Licence Plate:";
            // 
            // txtLicencePlate
            // 
            this.txtLicencePlate.Location = new System.Drawing.Point(151, 44);
            this.txtLicencePlate.Name = "txtLicencePlate";
            this.txtLicencePlate.Size = new System.Drawing.Size(100, 22);
            this.txtLicencePlate.TabIndex = 1;
            // 
            // txtModelCar
            // 
            this.txtModelCar.Location = new System.Drawing.Point(151, 94);
            this.txtModelCar.Name = "txtModelCar";
            this.txtModelCar.Size = new System.Drawing.Size(100, 22);
            this.txtModelCar.TabIndex = 3;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(54, 94);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(48, 16);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model:";
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(94, 158);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(118, 63);
            this.btnAddCar.TabIndex = 4;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // lstCars
            // 
            this.lstCars.FormattingEnabled = true;
            this.lstCars.ItemHeight = 16;
            this.lstCars.Location = new System.Drawing.Point(355, 44);
            this.lstCars.Name = "lstCars";
            this.lstCars.Size = new System.Drawing.Size(367, 324);
            this.lstCars.TabIndex = 5;
            // 
            // CreateCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstCars);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.txtModelCar);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtLicencePlate);
            this.Controls.Add(this.lblLicensePlate);
            this.Name = "CreateCar";
            this.Text = "CreateCar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLicensePlate;
        private System.Windows.Forms.TextBox txtLicencePlate;
        private System.Windows.Forms.TextBox txtModelCar;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.ListBox lstCars;
    }
}
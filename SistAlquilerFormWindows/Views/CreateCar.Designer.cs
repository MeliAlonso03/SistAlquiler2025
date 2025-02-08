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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLicensePlate
            // 
            this.lblLicensePlate.AutoSize = true;
            this.lblLicensePlate.Location = new System.Drawing.Point(58, 143);
            this.lblLicensePlate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLicensePlate.Name = "lblLicensePlate";
            this.lblLicensePlate.Size = new System.Drawing.Size(75, 13);
            this.lblLicensePlate.TabIndex = 0;
            this.lblLicensePlate.Text = "Licence Plate:";
            // 
            // txtLicencePlate
            // 
            this.txtLicencePlate.Location = new System.Drawing.Point(137, 140);
            this.txtLicencePlate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLicencePlate.Name = "txtLicencePlate";
            this.txtLicencePlate.Size = new System.Drawing.Size(76, 20);
            this.txtLicencePlate.TabIndex = 1;
            // 
            // txtModelCar
            // 
            this.txtModelCar.Location = new System.Drawing.Point(137, 180);
            this.txtModelCar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtModelCar.Name = "txtModelCar";
            this.txtModelCar.Size = new System.Drawing.Size(76, 20);
            this.txtModelCar.TabIndex = 3;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(58, 180);
            this.lblModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(39, 13);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model:";
            // 
            // btnAddCar
            // 
            this.btnAddCar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddCar.Font = new System.Drawing.Font("Consolas", 15F);
            this.btnAddCar.Location = new System.Drawing.Point(113, 267);
            this.btnAddCar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(100, 51);
            this.btnAddCar.TabIndex = 4;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.UseVisualStyleBackColor = false;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // lstCars
            // 
            this.lstCars.FormattingEnabled = true;
            this.lstCars.Location = new System.Drawing.Point(281, 65);
            this.lstCars.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstCars.Name = "lstCars";
            this.lstCars.Size = new System.Drawing.Size(276, 238);
            this.lstCars.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20.25F);
            this.label1.Location = new System.Drawing.Point(226, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Car";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Consolas", 15F);
            this.btnBack.Location = new System.Drawing.Point(460, 323);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(97, 31);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CreateCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCars);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.txtModelCar);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtLicencePlate);
            this.Controls.Add(this.lblLicensePlate);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
    }
}
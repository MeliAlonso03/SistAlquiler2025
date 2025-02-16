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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lvCar = new System.Windows.Forms.ListView();
            this.clPatente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clModelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnVerDatos = new System.Windows.Forms.Button();
            this.btnDeleteCar = new System.Windows.Forms.Button();
            this.btnUpdateCar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLicensePlate
            // 
            this.lblLicensePlate.AutoSize = true;
            this.lblLicensePlate.Location = new System.Drawing.Point(77, 176);
            this.lblLicensePlate.Name = "lblLicensePlate";
            this.lblLicensePlate.Size = new System.Drawing.Size(91, 16);
            this.lblLicensePlate.TabIndex = 0;
            this.lblLicensePlate.Text = "Licence Plate:";
            // 
            // txtLicencePlate
            // 
            this.txtLicencePlate.Location = new System.Drawing.Point(183, 172);
            this.txtLicencePlate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLicencePlate.Name = "txtLicencePlate";
            this.txtLicencePlate.Size = new System.Drawing.Size(100, 22);
            this.txtLicencePlate.TabIndex = 1;
            // 
            // txtModelCar
            // 
            this.txtModelCar.Location = new System.Drawing.Point(183, 222);
            this.txtModelCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModelCar.Name = "txtModelCar";
            this.txtModelCar.Size = new System.Drawing.Size(100, 22);
            this.txtModelCar.TabIndex = 3;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(77, 222);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(48, 16);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model:";
            // 
            // btnAddCar
            // 
            this.btnAddCar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddCar.Font = new System.Drawing.Font("Consolas", 15F);
            this.btnAddCar.Location = new System.Drawing.Point(140, 270);
            this.btnAddCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(133, 63);
            this.btnAddCar.TabIndex = 4;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.UseVisualStyleBackColor = false;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20.25F);
            this.label1.Location = new System.Drawing.Point(301, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Car";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Consolas", 15F);
            this.btnBack.Location = new System.Drawing.Point(613, 398);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 38);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lvCar
            // 
            this.lvCar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clPatente,
            this.clModelo});
            this.lvCar.HideSelection = false;
            this.lvCar.Location = new System.Drawing.Point(383, 88);
            this.lvCar.Name = "lvCar";
            this.lvCar.Size = new System.Drawing.Size(359, 269);
            this.lvCar.TabIndex = 8;
            this.lvCar.UseCompatibleStateImageBehavior = false;
            this.lvCar.View = System.Windows.Forms.View.Details;
            // 
            // clPatente
            // 
            this.clPatente.Text = "Patente";
            this.clPatente.Width = 145;
            // 
            // clModelo
            // 
            this.clModelo.Text = "Modelo";
            this.clModelo.Width = 184;
            // 
            // btnVerDatos
            // 
            this.btnVerDatos.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnVerDatos.Font = new System.Drawing.Font("Consolas", 15F);
            this.btnVerDatos.Location = new System.Drawing.Point(395, 358);
            this.btnVerDatos.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerDatos.Name = "btnVerDatos";
            this.btnVerDatos.Size = new System.Drawing.Size(129, 38);
            this.btnVerDatos.TabIndex = 16;
            this.btnVerDatos.Text = "Ver Datos";
            this.btnVerDatos.UseVisualStyleBackColor = false;
            this.btnVerDatos.Click += new System.EventHandler(this.btnVerDatos_Click);
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDeleteCar.Font = new System.Drawing.Font("Consolas", 15F);
            this.btnDeleteCar.Location = new System.Drawing.Point(227, 399);
            this.btnDeleteCar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(129, 38);
            this.btnDeleteCar.TabIndex = 15;
            this.btnDeleteCar.Text = "Delete";
            this.btnDeleteCar.UseVisualStyleBackColor = false;
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
            // 
            // btnUpdateCar
            // 
            this.btnUpdateCar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUpdateCar.Font = new System.Drawing.Font("Consolas", 15F);
            this.btnUpdateCar.Location = new System.Drawing.Point(81, 399);
            this.btnUpdateCar.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateCar.Name = "btnUpdateCar";
            this.btnUpdateCar.Size = new System.Drawing.Size(129, 38);
            this.btnUpdateCar.TabIndex = 14;
            this.btnUpdateCar.Text = "Update";
            this.btnUpdateCar.UseVisualStyleBackColor = false;
            this.btnUpdateCar.Click += new System.EventHandler(this.btnUpdateCar_Click);
            // 
            // CreateCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVerDatos);
            this.Controls.Add(this.btnDeleteCar);
            this.Controls.Add(this.btnUpdateCar);
            this.Controls.Add(this.lvCar);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.txtModelCar);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtLicencePlate);
            this.Controls.Add(this.lblLicensePlate);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView lvCar;
        private System.Windows.Forms.ColumnHeader clPatente;
        private System.Windows.Forms.ColumnHeader clModelo;
        private System.Windows.Forms.Button btnVerDatos;
        private System.Windows.Forms.Button btnDeleteCar;
        private System.Windows.Forms.Button btnUpdateCar;
    }
}
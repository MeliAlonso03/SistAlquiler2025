namespace SistAlquilerFormWindows
{
    partial class Inicio
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
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnAddWashingMachine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddCar
            // 
            this.btnAddCar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddCar.Font = new System.Drawing.Font("Consolas", 15F);
            this.btnAddCar.Location = new System.Drawing.Point(388, 182);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(158, 81);
            this.btnAddCar.TabIndex = 0;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.UseVisualStyleBackColor = false;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnRent
            // 
            this.btnRent.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRent.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRent.Location = new System.Drawing.Point(306, 331);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(137, 107);
            this.btnRent.TabIndex = 1;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = false;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // btnAddWashingMachine
            // 
            this.btnAddWashingMachine.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddWashingMachine.Font = new System.Drawing.Font("Consolas", 15F);
            this.btnAddWashingMachine.Location = new System.Drawing.Point(200, 182);
            this.btnAddWashingMachine.Name = "btnAddWashingMachine";
            this.btnAddWashingMachine.Size = new System.Drawing.Size(158, 81);
            this.btnAddWashingMachine.TabIndex = 2;
            this.btnAddWashingMachine.Text = "Add Washing Machine";
            this.btnAddWashingMachine.UseVisualStyleBackColor = false;
            this.btnAddWashingMachine.Click += new System.EventHandler(this.btnAddWashingMachine_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(549, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "To get started, create the item you want to rent.";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddWashingMachine);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.btnAddCar);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnAddWashingMachine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
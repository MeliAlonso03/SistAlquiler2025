namespace SistAlquilerFormWindows.Views
{
    partial class CreateWashingMachine
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
            this.lblBrand = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtUniqueId = new System.Windows.Forms.TextBox();
            this.lblUniqueId = new System.Windows.Forms.Label();
            this.btnAddWashingMachine = new System.Windows.Forms.Button();
            this.lstWashingMachine = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(84, 110);
            this.lblBrand.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(41, 13);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "Brand: ";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(172, 103);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(76, 20);
            this.txtBrand.TabIndex = 1;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(172, 143);
            this.txtModel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(76, 20);
            this.txtModel.TabIndex = 3;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(86, 150);
            this.lblModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(39, 13);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model:";
            // 
            // txtUniqueId
            // 
            this.txtUniqueId.Location = new System.Drawing.Point(172, 192);
            this.txtUniqueId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUniqueId.Name = "txtUniqueId";
            this.txtUniqueId.Size = new System.Drawing.Size(76, 20);
            this.txtUniqueId.TabIndex = 5;
            // 
            // lblUniqueId
            // 
            this.lblUniqueId.AutoSize = true;
            this.lblUniqueId.Location = new System.Drawing.Point(82, 195);
            this.lblUniqueId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUniqueId.Name = "lblUniqueId";
            this.lblUniqueId.Size = new System.Drawing.Size(73, 13);
            this.lblUniqueId.TabIndex = 4;
            this.lblUniqueId.Text = "Identificación:";
            // 
            // btnAddWashingMachine
            // 
            this.btnAddWashingMachine.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddWashingMachine.Font = new System.Drawing.Font("Consolas", 15F);
            this.btnAddWashingMachine.Location = new System.Drawing.Point(105, 263);
            this.btnAddWashingMachine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddWashingMachine.Name = "btnAddWashingMachine";
            this.btnAddWashingMachine.Size = new System.Drawing.Size(133, 57);
            this.btnAddWashingMachine.TabIndex = 6;
            this.btnAddWashingMachine.Text = "Add\r\nWashing Machine\r\n";
            this.btnAddWashingMachine.UseVisualStyleBackColor = false;
            this.btnAddWashingMachine.Click += new System.EventHandler(this.btnAddWashingMachine_Click);
            // 
            // lstWashingMachine
            // 
            this.lstWashingMachine.FormattingEnabled = true;
            this.lstWashingMachine.Location = new System.Drawing.Point(316, 76);
            this.lstWashingMachine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstWashingMachine.Name = "lstWashingMachine";
            this.lstWashingMachine.Size = new System.Drawing.Size(249, 225);
            this.lstWashingMachine.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20.25F);
            this.label1.Location = new System.Drawing.Point(166, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Washing Machine";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Consolas", 15F);
            this.btnBack.Location = new System.Drawing.Point(442, 325);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(97, 31);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CreateWashingMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstWashingMachine);
            this.Controls.Add(this.btnAddWashingMachine);
            this.Controls.Add(this.txtUniqueId);
            this.Controls.Add(this.lblUniqueId);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.lblBrand);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CreateWashingMachine";
            this.Text = "CreateWashingMachine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtUniqueId;
        private System.Windows.Forms.Label lblUniqueId;
        private System.Windows.Forms.Button btnAddWashingMachine;
        private System.Windows.Forms.ListBox lstWashingMachine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
    }
}
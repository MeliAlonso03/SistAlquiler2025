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
            this.SuspendLayout();
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(69, 36);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(49, 16);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "Brand: ";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(169, 36);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(100, 22);
            this.txtBrand.TabIndex = 1;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(169, 85);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 22);
            this.txtModel.TabIndex = 3;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(69, 85);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(48, 16);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model:";
            // 
            // txtUniqueId
            // 
            this.txtUniqueId.Location = new System.Drawing.Point(169, 140);
            this.txtUniqueId.Name = "txtUniqueId";
            this.txtUniqueId.Size = new System.Drawing.Size(100, 22);
            this.txtUniqueId.TabIndex = 5;
            // 
            // lblUniqueId
            // 
            this.lblUniqueId.AutoSize = true;
            this.lblUniqueId.Location = new System.Drawing.Point(69, 140);
            this.lblUniqueId.Name = "lblUniqueId";
            this.lblUniqueId.Size = new System.Drawing.Size(88, 16);
            this.lblUniqueId.TabIndex = 4;
            this.lblUniqueId.Text = "Identificación:";
            // 
            // btnAddWashingMachine
            // 
            this.btnAddWashingMachine.Location = new System.Drawing.Point(82, 210);
            this.btnAddWashingMachine.Name = "btnAddWashingMachine";
            this.btnAddWashingMachine.Size = new System.Drawing.Size(177, 70);
            this.btnAddWashingMachine.TabIndex = 6;
            this.btnAddWashingMachine.Text = "Add\r\nWashing Machine\r\n";
            this.btnAddWashingMachine.UseVisualStyleBackColor = true;
            this.btnAddWashingMachine.Click += new System.EventHandler(this.btnAddWashingMachine_Click);
            // 
            // lstWashingMachine
            // 
            this.lstWashingMachine.FormattingEnabled = true;
            this.lstWashingMachine.ItemHeight = 16;
            this.lstWashingMachine.Location = new System.Drawing.Point(375, 36);
            this.lstWashingMachine.Name = "lstWashingMachine";
            this.lstWashingMachine.Size = new System.Drawing.Size(267, 308);
            this.lstWashingMachine.TabIndex = 7;
            // 
            // CreateWashingMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstWashingMachine);
            this.Controls.Add(this.btnAddWashingMachine);
            this.Controls.Add(this.txtUniqueId);
            this.Controls.Add(this.lblUniqueId);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.lblBrand);
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
    }
}
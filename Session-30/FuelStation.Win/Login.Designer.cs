namespace FuelStation.Win
{
    partial class Login
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
            this.btnLgManager = new System.Windows.Forms.Button();
            this.btnLgCashier = new System.Windows.Forms.Button();
            this.btnLgStaff = new System.Windows.Forms.Button();
            this.lbFuelStation = new System.Windows.Forms.Label();
            this.lbLoginAs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLgManager
            // 
            this.btnLgManager.Location = new System.Drawing.Point(87, 233);
            this.btnLgManager.Name = "btnLgManager";
            this.btnLgManager.Size = new System.Drawing.Size(177, 67);
            this.btnLgManager.TabIndex = 0;
            this.btnLgManager.Text = "Manager";
            this.btnLgManager.UseVisualStyleBackColor = true;
            // 
            // btnLgCashier
            // 
            this.btnLgCashier.Location = new System.Drawing.Point(313, 233);
            this.btnLgCashier.Name = "btnLgCashier";
            this.btnLgCashier.Size = new System.Drawing.Size(177, 67);
            this.btnLgCashier.TabIndex = 1;
            this.btnLgCashier.Text = "Cashier";
            this.btnLgCashier.UseVisualStyleBackColor = true;
            this.btnLgCashier.Click += new System.EventHandler(this.btnLgCashier_Click);
            // 
            // btnLgStaff
            // 
            this.btnLgStaff.Location = new System.Drawing.Point(532, 233);
            this.btnLgStaff.Name = "btnLgStaff";
            this.btnLgStaff.Size = new System.Drawing.Size(177, 67);
            this.btnLgStaff.TabIndex = 2;
            this.btnLgStaff.Text = "Staff";
            this.btnLgStaff.UseVisualStyleBackColor = true;
            // 
            // lbFuelStation
            // 
            this.lbFuelStation.AutoSize = true;
            this.lbFuelStation.Location = new System.Drawing.Point(313, 80);
            this.lbFuelStation.Name = "lbFuelStation";
            this.lbFuelStation.Size = new System.Drawing.Size(184, 20);
            this.lbFuelStation.TabIndex = 3;
            this.lbFuelStation.Text = "Fuel Station Windows App";
            // 
            // lbLoginAs
            // 
            this.lbLoginAs.AutoSize = true;
            this.lbLoginAs.Location = new System.Drawing.Point(370, 151);
            this.lbLoginAs.Name = "lbLoginAs";
            this.lbLoginAs.Size = new System.Drawing.Size(66, 20);
            this.lbLoginAs.TabIndex = 4;
            this.lbLoginAs.Text = "Login As";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbLoginAs);
            this.Controls.Add(this.lbFuelStation);
            this.Controls.Add(this.btnLgStaff);
            this.Controls.Add(this.btnLgCashier);
            this.Controls.Add(this.btnLgManager);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLgManager;
        private Button btnLgCashier;
        private Button btnLgStaff;
        private Label lbFuelStation;
        private Label lbLoginAs;
    }
}
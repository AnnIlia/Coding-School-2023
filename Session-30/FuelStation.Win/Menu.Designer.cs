namespace FuelStation.Win
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnMnTransactions = new System.Windows.Forms.Button();
            this.btnMnItems = new System.Windows.Forms.Button();
            this.btnMnCustomers = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbMenu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMnTransactions
            // 
            this.btnMnTransactions.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMnTransactions.Location = new System.Drawing.Point(534, 192);
            this.btnMnTransactions.Name = "btnMnTransactions";
            this.btnMnTransactions.Size = new System.Drawing.Size(177, 67);
            this.btnMnTransactions.TabIndex = 5;
            this.btnMnTransactions.Text = "Transactions";
            this.btnMnTransactions.UseVisualStyleBackColor = true;
            this.btnMnTransactions.Click += new System.EventHandler(this.btnMnTransactions_Click);
            // 
            // btnMnItems
            // 
            this.btnMnItems.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMnItems.Location = new System.Drawing.Point(315, 192);
            this.btnMnItems.Name = "btnMnItems";
            this.btnMnItems.Size = new System.Drawing.Size(177, 67);
            this.btnMnItems.TabIndex = 4;
            this.btnMnItems.Text = "Items";
            this.btnMnItems.UseVisualStyleBackColor = true;
            this.btnMnItems.Click += new System.EventHandler(this.btnMnItems_Click);
            // 
            // btnMnCustomers
            // 
            this.btnMnCustomers.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMnCustomers.Location = new System.Drawing.Point(90, 192);
            this.btnMnCustomers.Name = "btnMnCustomers";
            this.btnMnCustomers.Size = new System.Drawing.Size(177, 67);
            this.btnMnCustomers.TabIndex = 3;
            this.btnMnCustomers.Text = "Customers";
            this.btnMnCustomers.UseVisualStyleBackColor = true;
            this.btnMnCustomers.Click += new System.EventHandler(this.btnMnCustomers_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(366, 333);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 38);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Logout";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbMenu
            // 
            this.lbMenu.AutoSize = true;
            this.lbMenu.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMenu.Location = new System.Drawing.Point(366, 100);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(73, 31);
            this.lbMenu.TabIndex = 7;
            this.lbMenu.Text = "Menu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(377, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(320, 333);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbMenu);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMnTransactions);
            this.Controls.Add(this.btnMnItems);
            this.Controls.Add(this.btnMnCustomers);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnMnTransactions;
        private Button btnMnItems;
        private Button btnMnCustomers;
        private Button btnClose;
        private Label lbMenu;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
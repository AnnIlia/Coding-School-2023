namespace FuelStation.Win
{
    partial class Items
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Items));
            this.lbItems = new System.Windows.Forms.Label();
            this.lbTransaction = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GridItems = new System.Windows.Forms.DataGridView();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsItems = new System.Windows.Forms.BindingSource(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txbCode = new System.Windows.Forms.TextBox();
            this.lbCode = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbType = new System.Windows.Forms.Label();
            this.lbCost = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lbItems
            // 
            this.lbItems.AutoSize = true;
            this.lbItems.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbItems.Location = new System.Drawing.Point(332, 9);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(167, 28);
            this.lbItems.TabIndex = 5;
            this.lbItems.Text = "Items Information";
            // 
            // lbTransaction
            // 
            this.lbTransaction.AutoSize = true;
            this.lbTransaction.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbTransaction.Location = new System.Drawing.Point(127, 59);
            this.lbTransaction.Name = "lbTransaction";
            this.lbTransaction.Size = new System.Drawing.Size(614, 28);
            this.lbTransaction.TabIndex = 10;
            this.lbTransaction.Text = "Items ---------------------------------------------------------------------";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // GridItems
            // 
            this.GridItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCode,
            this.ItemType,
            this.ItemDescription,
            this.ItemCost,
            this.ItemPrice});
            this.GridItems.Location = new System.Drawing.Point(52, 102);
            this.GridItems.Name = "GridItems";
            this.GridItems.RowHeadersWidth = 51;
            this.GridItems.RowTemplate.Height = 29;
            this.GridItems.Size = new System.Drawing.Size(689, 135);
            this.GridItems.TabIndex = 14;
            this.GridItems.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.GridItems_DataError);
            // 
            // ItemCode
            // 
            this.ItemCode.DataPropertyName = "Code";
            this.ItemCode.HeaderText = "Code";
            this.ItemCode.MinimumWidth = 6;
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.Width = 125;
            // 
            // ItemType
            // 
            this.ItemType.DataPropertyName = "ItemType";
            this.ItemType.HeaderText = "Type";
            this.ItemType.MinimumWidth = 6;
            this.ItemType.Name = "ItemType";
            this.ItemType.Width = 125;
            // 
            // ItemDescription
            // 
            this.ItemDescription.DataPropertyName = "Description";
            this.ItemDescription.HeaderText = "Description";
            this.ItemDescription.MinimumWidth = 6;
            this.ItemDescription.Name = "ItemDescription";
            this.ItemDescription.Width = 125;
            // 
            // ItemCost
            // 
            this.ItemCost.DataPropertyName = "Cost";
            this.ItemCost.HeaderText = "Cost";
            this.ItemCost.MinimumWidth = 6;
            this.ItemCost.Name = "ItemCost";
            this.ItemCost.Width = 125;
            // 
            // ItemPrice
            // 
            this.ItemPrice.DataPropertyName = "Price";
            this.ItemPrice.HeaderText = "Price";
            this.ItemPrice.MinimumWidth = 6;
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.Width = 125;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(522, 455);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(137, 42);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(330, 530);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(137, 42);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Logout";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(330, 455);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 42);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(136, 455);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 42);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txbCode
            // 
            this.txbCode.Location = new System.Drawing.Point(370, 315);
            this.txbCode.Name = "txbCode";
            this.txbCode.Size = new System.Drawing.Size(129, 27);
            this.txbCode.TabIndex = 20;
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Location = new System.Drawing.Point(320, 322);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(44, 20);
            this.lbCode.TabIndex = 21;
            this.lbCode.Text = "Code";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(279, 365);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(85, 20);
            this.lbDescription.TabIndex = 23;
            this.lbDescription.Text = "Description";
            this.lbDescription.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(370, 362);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 27);
            this.textBox1.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(107, 319);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(131, 28);
            this.comboBox1.TabIndex = 24;
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(61, 322);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(40, 20);
            this.lbType.TabIndex = 25;
            this.lbType.Text = "Type";
            // 
            // lbCost
            // 
            this.lbCost.AutoSize = true;
            this.lbCost.Location = new System.Drawing.Point(557, 319);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(38, 20);
            this.lbCost.TabIndex = 27;
            this.lbCost.Text = "Cost";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(601, 315);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 27);
            this.textBox2.TabIndex = 26;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(554, 365);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(41, 20);
            this.lbPrice.TabIndex = 29;
            this.lbPrice.Text = "Price";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(601, 362);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(129, 27);
            this.textBox3.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(52, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(690, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Add New Item --------------------------------------------------------------------" +
    "------------------------------";
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 617);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lbCost);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbCode);
            this.Controls.Add(this.txbCode);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.GridItems);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbTransaction);
            this.Controls.Add(this.lbItems);
            this.Name = "Items";
            this.Text = "Items";
            this.Load += new System.EventHandler(this.Items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbItems;
        private Label lbTransaction;
        private PictureBox pictureBox1;
        private DataGridView GridItems;
        private BindingSource bsItems;
        private Button btnUpdate;
        private Button btnClose;
        private Button btnDelete;
        private Button btnSave;
        private TextBox txbCode;
        private Label lbCode;
        private Label lbDescription;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label lbType;
        private Label lbCost;
        private TextBox textBox2;
        private Label lbPrice;
        private TextBox textBox3;
        private Label label1;
        private DataGridViewTextBoxColumn ItemCode;
        private DataGridViewComboBoxColumn ItemType;
        private DataGridViewTextBoxColumn ItemDescription;
        private DataGridViewTextBoxColumn ItemCost;
        private DataGridViewTextBoxColumn ItemPrice;
    }
}
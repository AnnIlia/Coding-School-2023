namespace FuelStation.Win
{
    partial class TransactionLines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionLines));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewTransactionLine = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.TransactionLineId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionLineTramsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionLineItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionLineQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionLinePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionLineNetValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionLineDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionLineDiscountValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionLineTotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(508, 412);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(59, 42);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-190, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(113, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1127, 28);
            this.label1.TabIndex = 25;
            this.label1.Text = "Transactions Lines --------------------------------------------------------------" +
    "----------------------------------------------------------";
            // 
            // btnNewTransactionLine
            // 
            this.btnNewTransactionLine.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewTransactionLine.Location = new System.Drawing.Point(573, 412);
            this.btnNewTransactionLine.Name = "btnNewTransactionLine";
            this.btnNewTransactionLine.Size = new System.Drawing.Size(215, 42);
            this.btnNewTransactionLine.TabIndex = 24;
            this.btnNewTransactionLine.Text = "Add New Transaction Line";
            this.btnNewTransactionLine.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransactionLineId,
            this.TransactionLineTramsId,
            this.TransactionLineItemId,
            this.TransactionLineQuantity,
            this.TransactionLinePrice,
            this.TransactionLineNetValue,
            this.TransactionLineDiscount,
            this.TransactionLineDiscountValue,
            this.TransactionLineTotalValue});
            this.dataGridView2.Location = new System.Drawing.Point(56, 193);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(1181, 200);
            this.dataGridView2.TabIndex = 23;
            // 
            // TransactionLineId
            // 
            this.TransactionLineId.HeaderText = "Id";
            this.TransactionLineId.MinimumWidth = 6;
            this.TransactionLineId.Name = "TransactionLineId";
            this.TransactionLineId.Width = 125;
            // 
            // TransactionLineTramsId
            // 
            this.TransactionLineTramsId.HeaderText = "Transaction Id";
            this.TransactionLineTramsId.MinimumWidth = 6;
            this.TransactionLineTramsId.Name = "TransactionLineTramsId";
            this.TransactionLineTramsId.Width = 125;
            // 
            // TransactionLineItemId
            // 
            this.TransactionLineItemId.HeaderText = "Item";
            this.TransactionLineItemId.MinimumWidth = 6;
            this.TransactionLineItemId.Name = "TransactionLineItemId";
            this.TransactionLineItemId.ReadOnly = true;
            this.TransactionLineItemId.Width = 125;
            // 
            // TransactionLineQuantity
            // 
            this.TransactionLineQuantity.HeaderText = "Quantity";
            this.TransactionLineQuantity.MinimumWidth = 6;
            this.TransactionLineQuantity.Name = "TransactionLineQuantity";
            this.TransactionLineQuantity.ReadOnly = true;
            this.TransactionLineQuantity.Width = 125;
            // 
            // TransactionLinePrice
            // 
            this.TransactionLinePrice.HeaderText = "Price";
            this.TransactionLinePrice.MinimumWidth = 6;
            this.TransactionLinePrice.Name = "TransactionLinePrice";
            this.TransactionLinePrice.ReadOnly = true;
            this.TransactionLinePrice.Width = 125;
            // 
            // TransactionLineNetValue
            // 
            this.TransactionLineNetValue.HeaderText = "NetValue";
            this.TransactionLineNetValue.MinimumWidth = 6;
            this.TransactionLineNetValue.Name = "TransactionLineNetValue";
            this.TransactionLineNetValue.Width = 125;
            // 
            // TransactionLineDiscount
            // 
            this.TransactionLineDiscount.HeaderText = "Discount (%)";
            this.TransactionLineDiscount.MinimumWidth = 6;
            this.TransactionLineDiscount.Name = "TransactionLineDiscount";
            this.TransactionLineDiscount.Width = 125;
            // 
            // TransactionLineDiscountValue
            // 
            this.TransactionLineDiscountValue.HeaderText = "Discount Value";
            this.TransactionLineDiscountValue.MinimumWidth = 6;
            this.TransactionLineDiscountValue.Name = "TransactionLineDiscountValue";
            this.TransactionLineDiscountValue.Width = 125;
            // 
            // TransactionLineTotalValue
            // 
            this.TransactionLineTotalValue.HeaderText = "Total Value";
            this.TransactionLineTotalValue.MinimumWidth = 6;
            this.TransactionLineTotalValue.Name = "TransactionLineTotalValue";
            this.TransactionLineTotalValue.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(247, 510);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(41, 33);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 34;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(558, 491);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(43, 52);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 33;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(861, 501);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(41, 42);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 32;
            this.pictureBox5.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(908, 501);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(137, 42);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "Logout";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(607, 501);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 42);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(294, 501);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 42);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // TransactionLines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1278, 579);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewTransactionLine);
            this.Controls.Add(this.dataGridView2);
            this.Name = "TransactionLines";
            this.Text = "TransactionLines";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private Label label1;
        private Button btnNewTransactionLine;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn TransactionLineId;
        private DataGridViewTextBoxColumn TransactionLineTramsId;
        private DataGridViewTextBoxColumn TransactionLineItemId;
        private DataGridViewTextBoxColumn TransactionLineQuantity;
        private DataGridViewTextBoxColumn TransactionLinePrice;
        private DataGridViewTextBoxColumn TransactionLineNetValue;
        private DataGridViewTextBoxColumn TransactionLineDiscount;
        private DataGridViewTextBoxColumn TransactionLineDiscountValue;
        private DataGridViewTextBoxColumn TransactionLineTotalValue;
        private PictureBox pictureBox1;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private Button btnClose;
        private Button btnDelete;
        private Button btnSave;
    }
}
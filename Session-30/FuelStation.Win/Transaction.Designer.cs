namespace FuelStation.Win
{
    partial class Transaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaction));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TransactionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionPayMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionTotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTransaction = new System.Windows.Forms.Label();
            this.btnNewTransaction = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
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
            this.btnNewTransactionLine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTransAndTransactionLines = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransactionId,
            this.TransactionDate,
            this.TransactionEmployee,
            this.TransactionCustomer,
            this.TransactionPayMethod,
            this.TransactionTotalValue});
            this.dataGridView1.Location = new System.Drawing.Point(34, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(823, 224);
            this.dataGridView1.TabIndex = 0;
            // 
            // TransactionId
            // 
            this.TransactionId.HeaderText = "Id";
            this.TransactionId.MinimumWidth = 6;
            this.TransactionId.Name = "TransactionId";
            this.TransactionId.Width = 125;
            // 
            // TransactionDate
            // 
            this.TransactionDate.HeaderText = "Date";
            this.TransactionDate.MinimumWidth = 6;
            this.TransactionDate.Name = "TransactionDate";
            this.TransactionDate.Width = 125;
            // 
            // TransactionEmployee
            // 
            this.TransactionEmployee.HeaderText = "Employee";
            this.TransactionEmployee.MinimumWidth = 6;
            this.TransactionEmployee.Name = "TransactionEmployee";
            this.TransactionEmployee.Width = 125;
            // 
            // TransactionCustomer
            // 
            this.TransactionCustomer.HeaderText = "Customer";
            this.TransactionCustomer.MinimumWidth = 6;
            this.TransactionCustomer.Name = "TransactionCustomer";
            this.TransactionCustomer.Width = 125;
            // 
            // TransactionPayMethod
            // 
            this.TransactionPayMethod.HeaderText = "Payment Method";
            this.TransactionPayMethod.MinimumWidth = 6;
            this.TransactionPayMethod.Name = "TransactionPayMethod";
            this.TransactionPayMethod.Width = 125;
            // 
            // TransactionTotalValue
            // 
            this.TransactionTotalValue.HeaderText = "Total Value";
            this.TransactionTotalValue.MinimumWidth = 6;
            this.TransactionTotalValue.Name = "TransactionTotalValue";
            this.TransactionTotalValue.Width = 125;
            // 
            // lbTransaction
            // 
            this.lbTransaction.AutoSize = true;
            this.lbTransaction.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbTransaction.Location = new System.Drawing.Point(94, 168);
            this.lbTransaction.Name = "lbTransaction";
            this.lbTransaction.Size = new System.Drawing.Size(768, 28);
            this.lbTransaction.TabIndex = 1;
            this.lbTransaction.Text = "Transactions --------------------------------------------------------------------" +
    "-------------";
            this.lbTransaction.Click += new System.EventHandler(this.lbTransaction_Click);
            // 
            // btnNewTransaction
            // 
            this.btnNewTransaction.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewTransaction.Location = new System.Drawing.Point(303, 441);
            this.btnNewTransaction.Name = "btnNewTransaction";
            this.btnNewTransaction.Size = new System.Drawing.Size(299, 42);
            this.btnNewTransaction.TabIndex = 13;
            this.btnNewTransaction.Text = "Add New Transaction";
            this.btnNewTransaction.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(1014, 365);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(137, 42);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(1014, 275);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 42);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(1014, 202);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 42);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridView2
            // 
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
            this.dataGridView2.Location = new System.Drawing.Point(32, 553);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(1181, 200);
            this.dataGridView2.TabIndex = 14;
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
            // btnNewTransactionLine
            // 
            this.btnNewTransactionLine.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewTransactionLine.Location = new System.Drawing.Point(465, 770);
            this.btnNewTransactionLine.Name = "btnNewTransactionLine";
            this.btnNewTransactionLine.Size = new System.Drawing.Size(299, 42);
            this.btnNewTransactionLine.TabIndex = 15;
            this.btnNewTransactionLine.Text = "Add New Transaction Line";
            this.btnNewTransactionLine.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(94, 519);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1119, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "Transactions Lines --------------------------------------------------------------" +
    "---------------------------------------------------------";
            // 
            // lbTransAndTransactionLines
            // 
            this.lbTransAndTransactionLines.AutoSize = true;
            this.lbTransAndTransactionLines.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTransAndTransactionLines.Location = new System.Drawing.Point(465, 57);
            this.lbTransAndTransactionLines.Name = "lbTransAndTransactionLines";
            this.lbTransAndTransactionLines.Size = new System.Drawing.Size(299, 28);
            this.lbTransAndTransactionLines.TabIndex = 17;
            this.lbTransAndTransactionLines.Text = "Transaction and Transaction Lines";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(32, 494);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(285, 441);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(426, 770);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(59, 42);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1243, 867);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbTransAndTransactionLines);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewTransactionLine);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnNewTransaction);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbTransaction);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Transaction";
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.Transaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn TransactionId;
        private DataGridViewTextBoxColumn TransactionDate;
        private DataGridViewTextBoxColumn TransactionEmployee;
        private DataGridViewTextBoxColumn TransactionCustomer;
        private DataGridViewTextBoxColumn TransactionPayMethod;
        private DataGridViewTextBoxColumn TransactionTotalValue;
        private Label lbTransaction;
        private Button btnNewTransaction;
        private Button btnClose;
        private Button btnDelete;
        private Button btnSave;
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
        private Button btnNewTransactionLine;
        private Label label1;
        private Label lbTransAndTransactionLines;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}
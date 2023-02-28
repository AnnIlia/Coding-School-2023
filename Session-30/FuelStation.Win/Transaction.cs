using FuelStation.Enums;
using FuelStation.Model.Enums;
using FuelStation.Web.Client.Pages;
using FuelStation.Web.Shared.Item;
using FuelStation.Web.Shared.Transaction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Τhis is a piece of code not complete.
//It doesn't throw an error but it's not efficient at the moment.
//First it needs to correct DataSource (line 59) - to load the dummy data from the database.
namespace FuelStation.Win
{
    public partial class Transaction : Form
    {
        private readonly HttpClient httpClient = new HttpClient(new HttpClientHandler())
        {
            BaseAddress = new Uri("https://localhost:7102")
        };
        
        private List<TransactionListDto> transactionList = new();

        public Transaction()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            GridTransaction.AutoGenerateColumns = false; 
            SetControlProperties();
        }

        private async Task SetControlProperties()
        {

            transactionList = await httpClient.GetFromJsonAsync<List<TransactionListDto>>("Transactions");
            bsTransactions.DataSource = transactionList;
            GridTransaction.DataSource = bsTransactions;
            
            DataGridViewComboBoxColumn PayType = GridTransaction.Columns["PaymentMethod"] as DataGridViewComboBoxColumn;
            PayType.DataSource = Enum.GetValues(typeof(PaymentMethod));

        }

        private void lbTransaction_Click(object sender, EventArgs e)
        {

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }

        private void TransactionLines_Click(object sender, EventArgs e)
        {
            var transactionLinesForm = new TransactionLines();
            transactionLinesForm.ShowDialog();
            this.Close();
        }
    }
}

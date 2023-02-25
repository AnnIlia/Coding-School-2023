using FuelStation.Model.Enums;
using FuelStation.Web.Client.Pages;
using FuelStation.Web.Shared.Customer;
using FuelStation.Web.Shared.Item;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace FuelStation.Win
{
    public partial class Customers : Form
    {

        private readonly HttpClient httpClient = new HttpClient(new HttpClientHandler())
        {
            BaseAddress = new Uri("https://localhost:7102")
        };
        private List<CustomerListDto> customerList = new();
        public Customers()
        {
            InitializeComponent();
        }


        private async void Customers_Load(object sender, EventArgs e)
        {
            GridCustomers.AutoGenerateColumns = false; //gia ta dipla columns
            customerList = await httpClient.GetFromJsonAsync<List<CustomerListDto>>("customer");
            bsCustomers.DataSource = customerList; //vazo itemList
            GridCustomers.DataSource = bsCustomers; //ti anoigei-deixnei sto grid
            //ItemType.DataSource = Enum.GetNames(typeof(ItemType));
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

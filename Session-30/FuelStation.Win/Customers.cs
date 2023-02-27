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

        private List<CustomerListDto> customerList = new List<CustomerListDto>();
        private readonly HttpClient _client;
        public Customers()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:7102");
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            _ = SetControlProperties();
        }

        private void grdCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async Task SetControlProperties()
        {
            customerList = await _client.GetFromJsonAsync<List<CustomerListDto>>("customer");
            GridCustomers.AutoGenerateColumns = false;
            if (customerList != null)
            {
                bsCustomers.DataSource = customerList;
                GridCustomers.DataSource = bsCustomers;
            }
        }

        private async Task OnSave()
        {
            HttpResponseMessage response = null;
            CustomerListDto customer = (CustomerListDto)bsCustomers.Current;
            if (customer.Id is null)
            {
               CustomerCreateDto newCust = new CustomerCreateDto() { Name = customer.Name, Surname = customer.Surname, CardNumber = customer.CardNumber };
                response = await _client.PostAsJsonAsync("customer", newCust);
            }
            else
            {
                response = await _client.PutAsJsonAsync("customer", customer);
            }

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("New Customer saved successfully!");
            }
            else
            {
                MessageBox.Show("Error saving Customer.");
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _ = SetControlProperties();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _ = OnDelete();
        }

        private async Task OnDelete()
        {
            HttpResponseMessage response = null;
            CustomerListDto customer = (CustomerListDto)bsCustomers.Current;
            if (customer.Id != null)
            {
                response = await _client.DeleteAsync($"customer/{customer.Id}");
                if (response.IsSuccessStatusCode)
                {
                    bsCustomers.RemoveCurrent();
                    MessageBox.Show("Customer deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Error deleting customer.");
                }
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _ = SetControlProperties();
        }

        private async void GridCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerListDto customer = bsCustomers.Current as CustomerListDto;
            var response = await _client.PostAsJsonAsync("customer", customer);
            response.EnsureSuccessStatusCode();
            MessageBox.Show("Customer Created!");
            SetControlProperties();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _ = OnSave();
            _ = SetControlProperties();
        }
    }
}

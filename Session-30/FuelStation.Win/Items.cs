using FuelStation.Model.Enums;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FuelStation.Win
{
    public partial class Items : Form
    {
       
        private readonly HttpClient httpClient = new HttpClient(new HttpClientHandler())
        {
            BaseAddress = new Uri("https://localhost:7102")
        };
        private List<ItemDto> itemList = new();
        public Items()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private async void Items_Load(object sender, EventArgs e)
        {
            GridItems.AutoGenerateColumns = false; //gia ta dipla columns
            itemList = await httpClient.GetFromJsonAsync<List<ItemDto>>("item");
            bsItems.DataSource = itemList; //vazo itemList
            GridItems.DataSource = bsItems; //ti anoigei-deixnei sto grid
            ItemType.DataSource = Enum.GetNames(typeof(ItemType));
           

        }
        private async Task SetControlProperties()
        {

            itemList = await httpClient.GetFromJsonAsync<List<ItemDto>>("item");
            bsItems.DataSource = itemList; 
            GridItems.DataSource = bsItems; 
            ItemType.DataSource = Enum.GetNames(typeof(ItemType)); //comboBox1.DataSource = Enum.GetValues(typeof MyValues);



        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            ItemDto item = bsItems.Current as ItemDto;
            var response = await httpClient.PostAsJsonAsync("item", item);
            response.EnsureSuccessStatusCode();
            MessageBox.Show("Item Created!");
            SetControlProperties();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            ItemDto item = bsItems.Current as ItemDto;
            var response = await httpClient.DeleteAsync($"item/ {item.Id}");
            response.EnsureSuccessStatusCode();
            MessageBox.Show("Selected Item Deleted!");
            SetControlProperties();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SetControlProperties();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

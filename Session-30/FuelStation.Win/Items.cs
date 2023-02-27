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
using System.Text.RegularExpressions;
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

        private void GridItems_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private async void Items_Load(object sender, EventArgs e)
        {
            GridItems.AutoGenerateColumns = false; //gia ta dipla columns
            SetControlProperties();
        }
        private async Task SetControlProperties()
        {

            itemList = await httpClient.GetFromJsonAsync<List<ItemDto>>("item");
            bsItems.DataSource = itemList; 
            GridItems.DataSource = bsItems;
            // ItemType.DataSource = Enum.GetNames(typeof(ItemType)); //comboBox1.DataSource = Enum.GetValues(typeof MyValues);
            
             DataGridViewComboBoxColumn ItemItemType = GridItems.Columns["ItemType"] as DataGridViewComboBoxColumn; 
            ItemType.DataSource = Enum.GetValues(typeof(ItemType));
            
            this.GridItems.Columns["ItemCost"].DefaultCellStyle.Format = "0.00##";
        }
       
        private async void btnSave_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = null;
            ItemDto item = (ItemDto)bsItems.Current;
            if (item.Id == 0)
            {
                ItemCreateDto itemCreate = new ItemCreateDto
                {
                    Code = item.Code,
                    Description = item.Description,
                    ItemType = item.ItemType,
                    Price = item.Price,
                    Cost = item.Cost
                };
                response = await httpClient.PostAsJsonAsync("item", itemCreate);
            }
            else
            {
                ItemDto itemEdit = new ItemDto
                {
                    Id = item.Id,
                    Code = item.Code,
                    Description = item.Description,
                    ItemType = item.ItemType,
                    Price = item.Price,
                    Cost = item.Cost
                };
                response = await httpClient.PutAsJsonAsync("item", itemEdit);
            }
            if (response.IsSuccessStatusCode)
            { MessageBox.Show("New Item saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            { MessageBox.Show("Error saving Item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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

        private async void GridItems_Validating(object sender, CancelEventArgs e)
        {
        
        }
    }
}

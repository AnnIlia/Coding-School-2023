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
        }

        private async void Items_Load(object sender, EventArgs e)
        {
            GridItems.AutoGenerateColumns = false; //gia ta dipla columns
            itemList = await httpClient.GetFromJsonAsync<List<ItemDto>>("item");
            bsItems.DataSource = itemList; //vazo itemList
            GridItems.DataSource = bsItems; //ti anoigei-deixnei sto grid
           ItemType.DataSource = Enum.GetNames(typeof(ItemType));
           // ItemType.Items = Enum.GetNames(typeof(ItemType));

        }



    }
}

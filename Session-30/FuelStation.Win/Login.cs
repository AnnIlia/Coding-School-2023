using FuelStation.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation.Win
{
    public partial class Login : Form
    {
        private EmployeeType _role;


        public Login()
        {
            InitializeComponent();

        }

        private void btnLgCashier_Click(object sender, EventArgs e)
        {

        }

        private void btnLgStaff_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLgManager_Click(object sender, EventArgs e)
        {
            _role = EmployeeType.Manager;
            Menu menu = new Menu(_role);
            menu.Show();

            this.Hide();
        }
    }
}

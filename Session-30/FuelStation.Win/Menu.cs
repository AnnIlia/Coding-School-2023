using FuelStation.Enums;
using FuelStation.Model;
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
    public partial class Menu : Form
    {
        private EmployeeType _role;
        public Menu(EmployeeType role)
        {

            _role = role;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            RoleAccessView();
        }

        private void RoleAccessView()
        {
            switch (_role)
            {
                case EmployeeType.Manager:

                    btnMnCustomers.Visible = true;
                    btnMnTransactions.Visible = true;
                    btnMnItems.Visible = true;

                    break;
                case EmployeeType.Cashier:

                    btnMnCustomers.Visible = false;
                    btnMnTransactions.Visible = true;
                    btnMnItems.Visible = true;

                    break;
                case EmployeeType.Staff:

                    btnMnCustomers.Visible = false;
                    btnMnTransactions.Visible = false;
                    btnMnItems.Visible = true;

                    break;
                default:
                    break;
            }
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {

        }
        private void btnMnCustomers_Click(object sender, EventArgs e)
        {
            var customersForm = new Customers();
            customersForm.ShowDialog();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();

        }

        private void btnMnTransactions_Click(object sender, EventArgs e)
        {
            var trasForm = new Transaction();
            trasForm.ShowDialog();
            this.Close();

        }

        private void btnMnItems_Click(object sender, EventArgs e)
        {
            var itemFrom = new Items();
            itemFrom.ShowDialog();
            this.Close();
        }
    }
}



 






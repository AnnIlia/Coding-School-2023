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
    public partial class Menu : Form
    {
        private EmployeeType _role;
        public Menu(EmployeeType role)
        {
            InitializeComponent();
            _role = role;
            RoleBasedView();
        }
        private void btnMnCustomers_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FuelStation fuel = new FuelStation();
            fuel.Show();
            this.Close();
        }

        private void btnMnTransactions_Click(object sender, EventArgs e)
        {
            var trasForm = new TransactionLogin();
            trasForm.ShowDialog();
            this.Close();
        }

        private void btnMnItems_Click(object sender, EventArgs e)
        {
            var itemFrom = new ItemForm();
            itemFrom.ShowDialog();
            this.Close();
        }
    }


    private void RoleBasedView()
    {
        switch (_role)
        {
            case EmployeeType.Manager:

                btnCustomers.Visible = true;
                btnTransactions.Visible = true;
                btnItems.Visible = true;

                break;
            case EmployeeType.Cashier:

                btnCustomers.Visible = false;
                btnTransactions.Visible = true;
                btnItems.Visible = true;

                break;
            case EmployeeType.Staff:

                btnCustomers.Visible = false;
                btnTransactions.Visible = false;
                btnItems.Visible = true;

                break;
            default:
                break;
        }
    }












}






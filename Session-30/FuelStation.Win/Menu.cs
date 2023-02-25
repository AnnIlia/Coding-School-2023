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
            
        }
        private void btnMnCustomers_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
      
        }

        private void btnMnTransactions_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnMnItems_Click(object sender, EventArgs e)
        {
           
        }
    }


    private void RoleBasedView()
    {
        switch (_role)
        {
            case EmployeeType.Manager:

               

                break;
            case EmployeeType.Cashier:

               

                break;
            case EmployeeType.Staff:

                

                break;
            default:
                break;
        }
    }












}






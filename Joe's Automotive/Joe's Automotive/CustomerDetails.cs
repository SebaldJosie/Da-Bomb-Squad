using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joe_s_Automotive
{
    public partial class CustomerDetails : Form
    {
        public CustomerDetails()
        {
            InitializeComponent();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            //Return to the Customer form
            this.Close();
        }

        private void viewVehicleButton_Click(object sender, EventArgs e)
        {
            //View the customer's vehicle
            VehicleDetails myVehicleDetails = new VehicleDetails();
            myVehicleDetails.Show();
        }

        private void viewInvoicesButton_Click(object sender, EventArgs e)
        {
            //View the customer's invoice
            NewInvoice myNewInvoice = new NewInvoice();
            myNewInvoice.Show();
        }
    }
}

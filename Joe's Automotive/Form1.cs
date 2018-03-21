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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            //Open the Customer form
            Customer myCustomerForm = new Customer();
            myCustomerForm.Show();
        }

        private void partsButton_Click(object sender, EventArgs e)
        {
            //Open the Parts form
            Parts myParts = new Parts();

            myParts.Show();
        }

        private void vehicleButton_Click(object sender, EventArgs e)
        {
            //Open the Vehicle form
            Vehicle myVehicle = new Vehicle();

            myVehicle.Show();
        }

        private void invoicesButton_Click(object sender, EventArgs e)
        {
            //Open the Invoices form
            Invoices myInvoices = new Invoices();

            myInvoices.Show();
        }
    }
}

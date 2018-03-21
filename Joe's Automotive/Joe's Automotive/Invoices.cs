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
    public partial class Invoices : Form
    {
        public Invoices()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            //Create a new invoice
            NewInvoice myNewInvoice = new NewInvoice();
            myNewInvoice.Show();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            //Return to the main form
            this.Close();
        }
    }
}

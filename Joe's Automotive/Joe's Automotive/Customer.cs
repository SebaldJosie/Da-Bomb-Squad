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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Invoices myInvoices = new Invoices();

            myInvoices.Show();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            //Return to the main form
            this.Close();
        }


        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.partsDataSet);

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'partsDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.partsDataSet.Customers);

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorCountItem_Click(object sender, EventArgs e)
        {

        }
    }
}

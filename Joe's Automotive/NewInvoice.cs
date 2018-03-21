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
    public partial class NewInvoice : Form
    {
        string output;
        string tax;
        string laborcosts;
        public NewInvoice()
        {
            InitializeComponent();

            tax = taxTextBox.Text;
            laborcosts = laborCostsTextBox.Text;
            output = tax + laborcosts;

            if (yesRadioButton.Checked)
            {
                output = output + 14;
            }
            else
            {
                totalLabel.Text = output;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //Save the invoice's information
            totalLabel.Text = output;
        }
        private void doneButton_Click(object sender, EventArgs e)
        {
            //Close the invoice
            this.Close();
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}

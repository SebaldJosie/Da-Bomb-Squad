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
    public partial class Parts : Form
    {
        public Parts()
        {
            InitializeComponent();
        }

        private void partsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.partsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.partsDataSet);

        }

        private void Parts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'partsDataSet1.Parts' table. You can move, or remove it, as needed.
            this.partsTableAdapter1.Fill(this.partsDataSet1.Parts);
            // TODO: This line of code loads data into the 'partsDataSet.Parts1' table. You can move, or remove it, as needed.
            this.parts1TableAdapter.Fill(this.partsDataSet.Parts1);
            // TODO: This line of code loads data into the 'partsDataSet.Parts' table. You can move, or remove it, as needed.

        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            //Return to the main form
            this.Close();
        }

        private void partsBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Data_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TXB_First_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PBX_Logo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tulpanvagen 8 Almhult\n343 34\nSweden\nContact List 1.0\nWritten by Spencer Burton");
        }

        private void contactsInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contactsInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.ContactsInfo' table. You can move, or remove it, as needed.
            this.contactsInfoTableAdapter.Fill(this.database1DataSet.ContactsInfo);

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upr1.View
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'upr1DataSet.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.upr1DataSet.Admin);


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void adminUsersBindingSource_CurrentChanged(object sender, EventArgs e)
        {
                    }

        private void upr1DataSetBindingSource1_CurrentChanged(object sender, EventArgs e)
        {
                    }

        private void adminBindingSource_CurrentChanged(object sender, EventArgs e)
        {
                    }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            upr1DataSet.Admin.AddAdminRow(textBox1.Text, dateTimePicker1.Value, comboBox1.Text);
        }
    }
}

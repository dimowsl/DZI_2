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
    public partial class Vhod : UserControl
    {
        public Vhod()
        {
            InitializeComponent();
        }

        private void Vhod_Load(object sender, EventArgs e)
        {

        }
        public static string username1 = "dimow";
        public static string password1 = "dimow";
        private void button2_Click(object sender, EventArgs e)
        {
            if (username1.Contains(textBox1.Text) && password1.Contains(textBox2.Text))
            {
                this.Hide();
                var form2P = new Admin();
                form2P.FormClosed += (s, args) => this.Close();
                form2P.Show();
            }
            else
            {
                MessageBox.Show("Greshni danni");
            }
        }

        private void Close()
        {
            throw new NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

        }
    }
}

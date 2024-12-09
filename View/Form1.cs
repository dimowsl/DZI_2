using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using upr1.View;

namespace upr1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            vhod1.Hide();
            cenorazpis1.Hide();
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var uslugi = new Uslugi();
            uslugi.Closed += (s, args) => this.Close();
            uslugi.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void входToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vhod1.Show();
            vhod1.BringToFront();
            cenorazpis1.Hide();
            
        }

        private void началоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vhod1.Hide();
            cenorazpis1.Hide();
        }

        private void цениToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cenorazpis1.Show();
            cenorazpis1.BringToFront();
            vhod1.Hide();
        }
    }
}

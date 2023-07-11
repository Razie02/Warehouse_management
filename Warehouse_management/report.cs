using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse_management
{
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            main_page m = new main_page();
            m.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            enter en = new enter();
            en.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            get_out g = new get_out();
            g.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            @new n = new @new();
            n.Show();
            this.Hide();
        }
    }
}

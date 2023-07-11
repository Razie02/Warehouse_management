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
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
            
        
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            log_in log = new log_in();
            log.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

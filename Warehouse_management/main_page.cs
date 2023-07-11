using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse_management
{
    public partial class main_page : Form
    {
        public main_page()
        {
            InitializeComponent();

        }

        private void main_page_Load(object sender, EventArgs e)
        {
            int x = 0;
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\برنامه نویسی\پروژه\Warehouse_management\Warehouse_management\Database1.mdf;Integrated Security=True");
            sc.Open();
            string query = "SELECT * FROM commodity WHERE remained!='" + x.ToString() + "'";
            SqlCommand command = new SqlCommand(query, sc);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader["description"].ToString());
            }

            sc.Close();
            {
                int z = 0;
                SqlConnection scc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\برنامه نویسی\پروژه\Warehouse_management\Warehouse_management\Database1.mdf;Integrated Security=True");
                scc.Open();
                string q = "SELECT * FROM commodity WHERE remained='" + z.ToString() + "'";
                SqlCommand commandd = new SqlCommand(q, scc);
                SqlDataReader readerr = commandd.ExecuteReader();

                while (readerr.Read())
                {
                    comboBox2.Items.Add(readerr["description"].ToString());
                }

                scc.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            start s = new start();
            s.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            report r = new report();
            r.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            search s = new search();
            s.Show();
            this.Hide();
        }
    }
    
}

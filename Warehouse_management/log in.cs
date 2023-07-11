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
    public partial class log_in : Form
    {
        public log_in()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            start s = new start();
            s.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                main_page m = new main_page();

                string user = textBox1.Text;
                string pass = textBox2.Text;
                SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\برنامه نویسی\پروژه\Warehouse_management\Warehouse_management\Database1.mdf;Integrated Security=True");
                sc.Open();
                SqlCommand comm = new SqlCommand("SELECT password FROM users WHERE username='" + user + "'", sc);
                SqlDataReader reader = comm.ExecuteReader();
                reader.Read();
                string pa = reader["password"].ToString();
                if (pass == pa)
                {
                    m.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("رمز وارد شده صحیح نمی باشد","Error");
                    sc.Close();
                }
            }

            catch (Exception)
            {
                MessageBox.Show("نام کاربری وارد شده موجود نمی باشد","Error");
            }
        }
    }
}

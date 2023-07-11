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
    public partial class @new : Form
    {
        public @new()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string c = textBox1.Text;
            string na = textBox2.Text;
            string nu = textBox3.Text;
            SqlConnection cc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\برنامه نویسی\پروژه\Warehouse_management\Warehouse_management\Database1.mdf;Integrated Security=True");
            cc.Open();
            string query = "INSERT INTO commodity (code,description,incorporate,remained) VALUES (N'" + c + "',N'" + na + "',N'" + nu + "',N'" + nu + "')";
            SqlCommand com = new SqlCommand(query, cc);
            com.ExecuteNonQuery();
            cc.Close();

            if (textBox1.Text == "")
            {
                MessageBox.Show("کد کالا وارد نشده است");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("نام کالا وارد نشده است");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("تعداد کالا وارد نشده است");
            }
            else
            {
                MessageBox.Show("کالای جدید ثبت شد");
                textBox1.Text = textBox2.Text = textBox3.Text ="";
                this.Hide();
                report r = new report();
                r.Show();
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            report r = new report();
            r.Show();
            this.Hide();
        }
    }
}

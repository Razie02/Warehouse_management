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
    public partial class get_out : Form
    {
        public get_out()
        {
            InitializeComponent();
        }
        private void get_out_Load(object sender, EventArgs e)
        {

            {
                int x = 0;
                SqlConnection scc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\برنامه نویسی\پروژه\Warehouse_management\Warehouse_management\Database1.mdf;Integrated Security=True");
                scc.Open();
                string q = "SELECT * FROM commodity WHERE remained!='" + x.ToString() + "'";
                SqlCommand commandd = new SqlCommand(q, scc);
                SqlDataReader readerr = commandd.ExecuteReader();

                while (readerr.Read())
                {
                    comboBox1.Items.Add(readerr["description"].ToString());

                }
                scc.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("نام کالا وارد نشده است");
                }
                else
                { 
                    string name = comboBox1.Text;
                SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\برنامه نویسی\پروژه\Warehouse_management\Warehouse_management\Database1.mdf;Integrated Security=True");
                sc.Open();
                string qu = "SELECT remained FROM commodity WHERE description=N'" + name + "'";
                SqlCommand com = new SqlCommand(qu, sc);
                SqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    MessageBox.Show(reader["remained"].ToString(), " :تعداد کالا");
                }
                sc.Close();
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("نام کالا وارد نشده است");
                }
                else
                {
                    string name = comboBox1.Text;
                    string num = textBox1.Text;
                    SqlConnection sss = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\برنامه نویسی\پروژه\Warehouse_management\Warehouse_management\Database1.mdf;Integrated Security=True");
                    sss.Open();
                    string query = "UPDATE commodity SET remained= remained -'"+ num + "',issued=issued +'" + num + "'  WHERE description=N'" + name + "'";
                    SqlCommand comman = new SqlCommand(query, sss);
                    comman.ExecuteNonQuery();

                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("تعداد کالا وارد نشده است");
                    }
                    else
                    {
                        MessageBox.Show("تغییر اطلاعات با موفقیت انجام شد");
                        textBox1.Text = "";
                        this.Hide();
                        report r = new report();
                        r.Show();
                    }
                    sss.Close();
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            report r = new report();
            r.Show();
            this.Hide();
        }
    }
}

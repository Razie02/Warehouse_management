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
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("کالایی انتخاب نشده است");
            }
            else
            {
                string name = comboBox1.Text;
                SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\برنامه نویسی\پروژه\Warehouse_management\Warehouse_management\Database1.mdf;Integrated Security=True");
                sc.Open();
                SqlCommand comm = new SqlCommand("SELECT code FROM commodity WHERE description=N'" + name + "'", sc);
                SqlDataReader reader = comm.ExecuteReader();
                reader.Read();
                textBox1.Text = reader["code"].ToString();
                sc.Close();


                SqlConnection sc1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\برنامه نویسی\پروژه\Warehouse_management\Warehouse_management\Database1.mdf;Integrated Security=True");
                sc1.Open();
                SqlCommand comm1 = new SqlCommand("SELECT description FROM commodity WHERE description=N'" + name + "'", sc1);
                SqlDataReader reader1 = comm1.ExecuteReader();
                reader1.Read();
                textBox2.Text = reader1["description"].ToString();
                sc1.Close();

                SqlConnection sc2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\برنامه نویسی\پروژه\Warehouse_management\Warehouse_management\Database1.mdf;Integrated Security=True");
                sc2.Open();
                SqlCommand comm2 = new SqlCommand("SELECT incorporate FROM commodity WHERE description=N'" + name + "'", sc2);
                SqlDataReader reader2 = comm2.ExecuteReader();
                reader2.Read();
                textBox3.Text = reader2["incorporate"].ToString();
                sc2.Close();

                SqlConnection sc3 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\برنامه نویسی\پروژه\Warehouse_management\Warehouse_management\Database1.mdf;Integrated Security=True");
                sc3.Open();
                SqlCommand comm3 = new SqlCommand("SELECT issued FROM commodity WHERE description=N'" + name + "'", sc3);
                SqlDataReader reader3 = comm3.ExecuteReader();
                reader3.Read();
                textBox4.Text = reader3["issued"].ToString();
                sc3.Close();

                SqlConnection sc4 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\برنامه نویسی\پروژه\Warehouse_management\Warehouse_management\Database1.mdf;Integrated Security=True");
                sc4.Open();
                SqlCommand comm4 = new SqlCommand("SELECT remained FROM commodity WHERE description=N'" + name + "'", sc4);
                SqlDataReader reader4 = comm4.ExecuteReader();
                reader4.Read();
                textBox5.Text = reader4["remained"].ToString();
                sc4.Close();
            }
        }

        private void search_Load(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\برنامه نویسی\پروژه\Warehouse_management\Warehouse_management\Database1.mdf;Integrated Security=True");
            sc.Open();
            string query = "SELECT * FROM commodity ";
            SqlCommand command = new SqlCommand(query, sc);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader["description"].ToString());
            }

            sc.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text ="";
            main_page m = new main_page();
            m.Show();
            this.Hide();
            
        }
    }
}

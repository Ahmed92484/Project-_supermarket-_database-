using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Supermarket
{
    public partial class Delivery : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-6830EEG;Initial Catalog=Supermarket;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt1;
        DataTable dt = new DataTable();
        public Delivery()
        {
            InitializeComponent();
            adapt1 = new SqlDataAdapter("select *  from C_Order", con);
            adapt1.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("enter customer ID");
            }
            else
            {
                con.Open();
                cmd = new SqlCommand("select Username,Name,Phone,Address,Email from customer where Username= '" + textBox1.Text + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    textBox1.Text = dr.GetValue(0).ToString();
                    textBox2.Text = dr.GetValue(1).ToString();
                    textBox3.Text = dr.GetValue(2).ToString();
                    textBox4.Text = dr.GetValue(3).ToString();
                    textBox5.Text = dr.GetValue(4).ToString();
                }
                con.Close();
            }
            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            main.L.Show();
        }

        private void Delivery_Load(object sender, EventArgs e)
        {

        }
    }

       
 }


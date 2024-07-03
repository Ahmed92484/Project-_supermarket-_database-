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
    public partial class cart : Form
    {


        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6830EEG;Initial Catalog=Supermarket;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        DataTable dt = new DataTable();
        public cart()
        {
            InitializeComponent();
            adapt = new SqlDataAdapter("select *  from cart ", con);  
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Open();
            cmd = new SqlCommand("select sum(Price) from cart where C_ID ='" + Log_in.username + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            { textBox2.Text = dr.GetValue(0).ToString(); }
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button7_Click(object sender, EventArgs e)
        {


            if (textBox1.Text != "")
            {
                if (!char.IsNumber(textBox1.Text[0]))
                {

                    MessageBox.Show("Sorry You Should Enter Prodct ID If You Want Delete It ");

                }
                else
                {
                    cmd = new SqlCommand("delete cart  where P_ID=" + textBox1.Text + ";", con);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record deleted Successfully");
                }

            }
            else if (textBox1.Text != " ")
            {

                MessageBox.Show("Sorry You Should Enter ID_Order If You Want Delete It ");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            RadioButton rb = null;

            if (radioButton1.Checked == true)
            {
                rb = radioButton1;
                MessageBox.Show(" ok you will be pay cash,Payment Confirmation Successfully ");
            }
            else if (radioButton2.Checked == true)
            {
                rb = radioButton2;
                MessageBox.Show(" ok you will be pay Credit Card,Payment Confirmation Successfully");
            }
            else if (radioButton2.Checked == false & radioButton1.Checked == false)
            {
                MessageBox.Show(" sorry you should choise credit or card");
                if (radioButton1.Checked == true)
                {
                    rb = radioButton1;
                    MessageBox.Show(" ok you will be pay cash,Payment Confirmation Successfully ");

                }
                else if (radioButton2.Checked == true)
                {
                    rb = radioButton2;
                    MessageBox.Show(" ok you will be pay Credit Card,Payment Confirmation Successfully");

                }

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Profile Pr = new Profile();
            Pr.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            order_history O = new order_history();
            O.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Log_in.H.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Product p = new Product();
            p.Show();
            this.Hide();
        }

        private void cart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supermarketDataSet.cart' table. You can move, or remove it, as needed.
            this.cartTableAdapter.Fill(this.supermarketDataSet.cart);
            // TODO: This line of code loads data into the 'supermarketDataSet.cart' table. You can move, or remove it, as needed.
            this.cartTableAdapter.Fill(this.supermarketDataSet.cart);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}


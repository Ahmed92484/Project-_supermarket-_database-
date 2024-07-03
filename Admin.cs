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
    public partial class Admin : Form
  
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-6830EEG;Initial Catalog=Supermarket;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        public Admin()
        {
            InitializeComponent();
        }

        private void cleardata()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
           

        }

        private void dispalydata()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("Select * from Product", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                cmd = new SqlCommand("insert into Product  values(" + textBox1.Text + ", '" + textBox2.Text + "',  + " + textBox3.Text + ", '" + textBox4.Text + "', +  " + textBox5.Text + " ,)", con);



                if (!char.IsNumber(textBox1.Text[0]) || !char.IsNumber(textBox3.Text[0]) || !char.IsNumber(textBox5.Text[0]) || char.IsNumber(textBox2.Text[0]) || char.IsNumber(textBox4.Text[0]) )
                {
                    MessageBox.Show("Invalid login ");
                }

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("record inserted sucessfully");

                dispalydata();
                cleardata();
            }

            else if (textBox1.Text == "")
            {


                MessageBox.Show("please,enter product_id ");
            }


            else if (textBox2.Text == "")
            {


                MessageBox.Show("please,enter product_name ");
            }

            else if (textBox3.Text == "")
            {


                MessageBox.Show("please,enter price ");
            }

            else if (textBox4.Text == "")
            {


                MessageBox.Show("please,enter infoaboutproduct ");
            }

            else if (textBox5.Text == "")
            {


                MessageBox.Show("please,enter quantity ");
            }
  

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                cmd = new SqlCommand("update Product set Name='" + textBox2.Text + "' where ID ='" + textBox1.Text + "'", con);
                if (!char.IsNumber(textBox1.Text[0]))
                {
                    MessageBox.Show("Invalid login ");

                }
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("record updated sucessfully");
                dispalydata();
                cleardata();
            }
            else if (textBox1.Text == "")
            {

                MessageBox.Show("please,enter product_id ");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("please,enter product_name ");

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                cmd = new SqlCommand("delete Product where ID='" + textBox1.Text + "'", con);

                if (!char.IsNumber(textBox1.Text[0]))
                {
                    MessageBox.Show("invalid message");
                }

                else if (textBox1.Text == "")
                {
                    MessageBox.Show("please, enter product_id");
                }

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("record deleted sucessfully");
                dispalydata();
                cleardata();
            }
        }

        private void admin_Load(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            main.L.Show();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Admin_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supermarketDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.supermarketDataSet.Product);

        }
    }
}

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
    public partial class Product : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-6830EEG;Initial Catalog=Supermarket;Integrated Security=True");
        SqlCommand cmd;
        public Product()
        {
         InitializeComponent();
        }

        int cont = 1, P;

        private void button6_Click(object sender, EventArgs e)
            {
            
           if (cont > 1)
            {
                P = cont * int.Parse( label2.Text);
                cmd = new SqlCommand("update cart set Qantity=" + cont + " where C_ID ='" + Log_in.username + "' And P_ID ='"+ button6+ "' ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Product Added to Cart successfully");
                cont += 1;
                
            }
            else if(cont ==1)
            {
                cmd = new SqlCommand("insert into Cart  values('" + Log_in.username + "' , '" + button6 + "'," +cont+ ","+cont+") ", con);
                /*con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                //cont += 1;*/
               MessageBox.Show("Product Added to Cart successfully");
            }
              

            }

        private void button4_Click(object sender, EventArgs e)
        {
              Log_in.H.Show();
                this.Hide();
               
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Product Added to Cart successfully");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Product Added to Cart successfully");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Product Added to Cart successfully");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Product Added to Cart successfully");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Product Added to Cart successfully");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Product Added to Cart successfully");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Product Added to Cart successfully");
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Profile Pr = new Profile();
            Pr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            order_history O = new order_history();
            O.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Log_in.H.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cart C = new cart();
            C.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class Log_in : Form
    {
        public static Home H = new Home();
        public static String username;
        public Log_in()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            button4.BringToFront();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '\0';
            button5.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
             username = textBox1.Text;
            String pass = textBox2.Text;
            if (username == "" || pass == "")
            {
                MessageBox.Show("Please Enter username and password");

            }
            else if (main.User == "Customer")
            {/*   con.Open();
                    cmd = new SqlCommand("select Username,Password from customer where Username= '" + textBox1.Text + "'", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    username = dr.GetValue(0).ToString();
                    pass = dr.GetValue(1).ToString();
                }
                
                if (username == textBox1.ToString() && pass == textBox2.ToString())
                {
                    con.Close();
                    H.Show();
                    this.Close();
                }*/
                if ((username == "nada" && pass == "0000" )|| (username == "ahmed"&& pass == "0101"))
                {
                    H.Show();
                    this.Hide();

                }

                else
                {
                    MessageBox.Show("Invalid Login");
                }
            }
            else if (main.User == "Admin")
            {
                if (username == "admin" && pass == "1111")
                {
                    Admin A = new Admin();
                    A.Show();
                this.Hide();

                }

                else
                {
                    MessageBox.Show("Invalid Login");
                }
            }
            else if (main.User == "Delivery")
            {
                if (username == "delivery" && pass == "2222")
                {
                    Delivery D = new Delivery();
                    D.Show();
                    this.Hide();

                }

                else
                {
                    MessageBox.Show("Invalid Login");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            start.M.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            start.M.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (main.User == "Customer")
            {
                Create_account C_A = new Create_account();
                C_A.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("create Account for Customer only");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Log_in_Load(object sender, EventArgs e)
        {

        }
    }
}

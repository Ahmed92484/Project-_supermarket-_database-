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
    public partial class Profile : Form
    {
        SqlConnection con= new SqlConnection("Data Source=DESKTOP-6830EEG;Initial Catalog=Supermarket;Integrated Security=True");
        SqlCommand cmd;
        public Profile()
        {
            InitializeComponent();
            con.Open();
            cmd = new SqlCommand("select * from customer where Username= '" + Log_in.username + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox1.Text = dr.GetValue(0).ToString();
                textBox2.Text = dr.GetValue(1).ToString();
                textBox3.Text = dr.GetValue(2).ToString();
                textBox4.Text = dr.GetValue(3).ToString();
                textBox5.Text = dr.GetValue(4).ToString();
                textBox6.Text = dr.GetValue(5).ToString();
            }
            con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Log_in.H.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Log_in.H.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            main.L.Show();
        }
    }
}

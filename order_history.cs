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
    public partial class order_history : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-6830EEG;Initial Catalog=Supermarket;Integrated Security=True");
        SqlDataAdapter Da;
        DataTable Dt = new DataTable();
        SqlDataAdapter Da1;
        DataTable Dt1 = new DataTable();
       
        public order_history()
        {
            InitializeComponent();
            Da = new SqlDataAdapter("select ID,Date,total_Price from C_Order where cstomer# ='" + Log_in.username + "'", con);
            Da.Fill(Dt);
            data_set();
        }
        public void data_set()
        {
            
            dataGridView1.DataSource = Dt;
        }

        private void order_history_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supermarketDataSet.C_Order' table. You can move, or remove it, as needed.
            this.c_OrderTableAdapter.Fill(this.supermarketDataSet.C_Order);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Da1 = new SqlDataAdapter("select  ID,Date,total_Price from C_Order where cstomer# = '" + Log_in.username + "' And Date = '"+textBox1.Text+"'" , con);
            Da1.Fill(Dt1);
            dataGridView1.DataSource = Dt1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Log_in.H.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Log_in.H.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            data_set();
        }
    }
}

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
    public partial class start : Form
    {
        public static main M = new main();

        public start()
        {

            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            M.Show();
            this.Hide();
            timer1.Stop();
        }

      
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void start_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supermarketDataSet.Product' table. You can move, or remove it, as needed.
          

        }
    }
}

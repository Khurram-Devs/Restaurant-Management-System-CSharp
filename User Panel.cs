using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Panel_Assignment
{
    public partial class User_Panel : Form
    {
        public User_Panel()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.Closed += App_Closed;
        }

        private void App_Closed(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
        private void User_Panel_Load(object sender, EventArgs e)
        {
            this.foodlistTableAdapter.Fill(this.foodpandaDataSet2.foodlist);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}

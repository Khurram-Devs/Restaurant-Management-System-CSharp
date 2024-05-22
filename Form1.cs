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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.Closed += App_Closed;
        }


        private void App_Closed(object sender, EventArgs e)
        {
            MessageBox.Show("BYE BYE! COME AGAIN...");
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_Panel user_panel = new User_Panel();
            user_panel.Show();

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Panel admin_panel = new Admin_Panel();
            admin_panel.Show();
        }
    }
}

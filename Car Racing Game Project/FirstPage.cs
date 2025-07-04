using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Racing_Game_Project
{
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Car_Select C = new Car_Select();

            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter player name");
            }
            else
            {
                this.Hide();
                C.Show();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

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
    public partial class Car_Select : Form
    {
        public Car_Select()
        {
            InitializeComponent();
        }
        GamePage Game = new GamePage();

        private void pbbluecar_Click(object sender, EventArgs e)
        {            
            pbbluecar.BackColor = Color.LightCyan;
            pbbluecar.BorderStyle = BorderStyle.Fixed3D;

            pbgraycar.BackColor = Color.Transparent;
            pbgraycar.BorderStyle = BorderStyle.None;

            pbpinkcar.BackColor = Color.Transparent;
            pbpinkcar.BorderStyle = BorderStyle.None;

            pbredcar.BackColor = Color.Transparent;
            pbredcar.BorderStyle = BorderStyle.None;

            pbwhitecar.BackColor = Color.Transparent;
            pbwhitecar.BorderStyle = BorderStyle.None;

            pbyellowcar.BackColor = Color.Transparent;
            pbyellowcar.BorderStyle = BorderStyle.None;

            Game.Car.Image = Properties.Resources._1Blue_car;
        }

        private void pbgraycar_Click(object sender, EventArgs e)
        {
            pbbluecar.BackColor = Color.Transparent;
            pbbluecar.BorderStyle = BorderStyle.None;

            pbgraycar.BackColor = Color.LightCyan;
            pbgraycar.BorderStyle = BorderStyle.Fixed3D;

            pbpinkcar.BackColor = Color.Transparent;
            pbpinkcar.BorderStyle = BorderStyle.None;

            pbredcar.BackColor = Color.Transparent;
            pbredcar.BorderStyle = BorderStyle.None;

            pbwhitecar.BackColor = Color.Transparent;
            pbwhitecar.BorderStyle = BorderStyle.None;

            pbyellowcar.BackColor = Color.Transparent;
            pbyellowcar.BorderStyle = BorderStyle.None;

            Game.Car.Image = Properties.Resources._2Grey_car;
        }

        private void pbpinkcar_Click(object sender, EventArgs e)
        {
            pbbluecar.BackColor = Color.Transparent;
            pbbluecar.BorderStyle = BorderStyle.None;

            pbgraycar.BackColor = Color.Transparent;
            pbgraycar.BorderStyle = BorderStyle.None;

            pbpinkcar.BackColor = Color.LightCyan;
            pbpinkcar.BorderStyle = BorderStyle.Fixed3D;

            pbredcar.BackColor = Color.Transparent;
            pbredcar.BorderStyle = BorderStyle.None;

            pbwhitecar.BackColor = Color.Transparent;
            pbwhitecar.BorderStyle = BorderStyle.None;

            pbyellowcar.BackColor = Color.Transparent;
            pbyellowcar.BorderStyle = BorderStyle.None;

            Game.Car.Image = Properties.Resources._3Pink_car;

        }

        private void pbredcar_Click(object sender, EventArgs e)
        {
            pbbluecar.BackColor = Color.Transparent;
            pbbluecar.BorderStyle = BorderStyle.None;

            pbgraycar.BackColor = Color.Transparent;
            pbgraycar.BorderStyle = BorderStyle.None;

            pbpinkcar.BackColor = Color.Transparent;
            pbpinkcar.BorderStyle = BorderStyle.None;

            pbredcar.BackColor = Color.LightCyan;
            pbredcar.BorderStyle = BorderStyle.Fixed3D;

            pbwhitecar.BackColor = Color.Transparent;
            pbwhitecar.BorderStyle = BorderStyle.None;

            pbyellowcar.BackColor = Color.Transparent;
            pbyellowcar.BorderStyle = BorderStyle.None;

            Game.Car.Image = Properties.Resources._4Red_car;
        }

        private void pbwhitecar_Click(object sender, EventArgs e)
        {
            pbbluecar.BackColor = Color.Transparent;
            pbbluecar.BorderStyle = BorderStyle.None;

            pbgraycar.BackColor = Color.Transparent;
            pbgraycar.BorderStyle = BorderStyle.None;

            pbpinkcar.BackColor = Color.Transparent;
            pbpinkcar.BorderStyle = BorderStyle.None;

            pbredcar.BackColor = Color.Transparent;
            pbredcar.BorderStyle = BorderStyle.None;

            pbwhitecar.BackColor = Color.LightCyan;
            pbwhitecar.BorderStyle = BorderStyle.Fixed3D;

            pbyellowcar.BackColor = Color.Transparent;
            pbyellowcar.BorderStyle = BorderStyle.None;

            Game.Car.Image = Properties.Resources._5White_car;
        }

        private void pbyellowcar_Click(object sender, EventArgs e)
        {
            pbbluecar.BackColor = Color.Transparent;
            pbbluecar.BorderStyle = BorderStyle.None;

            pbgraycar.BackColor = Color.Transparent;
            pbgraycar.BorderStyle = BorderStyle.None;

            pbpinkcar.BackColor = Color.Transparent;
            pbpinkcar.BorderStyle = BorderStyle.None;

            pbredcar.BackColor = Color.Transparent;
            pbredcar.BorderStyle = BorderStyle.None;

            pbwhitecar.BackColor = Color.Transparent;
            pbwhitecar.BorderStyle = BorderStyle.None;

            pbyellowcar.BackColor = Color.LightCyan;
            pbyellowcar.BorderStyle = BorderStyle.Fixed3D;

            Game.Car.Image = Properties.Resources._6Yellow_car;
        }


        private void BtnStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game.Show();
        }
    }
}

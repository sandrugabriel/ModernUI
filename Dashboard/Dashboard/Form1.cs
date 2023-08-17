using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            transparent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void transparent()
        {
            pictureBox7.Parent = pictureBox6;
            pictureBox7.BackColor = Color.Transparent;
            label6.Parent = pictureBox6;
            label6.BackColor = Color.Transparent;
            label7.Parent = pictureBox6;
                label8.Parent = pictureBox6;
            label8.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}

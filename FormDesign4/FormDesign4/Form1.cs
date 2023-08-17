using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDesign4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tranparent(pictureBox2, label6);
            tranparent(pictureBox2, label7);
            tranparent(pictureBox2, label8);
            tranparent(pictureBox2, label9);

            tranparent(pictureBox3, label10);
            tranparent(pictureBox3, label11);
            tranparent(pictureBox3, label12);
            tranparent(pictureBox3, label13);

            tranparent(pictureBox4, label14);
            tranparent(pictureBox4, label15);
            tranparent(pictureBox4, label16);
            tranparent(pictureBox4, label17);

            tranparent(pictureBox5, label18);
            tranparent(pictureBox5, label19);
            tranparent(pictureBox5, label20);
            tranparent(pictureBox5, label21);

        }

        private void tranparent(PictureBox pct, Label lbl)
        {

            var pos = this.PointToScreen(lbl.Location);
            pos = pct.PointToClient(pos);
            lbl.Parent = pct;
            lbl.Location = pos;
            lbl.BackColor = Color.Transparent;


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

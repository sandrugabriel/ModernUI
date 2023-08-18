using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginDesign2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tranparent(pictureBox1,label1);
            tranparent(pictureBox1, label2);
            label5.Parent = bunifuGradientPanel1;
            label5.BackColor = Color.Transparent;

        }


        private void tranparent(PictureBox pct, Label lbl)
        {

            var pos = this.PointToScreen(lbl.Location);
            pos = pct.PointToClient(pos);
            lbl.Parent = pct;
            lbl.Location = pos;
            lbl.BackColor = Color.Transparent;


        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AYAZpaint
{
    public partial class Form1 : Form
    {

        Graphics g;
        int x = -1;
        int y = -1;
        bool move = false;
        Pen pen;
        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            pen = new Pen(Color.Black, 5);

        }

        private void yellow_Click(object sender, EventArgs e)
        {

            pen.Color = Color.Yellow;

            
        }

        private void red_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Red;
        }

        private void grey_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Gray;
        }

        private void blue_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Blue;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            x = e.X;
            y = e.Y;
            move = true;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(move && x!=-1 && y != -1)
            {

                g.DrawLine(pen, new Point(x, y), e.Location);
                
                x = e.X;
                y = e.Y;

            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            x = -1;
            y = -1;
            move = false;
        }

        private void bgblack_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Black;
        }

        private void bgwight_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.White;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Deathly_Hallows_DIY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            var p = sender as Panel;
            var g = e.Graphics;
            int a = 3*Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
            
            Pen pen = new Pen(Color.LightGreen);
            pen.Width = 2;

            Point[] punkty = new Point[6];

            punkty[0] = new Point(a/2+1,1);
            punkty[1] = new Point((int)(a/2-a*Math.Sqrt(3)/6+1),(int)(a*Math.Sqrt(3)/6+1));
            punkty[2] = new Point(1,(int)(a*Math.Sqrt(3)/2+1));
            punkty[3] = new Point(a/2+1,(int)(a*Math.Sqrt(3)/2+1));
            punkty[4] = new Point((int)(a/2+a*Math.Sqrt(3)/6+1),(int)(a * Math.Sqrt(3) / 2 + 1));
            punkty[5] = new Point(a+1,(int)(a*Math.Sqrt(3)/2+1));

            g.DrawLine(pen, punkty[0], punkty[2]);
            g.DrawLine(pen, punkty[2], punkty[5]);
            g.DrawLine(pen, punkty[5], punkty[0]);

            g.DrawLine(pen, punkty[0], punkty[3]);

            g.DrawEllipse(pen, punkty[1].X, punkty[1].Y, punkty[4].X - punkty[1].X, punkty[4].Y - punkty[1].Y);

            pen = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Refresh();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // метод для прорисовки снеговика
            Graphics g = e.Graphics;
            Pen p = new Pen(Brushes.Black, 5);
            g.DrawLine(p, 110, 265, 145, 220); // ветки
            g.DrawLine(p, 260, 265, 225, 220);
            g.DrawLine(p, 100, 278, 110, 265);
            g.DrawLine(p, 97, 258, 110, 265);
            g.DrawLine(p, 120, 275, 110, 265);
            g.DrawLine(p, 250, 275, 260, 265);
            g.DrawLine(p, 270, 278, 260, 265);
            g.DrawLine(p, 273, 258, 260, 265);
            SolidBrush W = new SolidBrush(Color.White); // туловище
            g.FillEllipse(W, 150, 135, 70, 70);
            g.FillEllipse(W, 138, 190, 95, 95);
            g.FillEllipse(W, 128, 260, 120, 120);
            Point[] Points =
            {
                new Point(165, 100),
                new Point(150, 150),
                new Point(220, 150),
                new Point(205, 100),
            };
            SolidBrush S = new SolidBrush(Color.Red); // ведро
            g.FillPolygon(S, Points);
            SolidBrush M = new SolidBrush(Color.Coral); // морковка
            e.Graphics.FillPie(M, 170, 165, 60, 50, 250, -40);
            SolidBrush B = new SolidBrush(Color.Black); // глаза, пуговки
            g.FillEllipse(B, 168, 160, 10, 10);
            g.FillEllipse(B, 195, 160, 10, 10);
            g.FillEllipse(B, 180, 220, 10, 10);
            g.FillEllipse(B, 180, 260, 10, 10);
            g.FillEllipse(B, 180, 300, 10, 10);

        }
    }
}

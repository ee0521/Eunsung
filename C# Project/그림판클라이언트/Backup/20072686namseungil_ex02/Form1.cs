using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _20072686namseungil_ex02
{
    public partial class Form1 : Form
    {
        bool isDrag = false;
        Point previousPoint;
        int setTool = 0;
        int setStrip = 0;
        ColorDialog clg;
        int setColor = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void 종료XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 굵기10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setTool = 1;
        }

        private void 굵기5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setTool = 2;
        }

        private void 굵기3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setTool = 3;
        }

        private void 굵기1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setTool = 0;
        }

        private void dotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setStrip = 1;
        }

        private void dashDotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setStrip = 2;
        }

        private void soildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setStrip = 0;
        }

        private void 선LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clg = new ColorDialog();
            clg.ShowDialog();
            setColor = 1;
            // Set the initial color of the dialog to the current text color

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrag = true;
            previousPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrag = false; 
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrag == true)
            {
                Pen currentPen;
                Point currentPoint = new Point(e.X, e.Y);
                if (setColor == 0)
                    currentPen = new Pen(Color.Black);
                else
                    currentPen = new Pen(clg.Color);

                if (setTool == 0)
                    currentPen.Width = 1;
                else if (setTool == 1)
                    currentPen.Width = 10;
                else if (setTool == 2)
                    currentPen.Width = 5;
                else if (setTool == 3)
                    currentPen.Width = 3;

                if (setStrip == 0)
                    currentPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                else if (setStrip == 1)
                    currentPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                else if (setStrip == 2)
                    currentPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;



                Graphics g = panel1.CreateGraphics();
                g.DrawLine(currentPen, previousPoint, currentPoint);
                previousPoint = currentPoint;
            }
        }
    }
}

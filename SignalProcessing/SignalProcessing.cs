using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignalProcessing
{
    public partial class SignalProcessing : Form
    {
        public SignalProcessing()
        {
            InitializeComponent();

            ResizeRedraw = true;

            signal = new int[44100];

            for (int i = 0; i < signal.Length; ++i)
                signal[i] = (int)(Math.Sin(Math.PI * 2 * i * 1000 / 44100) * 100);
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            Rectangle[] rectangles = new Rectangle[2];

            for (int i = 0; i < rectangles.Length; ++i)
            {
                rectangles[i].X = ClientRectangle.X + 10;
                rectangles[i].Y = ClientRectangle.Y + (ClientRectangle.Height - hScrollBar.Size.Height) * i / rectangles.Length + 10;
                rectangles[i].Width = ClientRectangle.Width - 20;
                rectangles[i].Height = (ClientRectangle.Height - hScrollBar.Size.Height) / rectangles.Length - 20;
            }

            Graphics g = CreateGraphics();

            Pen blackPen = new Pen(Color.Black, 1);

            for (int i = 0; i < rectangles.Length; ++i)
            {
                g.DrawLine(blackPen, new Point(rectangles[i].X, rectangles[i].Y), new Point(rectangles[i].X, rectangles[i].Bottom));
                g.DrawLine(blackPen, new Point(rectangles[i].X, rectangles[i].Y + rectangles[i].Height / 2), new Point(rectangles[i].Right, rectangles[i].Y + rectangles[i].Height / 2));
            }


            Point from = new Point(rectangles[0].X, rectangles[0].Y + rectangles[0].Height / 2);
            from.Offset(0, -(signal[hScrollBar.Value] * rectangles[0].Height / 2 / 100));
            Point to = new Point(0, 0);
            for (int i = 1; i < rectangles[0].Width; ++i)
            { 
                to.X = i;
                to.Y = - (signal[hScrollBar.Value + i] * rectangles[0].Height / 2 / 100);
                to.Offset(rectangles[0].X, rectangles[0].Y + rectangles[0].Height / 2);
                g.DrawLine(blackPen, from, to);
                from.X = to.X;
                from.Y = to.Y;
            }

            g.Dispose();
                
        }

        private int [] signal;

        private void OnValueChanged(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace SignalProcessing
{
    public partial class SignalProcessing : Form
    {
        public SignalProcessing()
        {
            InitializeComponent();

            ResizeRedraw = true;

            CreateData(1000, 5000);
        }

        private void CreateData(int freq1, int freq2)
        {
            signal = new int[3][];
            for (int i = 0; i < signal.Length; ++i)
                signal[i] = new int[44100];

            for (int i = 0; i < signal[0].Length; ++i)
                signal[0][i] = (int)(Math.Sin(Math.PI * 2 * i * freq1 / 44100) * 5000 + Math.Sin(Math.PI * 2 * i * freq2 / 44100) * 5000);

            Complex[] inData = new Complex[N];
            int index = freq2 * (N / 2) / 22050;

            double[] HannWindow = new double[N];
            for (int i = 0; i < HannWindow.Length; ++i)
                HannWindow[i] = 1 - Math.Cos(Math.PI * 2 * i / N);

            for (int i = 0; i < signal[0].Length; i += (inData.Length / 2))
            {
                for (int j = 0; j < inData.Length; ++j)
                    if (i + j < signal[0].Length)
                        inData[j] = new Complex(signal[0][i + j], 0);
                    else
                        inData[j] = new Complex(0, 0);

                FFT(inData, false);

                for (int k = Math.Max(index - 1, 0); k < Math.Min(index + 1, 256); ++k)
                {
                    inData[k] = new Complex(0, 0);
                    inData[512 - k] = new Complex(0, 0);
                }

                FFT(inData, true);

                for (int j = 0; j < inData.Length; ++j)
                    if (i + j < signal[1].Length)
                        signal[1][i + j] += (int)(inData[j].Real * HannWindow[j]);
            }

            double w = Math.Tan(Math.PI * (freq2 + freq1) / 2 / 44100);

            double a0 = 1 + Math.Sqrt(2) * w + w * w;
            double a1 = -2 + 2 * w * w;
            double a2 = 1 - Math.Sqrt(2) * w + w * w;

            double b0 = w * w;
            double b1 = 2 * w * w;
            double b2 = w * w;

            b0 /= a0;
            b1 /= a0;
            b2 /= a0;
            a1 /= a0;
            a2 /= a0;

            for (int i = 2; i < signal[0].Length; ++i)
                signal[2][i] = (int)(b0 * signal[0][i] + b1 * signal[0][i - 1] + b2 * signal[0][i - 2] - a1 * signal[2][i - 1] - a2 * signal[2][i - 2]);

        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            Rectangle[] rectangles = new Rectangle[signal.Length];

            for (int i = 0; i < rectangles.Length; ++i)
            {
                rectangles[i].X = ClientRectangle.X + 10;
                rectangles[i].Y = ClientRectangle.Y + (ClientRectangle.Height - hScrollBar.Size.Height - frequency_1.Size.Height) * i / rectangles.Length + 10 + frequency_1.Size.Height;
                rectangles[i].Width = ClientRectangle.Width - 20;
                rectangles[i].Height = (ClientRectangle.Height - hScrollBar.Size.Height - frequency_1.Size.Height) / rectangles.Length - 20;
            }

            Graphics g = CreateGraphics();

            Pen blackPen = new Pen(Color.Black, 1);

            for (int i = 0; i < rectangles.Length; ++i)
            {
                g.DrawLine(blackPen, new Point(rectangles[i].X, rectangles[i].Y), new Point(rectangles[i].X, rectangles[i].Bottom));
                g.DrawLine(blackPen, new Point(rectangles[i].X, rectangles[i].Y + rectangles[i].Height / 2), new Point(rectangles[i].Right, rectangles[i].Y + rectangles[i].Height / 2));
            }


            for (int i = 0; i < signal.Length; i++)
            {
                Point from = new Point(rectangles[i].X, rectangles[i].Y + rectangles[i].Height / 2);
                from.Offset(0, -(signal[i][hScrollBar.Value] * rectangles[i].Height / 2 / 10000));
                Point to = new Point(0, 0);
                for (int j = 1; j < rectangles[i].Width; ++j)
                {
                    to.X = j;
                    to.Y = -(signal[i][hScrollBar.Value + j] * rectangles[0].Height / 2 / 10000);
                    to.Offset(rectangles[i].X, rectangles[i].Y + rectangles[0].Height / 2);
                    g.DrawLine(blackPen, from, to);
                    from.X = to.X;
                    from.Y = to.Y;
                }
            }

            g.Dispose();
                
        }

        private int[][] signal;

        private void OnValueChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void FFT(Complex [] a, bool invert) 
        {
            if (a.Length == 1)
                return;

            Complex [] a0 =  new Complex[a.Length / 2], a1 = new Complex[a.Length / 2];

            for (int i = 0, j = 0; i < a.Length; i += 2, ++j)
            { 
                a0[j] = a[i];
                a1[j] = a[i + 1];
            }

            FFT(a0, invert);
            FFT(a1, invert);

            double ang = 2 * Math.PI / a.Length * (invert? -1 : 1);
            Complex w = new Complex(1, 0),  wn = new Complex(Math.Cos(ang), Math.Sin(ang));
            for (int i = 0; i < a.Length / 2; ++i) 
            {
                a[i] = a0[i] + w * a1[i];
                a[i + a.Length / 2] = a0[i] - w * a1[i];
                if (invert)
                {
                    a[i] /= 2;
                    a[i + a.Length / 2] /= 2;
                }
                w *= wn;
            }
        }

        private void OnFreq1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                CreateData(Convert.ToInt32(frequency_1.Text), Convert.ToInt32(frequency_2.Text));
                Invalidate();
            }
        }

        private void OnFreq2(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                CreateData(Convert.ToInt32(frequency_1.Text), Convert.ToInt32(frequency_2.Text));
                Invalidate();
            }
        }

        private const int N = 512;
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rasterizer = new Rasterizer();
            bruh = new Pen(Color.FromArgb(80, 80, 80), 4);
            start = new Point(0, 0);
            end = new Point(0, 0);
            center = new Point(0, 0);
            radius = 0;
        }
        private System.Diagnostics.Stopwatch watch;
        private Point start, end, center;
        private int radius;
        Pen bruh;
        Rasterizer rasterizer;
        public void drawMarkup(Graphics gr, Panel panel, VScrollBar vsb, HScrollBar hsb)
        {
            Pen pen_digits = new Pen(Color.Red, 1);
            var cx = panel.Width / 2 + hsb.Value * shift;
            var cy = panel.Height / 2 - vsb.Value * shift;
            int cur_x = 0, cur_y = 0;
            Font font = new Font("Arial", shift - 1);
            int counter = 0;
            gr.DrawString(counter.ToString(), font, pen_digits.Brush, new PointF(cx, cy));
            if (cx <= panel.Width / 2)
            {
                while (cx + cur_x <= panel.Width)
                {
                    counter++;
                    cur_x += scale;
                    PointF pr = new PointF(cx + cur_x, cy);
                    PointF pl = new PointF(cx - cur_x, cy);
                    gr.DrawString(counter.ToString(), font, pen_digits.Brush, pr);
                    gr.DrawString("-" + counter.ToString(), font, pen_digits.Brush, pl);
                }
            }
            else
            {
                while (cx - cur_x >= 0)
                {
                    counter++;
                    cur_x += scale;
                    PointF pr = new PointF(cx + cur_x, cy);
                    PointF pl = new PointF(cx - cur_x, cy);
                    gr.DrawString(counter.ToString(), font, pen_digits.Brush, pr);
                    gr.DrawString("-" + counter.ToString(), font, pen_digits.Brush, pl);
                }
            }
            counter = 0;
            if (cy <= panel.Height / 2)
            {
                while (cy + cur_y <= panel.Height)
                {
                    counter++;
                    cur_y += scale;
                    PointF pl = new PointF(cx, cy + cur_y);
                    PointF pr = new PointF(cx, cy - cur_y);
                    gr.DrawString(counter.ToString(), font, pen_digits.Brush, pr);
                    gr.DrawString("-" + counter.ToString(), font, pen_digits.Brush, pl);

                }
            }
            else
            {
                while (cy - cur_y >= 0)
                {
                    counter++;
                    cur_y += scale;
                    PointF pl = new PointF(cx, cy + cur_y);
                    PointF pr = new PointF(cx, cy - cur_y);
                    gr.DrawString(counter.ToString(), font, pen_digits.Brush, pr);
                    gr.DrawString("-" + counter.ToString(), font, pen_digits.Brush, pl);

                }
            }
            while (cx - cur_x >= 0)
            {
                counter++;
                cur_x += scale;
                PointF pr = new PointF(cx + cur_x, cy);
                PointF pl = new PointF(cx - cur_x, cy);
                gr.DrawString(counter.ToString(), font, pen_digits.Brush, pr);
                gr.DrawString("-" + counter.ToString(), font, pen_digits.Brush, pl);
            }

            Pen penR = new Pen(Color.Red, 2);
            gr.DrawLine(penR, cx, 0, cx, panel.Height);
            gr.DrawLine(penR, 0, cy, panel.Width, cy);
            PointF[] x_vec = new PointF[] { new PointF(cx, 0), new PointF(cx - 2, 5), new PointF(cx + 2, 5) };
            PointF[] y_vec = new PointF[] { new PointF(pBresenham.Width - 1, cy), new PointF(pBresenham.Width - 6, cy - 2), new PointF(pBresenham.Width - 6, cy + 2) };
            gr.DrawPolygon(penR, x_vec);
            gr.DrawPolygon(penR, y_vec);
            gr.DrawString("x", new Font("Arial", scale / 2), penR.Brush, new PointF(pBresenham.Width - 20, cy - 20));
            gr.DrawString("y", new Font("Arial", scale / 2), penR.Brush, new PointF(cx - 15, 0));

        }
        public void drawPlot(Graphics gr, Panel panel, VScrollBar vsb, HScrollBar hsb)
        {
            Pen pen = new Pen(Color.Gray, 1);
            Pen pen_dash = new Pen(Color.LightGray, 1);
            pen_dash.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            gr.DrawRectangle(pen, 0, 0, panel.Width - 1, panel.Height - 1);
            var cx = panel.Width / 2 + hsb.Value * shift;
            var cy = panel.Height / 2 - vsb.Value * shift;
            int cur_x = 0, cur_y = 0;
            if (cx <= panel.Width / 2)
            {
                while (cx + cur_x <= panel.Width)
                {
                    gr.DrawLine(pen, cx - cur_x, 0, cx - cur_x, panel.Height);
                    gr.DrawLine(pen, cx + cur_x, 0, cx + cur_x, panel.Height);
                    gr.DrawLine(pen_dash, cx - cur_x + shift, 0, cx - cur_x + shift, panel.Height);
                    gr.DrawLine(pen_dash, cx + cur_x - shift, 0, cx + cur_x - shift, panel.Height);
                    cur_x += scale;
                }
            }
            else
            {
                while (cx - cur_x >= 0)
                {
                    gr.DrawLine(pen, cx - cur_x, 0, cx - cur_x, panel.Height);
                    gr.DrawLine(pen, cx + cur_x, 0, cx + cur_x, panel.Height);
                    gr.DrawLine(pen_dash, cx - cur_x + shift, 0, cx - cur_x + shift, panel.Height);
                    gr.DrawLine(pen_dash, cx + cur_x - shift, 0, cx + cur_x - shift, panel.Height);
                    cur_x += scale;
                }
            }
            if (cy <= panel.Height / 2)
            {
                while (cy + cur_y <= panel.Height)
                {
                    gr.DrawLine(pen, 0, cy - cur_y, panel.Width, cy - cur_y);
                    gr.DrawLine(pen, 0, cy + cur_y, panel.Width, cy + cur_y);
                    gr.DrawLine(pen_dash, 0, cy - cur_y + shift, panel.Width, cy - cur_y + shift);
                    gr.DrawLine(pen_dash, 0, cy + cur_y - shift, panel.Width, cy + cur_y - shift);
                    cur_y += scale;

                }
            }
            else
            {
                while (cy - cur_y >= 0)
                {
                    gr.DrawLine(pen, 0, cy - cur_y, panel.Width, cy - cur_y);
                    gr.DrawLine(pen, 0, cy + cur_y, panel.Width, cy + cur_y);
                    gr.DrawLine(pen_dash, 0, cy - cur_y + shift, panel.Width, cy - cur_y + shift);
                    gr.DrawLine(pen_dash, 0, cy + cur_y - shift, panel.Width, cy + cur_y - shift);
                    cur_y += scale;

                }
            }
        }
        public enum rasterization
        {
            Bresenham = 1,
            BresenhamCircle,
            DDA,
            Wu,
            Naive,
            CastlePitway,
        };
        int scale = 14;
        int shift = 7;
        public void drawRasterization(Graphics gr, Panel panel, VScrollBar vsb, HScrollBar hsb, PointF begin, int radius)
        {
            watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            var points = rasterizer.CircleBresenham(begin, radius);
            watch.Stop();
            var cx = panel.Width / 2 + hsb.Value * shift;
            var cy = panel.Height / 2 - vsb.Value * shift;
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < points.Length; i++)
            {
                Point p = new Point(points[i].X * scale + cx - shift, -points[i].Y * scale + cy - shift);
                var rect = new Rectangle(p, new Size(scale, scale));
                gr.DrawRectangle(pen, rect);
                gr.FillRectangle(bruh.Brush, rect);
            }
        }
        public void drawRasterization(Graphics gr, Panel panel, VScrollBar vsb, HScrollBar hsb, PointF begin, PointF end)
        {
            watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            var points = rasterizer.Wu(begin, end);
            watch.Stop();
            var cx = panel.Width / 2 + hsb.Value * shift;
            var cy = panel.Height / 2 - vsb.Value * shift;
            Pen pen;
            for (int i = 0; i < points.Count; i++)
            {
                pen = new Pen(Color.FromArgb((int)Math.Round(255 * points[i].Value), 0, 0, 0));
                int x, y;

                Point p = new Point((int)points[i].Key.X * scale + cx - shift, -(int)points[i].Key.Y * scale + cy - shift);
                var rect = new Rectangle(p, new Size(scale, scale));
                gr.DrawRectangle(pen, rect);
                gr.FillRectangle(pen.Brush, rect);
            }
        }

        public void drawRasterization(rasterization r, Graphics gr, Panel panel, VScrollBar vsb, HScrollBar hsb, PointF begin, PointF end)
        {
            Point[] points;
            switch (r)
            {
                case (rasterization.Bresenham):
                    {
                        watch = new System.Diagnostics.Stopwatch();
                        watch.Start();
                        points = rasterizer.Bresenham(begin, end);
                        watch.Stop();
                        break;
                    }
                case (rasterization.DDA):
                    {
                        watch = new System.Diagnostics.Stopwatch();
                        watch.Start();
                        points = rasterizer.DDA(begin, end);
                        watch.Stop();
                        break;
                    }
                case (rasterization.Naive):
                    {
                        watch = new System.Diagnostics.Stopwatch();
                        watch.Start();
                        points = rasterizer.Naive(begin, end);
                        watch.Stop();
                        break;
                    }
                default:
                    {
                        watch = new System.Diagnostics.Stopwatch();
                        watch.Start();
                        points = rasterizer.DDA(begin, end);
                        break;
                    }
            }
            var cx = panel.Width / 2 + hsb.Value * shift;
            var cy = panel.Height / 2 - vsb.Value * shift;
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < points.Length; i++)
            {
                Point p = new Point(points[i].X * scale + cx - shift, -points[i].Y * scale + cy - shift);
                var rect = new Rectangle(p, new Size(scale, scale));
                gr.DrawRectangle(pen, rect);
                gr.FillRectangle(bruh.Brush, rect);
            }
        }
        public void drawLine(Graphics gr, Panel panel, VScrollBar vsb, HScrollBar hsb, PointF start, PointF end, Color color)
        {
            int cx = (int)panel.Width / 2 + hsb.Value * shift;
            int cy = (int)panel.Height / 2 - vsb.Value * shift;
            PointF s = new PointF(start.X * scale + cx, -start.Y * scale + cy);
            PointF e = new PointF(end.X * scale + cx, -end.Y * scale + cy);
            Pen p = new Pen(color, (int)Math.Floor((decimal)shift / 2));
            gr.DrawLine(p, s, e);
        }
        public void drawCircle(Graphics gr, Panel panel, VScrollBar vsb, HScrollBar hsb, Point center, int radius, Color color)
        {
            int cx = (int)panel.Width / 2 + hsb.Value * shift;
            int cy = (int)panel.Height / 2 - vsbCircle.Value * shift;
            gr.DrawEllipse(new Pen(color, (int)Math.Floor((decimal)shift / 2)), (center.X * scale) + cx - radius * scale, -center.Y * scale + cy - radius * scale, 2 * radius * scale, 2 * radius * scale);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            drawPlot(gr, pBresenham, vsbBreseham, hsbBresenham);

            drawRasterization(rasterization.Bresenham, gr, pBresenham, vsbBreseham, hsbBresenham, start, end);

            drawMarkup(gr, pBresenham, vsbBreseham, hsbBresenham);
            drawLine(gr, pBresenham, vsbBreseham, hsbBresenham, start, end, Color.OrangeRed);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            drawPlot(gr, pDDA, vsbDDA, hsbDDA);
            drawRasterization(rasterization.DDA, gr, pDDA, vsbDDA, hsbDDA, start, end);
            drawMarkup(gr, pDDA, vsbDDA, hsbDDA);
            drawLine(gr, pDDA, vsbDDA, hsbDDA, start, end, Color.OrangeRed);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            drawPlot(gr, pCircle, vsbCircle, hsbCircle);
            drawRasterization(gr, pCircle, vsbCircle, hsbCircle, center, radius);
            drawMarkup(gr, pCircle, vsbCircle, hsbCircle);
            drawCircle(gr, pCircle, vsbCircle, hsbCircle, center, radius, Color.OrangeRed);
        }
        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            drawPlot(gr, pNaive, vsbNaive, hsbNaive);
            drawRasterization(rasterization.Naive, gr, pNaive, vsbNaive, hsbNaive, start, end);
            drawMarkup(gr, pNaive, vsbNaive, hsbNaive);
            drawLine(gr, pNaive, vsbNaive, hsbNaive, start, end, Color.OrangeRed);
        }

        private void clear(Panel panel)
        {
            panel.Invalidate();
        }

        private void clearAll()
        {
            clear(pBresenham);
            clear(pDDA);
            clear(pCircle);
            clear(pNaive);
        }

        private void clearLinePanels()
        {
            clear(pBresenham);
            clear(pDDA);
            clear(pNaive);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            start = new Point((int)nXa.Value, (int)nYa.Value);
            end = new Point((int)nXb.Value, (int)nYb.Value);
            clearLinePanels();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            scale = (int)nScale.Value;
            shift = scale / 2;
            clearAll();
        }

        private void vScrollCircle_Scroll(object sender, ScrollEventArgs e)
        {
            pCircle.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void vsbBreseham_Scroll(object sender, ScrollEventArgs e)
        {
            clear(pBresenham);
        }

        private void vsbNaive_Scroll(object sender, ScrollEventArgs e)
        {
            clear(pNaive);
        }

        private void vsbDDA_Scroll(object sender, ScrollEventArgs e)
        {
            clear(pDDA);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            center = new Point((int)nCenterX.Value, (int)nCenterY.Value);
            radius = (int)nRadius.Value;
            clear(pCircle);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            //panel1.Size = new Size(Form1.Size, 10);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace Project
{
    class DisplayButton :XanderUI.XUIButton
    {
        private int iMonth;
        private Color colorMonth;
        private Color colorLine;

        public int IMonth { get => iMonth; set => iMonth = value; }
        public Color ColorMonth { get => colorMonth; set => colorMonth = value; }
        public Color ColorLine { get => colorLine; set => colorLine = value; }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawLunnarDate();
        }
        private void DrawLunnarDate()
        {
            Graphics g = this.CreateGraphics();
            Color colormonth = ColorMonth;
            Brush brushMonth = new SolidBrush(colormonth);
            Color colorline = ColorLine;
            Brush brushLine = new SolidBrush(colorline);
            Pen pen = new Pen(brushLine, this.Width * 0.02f);
            g.DrawLine(pen, new Point(Convert.ToInt32(this.Width * 0.2), Convert.ToInt32(this.Height * 0.6)), new Point(Convert.ToInt32(this.Width * 0.8), Convert.ToInt32(this.Height * 0.6)));
            int min = Width > Height ? Height : Width;
            int fontSizeMonth = Convert.ToInt32(min * 0.15);
            Font fontMonth = new Font("Verdana", fontSizeMonth, FontStyle.Bold);
            SizeF SizeMonth = g.MeasureString(iMonth.ToString(), fontMonth);
            g.DrawString(IMonth.ToString(), fontMonth, brushMonth, new PointF(this.Width / 2 - SizeMonth.Width / 2, this.Height * 0.65f));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CalendarNum1
{
    public class CustomBtn : XanderUI.XUIButton
    {
        private int sLunnarDay;
        private int sLunnarMonth;
        private Color lunnarDayColor;
        public int SLunnarDay { get => sLunnarDay; set => sLunnarDay = value; }
        public int SLunnarMonth { get => sLunnarMonth; set => sLunnarMonth = value; }
        public Color LunnarDayColor { get => lunnarDayColor; set => lunnarDayColor = value; }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            DrawLunnarDate();
        }

        public void DrawLunnarDate()
        {
            Graphics g = this.CreateGraphics();
            int min = Width > Height ? Height : Width;
            int fontSize = Convert.ToInt32(min * 0.2f);
            Brush brush = new SolidBrush(LunnarDayColor);
            Font font = new Font("Verdana", fontSize, FontStyle.Bold);
            SizeF fontSizeText = g.MeasureString(SLunnarDay.ToString(), font);
            if (sLunnarDay >= 10)
            {
                g.DrawString(SLunnarDay.ToString(), font, brush, new PointF(this.Width * 0.70f, this.Height * 0.6f));
            }
            else if (sLunnarDay < 10 && sLunnarDay > 1)
            {
                g.DrawString(SLunnarDay.ToString(), font, brush, new PointF(this.Width * 0.8f, this.Height * 0.6f));
            }
            else
            {
                if (sLunnarMonth < 10)
                {
                    g.DrawString(SLunnarDay.ToString() + "/" + SLunnarMonth.ToString(), font, brush, new PointF(this.Width * 0.65f, this.Height * 0.6f));
                }
                else
                {
                    g.DrawString(SLunnarDay.ToString() + "/" + SLunnarMonth.ToString(), font, brush, new PointF(this.Width * 0.55f, this.Height * 0.6f));
                }
               
            }
            

        }
    }
}

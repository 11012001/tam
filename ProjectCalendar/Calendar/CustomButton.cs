using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class CustomButton : XanderUI.XUIButton
    {
        public CustomButton()
        {
            InitializeComponent();
        }

        public CustomButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        private int sLunnarDay;
        private int sLunnarMonth;
        private int zodiacDay;
        private Color lunnarDayColor;
        public int SLunnarDay { get => sLunnarDay; set => sLunnarDay = value; }
        public int SLunnarMonth { get => sLunnarMonth; set => sLunnarMonth = value; }
        public Color LunnarDayColor { get => lunnarDayColor; set => lunnarDayColor = value; }
        public int ZodiacDay { get => zodiacDay; set => zodiacDay = value; }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            DrawLunnarDate();
        }

        public void DrawLunnarDate()
        {
            Graphics g = this.CreateGraphics();
            int min = Width > Height ? Height : Width;

            if (ZodiacDay == 1)
            {
                Bitmap bitmap = new Bitmap("D:/B Pro Coder/Calendar/NewCalendar/ProjectCalendar/Calendar/Resources/HoangDao.png");
                g.DrawImage(bitmap, this.Width * 0.7f, this.Height * 0.2f, this.Width * 3 / 10, this.Height * 3 / 10);
            }
            else if (ZodiacDay == -1)
            {
                Bitmap bitmap = new Bitmap("D:/B Pro Coder/Calendar/NewCalendar/ProjectCalendar/Calendar/Resources/HacDao.png");
                g.DrawImage(bitmap, this.Width * 0.7f, this.Height * 0.2f, this.Width * 3 / 10, this.Height * 3 / 10);
            }
            int fontSize = Convert.ToInt32(min * 0.15f);
            Brush brush = new SolidBrush(LunnarDayColor);
            Font font = new Font("Verdana", fontSize, FontStyle.Bold);
            if (sLunnarDay >= 10)
            {
                g.DrawString(SLunnarDay.ToString(), font, brush, new PointF(this.Width * 0.7f, this.Height * 0.6f));
            }
            else if (sLunnarDay < 10 && sLunnarDay > 1)
            {
                g.DrawString(SLunnarDay.ToString(), font, brush, new PointF(this.Width * 0.8f, this.Height * 0.6f));
            }
            else
            {
                if (sLunnarMonth < 10)
                {
                    g.DrawString(SLunnarDay.ToString() + "/" + SLunnarMonth.ToString(), font, brush, new PointF(this.Width * 0.4f, this.Height * 0.6f));
                }
                else
                {
                    g.DrawString(SLunnarDay.ToString() + "/" + SLunnarMonth.ToString(), font, brush, new PointF(this.Width * 0.45f, this.Height * 0.6f));
                }

            }
        }
    }
}

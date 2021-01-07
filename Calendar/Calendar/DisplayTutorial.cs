using LunnarSample;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class DisplayTutorial : UserControl
    {
        private static DisplayTutorial tutorial;
        public static DisplayTutorial Tutorial
        {
            get
            {
                if (tutorial == null)
                    tutorial = new DisplayTutorial();
                return tutorial;
            }
        }
        public DisplayTutorial()
        {
            InitializeComponent();
            DisplayHDSD();
        }
        public static void HighlightRTB(RichTextBox rtb, float size)
        {

            HighlightPhrase(rtb, "HƯỚNG", "\n", Color.Blue, FontStyle.Bold, size + 4, HorizontalAlignment.Center);

            HighlightPhrase(rtb, "*", ":", Color.Red, FontStyle.Bold, size, HorizontalAlignment.Left);

            HighlightPhrase(rtb, "~", ".~", Color.Red, FontStyle.Italic, size, HorizontalAlignment.Center);

            HighlightPhrase(rtb, "#", ".", Color.Blue, FontStyle.Italic, size - 2, HorizontalAlignment.Center);

            HighlightPhrase(rtb, "-", ":", Color.Green, FontStyle.Italic, size - 2, HorizontalAlignment.Left);

        }
        public static void HighlightPhrase(RichTextBox box, string begin, string end, Color color, FontStyle fontStyle, float size, HorizontalAlignment horizontal)
        {
            string s = box.Text;
            for (int ix = 0; ix < s.Length;)
            {
                int jx = s.IndexOf(begin, ix);
                if (jx < 0)
                    break;
                int kx = s.IndexOf(end, jx);
                if (kx < 0)
                    kx = jx;
                box.SelectionStart = jx;
                box.SelectionLength = kx - jx + 1;
                box.SelectionColor = color;
                box.SelectionAlignment = horizontal;
                box.SelectionFont = new Font(box.Font.FontFamily, size, fontStyle);
                ix = kx + 1;
            }
        }
        public void DisplayHDSD()
        {
            rtbRead.Text = StringText.hdsd;
            HighlightRTB(rtbRead, 16);
        }
    }
}

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
    public partial class FormSetting : Form
    {
        public FormSetting()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rbtnBM.Checked == true)
            {
                SpeechClass.voice = "banmai";
                Close();
            }
            if (rbtnLM.Checked == true)
            {
                SpeechClass.voice = "leminh";
                Close();
            }
            if (rbtnTM.Checked == true)
            {
                SpeechClass.voice = "thuminh";
                Close();
            }
            if (rbtnGH.Checked == true)
            {
                SpeechClass.voice = "giahuy";
                Close();
            }
            if (rbtnMA.Checked == true)
            {
                SpeechClass.voice = "myan";
                Close();
            }
            if (rbtnLN.Checked == true)
            {
                SpeechClass.voice = "lannhi";
                Close();
            }
            if (rbtnLS.Checked == true)
            {
                SpeechClass.voice = "linhsan";
                Close();
            }
        }
    }
}

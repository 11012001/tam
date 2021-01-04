using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LunnarSample;

namespace Calendar
{
    public partial class DisplayVanKhan : UserControl
    {
        public DisplayVanKhan()
        {
            InitializeComponent();
        }

        public static void HighlightRTB(RichTextBox rtb)
        {
            string[] words = rtb.Text.Split('\n');

            rtb.SelectionStart = 0;
            rtb.SelectionLength = words[0].Length;
            rtb.SelectionColor = Color.Blue;
            rtb.SelectionFont = new Font("Arial", 16, FontStyle.Bold);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            rtbRead.Clear();
            rtbRead.SelectionFont = new Font("Arial", 12, FontStyle.Regular);
            panelShow.SendToBack();
            panelShow.Visible = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            float temp = rtbRead.SelectionFont.Size;
            if (temp < 24 * 1f)
            {

                rtbRead.SelectAll();
                rtbRead.SelectionFont = new Font(rtbRead.SelectionFont.FontFamily, rtbRead.SelectionFont.Size + 1f, rtbRead.SelectionFont.Style);
            }
            else
            {
                rtbRead.SelectAll();
                rtbRead.SelectionFont = new Font(rtbRead.SelectionFont.FontFamily, rtbRead.SelectionFont.Size, rtbRead.SelectionFont.Style);
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            float temp = rtbRead.SelectionFont.Size;
            if (temp > 9 * 1f)
            {
                rtbRead.SelectAll();
                rtbRead.SelectionFont = new Font(rtbRead.SelectionFont.FontFamily, rtbRead.SelectionFont.Size - 1f, rtbRead.SelectionFont.Style);
            }
            else
            {
                rtbRead.SelectAll();
                rtbRead.SelectionFont = new Font(rtbRead.SelectionFont.FontFamily, rtbRead.SelectionFont.Size, rtbRead.SelectionFont.Style);
            }
        }
        private void SetText(string s)
        {
            rtbRead.Text = s;
            HighlightRTB(rtbRead);
        }
        private void btnTetOT_Click(object sender, EventArgs e)
        {
            SetText(VanKhanString.vklot);
            panelShow.Visible = true;
            panelShow.BringToFront();
        }

        private void btnTetGT_Click(object sender, EventArgs e)
        {
            SetText(VanKhanString.vklgt);
            panelShow.Visible = true;
            panelShow.BringToFront();
        }

        private void btnTetTN_Click(object sender, EventArgs e)
        {
            SetText(VanKhanString.vktn);
            panelShow.Visible = true;
            panelShow.BringToFront();
        }

        private void btnTetVKTM_Click(object sender, EventArgs e)
        {
            SetText(VanKhanString.vkltm);
            panelShow.Visible = true;
            panelShow.BringToFront();
        }

        private void btnTetTTM1_Click(object sender, EventArgs e)
        {
            SetText(VanKhanString.vkttm1);
            panelShow.Visible = true;
            panelShow.BringToFront();
        }

        private void btnTetTLM1_Click(object sender, EventArgs e)
        {
            SetText(VanKhanString.vktlm1);
            panelShow.Visible = true;
            panelShow.BringToFront();
        }

        private void btnTetNM_Click(object sender, EventArgs e)
        {
            SetText(VanKhanString.vkltnm);
            panelShow.Visible = true;
            panelShow.BringToFront();
        }

        private void btnChuaLP_Click(object sender, EventArgs e)
        {
            SetText(VanKhanString.vklp);
            panelShow.Visible = true;
            panelShow.BringToFront();
        }

        private void btnChuaQABT_Click(object sender, EventArgs e)
        {
            SetText(VanKhanString.vkbtqa);
            panelShow.Visible = true;
            panelShow.BringToFront();
        }

        private void btnChuaTH_Click(object sender, EventArgs e)
        {
            SetText(VanKhanString.vkth);
            panelShow.Visible = true;
            panelShow.BringToFront();
        }

        private void btnChuaTMLH_Click(object sender, EventArgs e)
        {
            SetText(VanKhanString.vktmlh);
            panelShow.Visible = true;
            panelShow.BringToFront();
        }

        private void btnChuaDTT_Click(object sender, EventArgs e)
        {
            SetText(VanKhanString.vkdtt);
            panelShow.Visible = true;
            panelShow.BringToFront();
        }

        private void btnChuaBCK_Click(object sender, EventArgs e)
        {
            SetText(VanKhanString.vkbck);
            panelShow.Visible = true;
            panelShow.BringToFront();
        }

        private void btnChuaDO_Click(object sender, EventArgs e)
        {
            SetText(VanKhanString.vkdo);
            panelShow.Visible = true;
            panelShow.BringToFront();
        }

        private void btnChuaDTH_Click(object sender, EventArgs e)
        {
            SetText(VanKhanString.vkdth);
            panelShow.Visible = true;
            panelShow.BringToFront();
        }

        private void btnChuaMTN_Click(object sender, EventArgs e)
        {
            SetText(VanKhanString.vkmtn);
            panelShow.Visible = true;
            panelShow.BringToFront();
        }

        private void btnRamLNT_Click(object sender, EventArgs e)
        {
            SetText(VanKhanString.vkrtg);
            panelShow.Visible = true;
            panelShow.BringToFront();
        }

        private void btnRamLTM_Click(object sender, EventArgs e)
        {
            SetText(VanKhanString.vkltmram);
            panelShow.Visible = true;
            panelShow.BringToFront();
        }

        private void btnRamTHT_Click(object sender, EventArgs e)
        {
            SetText(VanKhanString.vktht);
            panelShow.Visible = true;
            panelShow.BringToFront();
        }

        private void btnRamTDN_Click(object sender, EventArgs e)
        {
            SetText(VanKhanString.vktdn);
            panelShow.Visible = true;
            panelShow.BringToFront();
        }

        private void btnRamTTT_Click(object sender, EventArgs e)
        {
            SetText(VanKhanString.vkttt);
            panelShow.Visible = true;
            panelShow.BringToFront();
        }

        private void btnRamT7_Click(object sender, EventArgs e)
        {
            SetText(VanKhanString.vkrt7);
            panelShow.Visible = true;
            panelShow.BringToFront();
        }

        private void btnRamNgay1_Click(object sender, EventArgs e)
        {
            SetText(VanKhanString.vkm1vs15);
            panelShow.Visible = true;
            panelShow.BringToFront();
        }

        private void btnRamTT_Click(object sender, EventArgs e)
        {
            SetText(VanKhanString.vktdtt);
            panelShow.Visible = true;
            panelShow.BringToFront();
        }

        private void btnTangLCT_Click(object sender, EventArgs e)
        {
            SetText(VanKhanString.vklct);
            panelShow.Visible = true;
            panelShow.BringToFront();
        }

        private void btnTangLDT_Click(object sender, EventArgs e)
        {
            SetText(VanKhanString.vkldt);
            panelShow.Visible = true;
            panelShow.BringToFront();
        }

        private void btnTangLCTTK_Click(object sender, EventArgs e)
        {
            SetText(VanKhanString.vklct49);
            panelShow.Visible = true;
            panelShow.BringToFront();
        }

        private void btnTangNGD_Click(object sender, EventArgs e)
        {
            SetText(VanKhanString.vkngd);
            panelShow.Visible = true;
            panelShow.BringToFront();
        }

        private void btnTangNGH_Click(object sender, EventArgs e)
        {
            SetText(VanKhanString.vkngh);
            panelShow.Visible = true;
            panelShow.BringToFront();
        }

        private void btnTangNGT_Click(object sender, EventArgs e)
        {
            SetText(VanKhanString.vkngt);
            panelShow.Visible = true;
            panelShow.BringToFront();
        }

        private void btnTangNCG_Click(object sender, EventArgs e)
        {
            SetText(VanKhanString.vkncg);
            panelShow.Visible = true;
            panelShow.BringToFront();
        }

        private void btnTangGT_Click(object sender, EventArgs e)
        {
            SetText(VanKhanString.vkkdtm);
            panelShow.Visible = true;
            panelShow.BringToFront();
        }

        private void btnCuoiCBM_Click(object sender, EventArgs e)
        {
            SetText(VanKhanString.vkcm);
            panelShow.Visible = true;
            panelShow.BringToFront();
        }

        private void btnCuoiNLC_Click(object sender, EventArgs e)
        {
            SetText(VanKhanString.vkch);
            panelShow.Visible = true;
            panelShow.BringToFront();
        }

        private void btnNhaKCN_Click(object sender, EventArgs e)
        {
            SetText(VanKhanString.vkcnsn);
            panelShow.Visible = true;
            panelShow.BringToFront();
        }

        private void btnNhaLNT_Click(object sender, EventArgs e)
        {
            SetText(VanKhanString.vklnt);
            panelShow.Visible = true;
            panelShow.BringToFront();
        }

        private void btnNhaMTG_Click(object sender, EventArgs e)
        {
            SetText(VanKhanString.vkltg);
            panelShow.Visible = true;
            panelShow.BringToFront();
        }

        private void btnKhacLKT_Click(object sender, EventArgs e)
        {
            SetText(VanKhanString.vklkt);
            panelShow.Visible = true;
            panelShow.BringToFront();
        }

        private void btnKhacLMT_Click(object sender, EventArgs e)
        {
            SetText(VanKhanString.vklmt);
            panelShow.Visible = true;
            panelShow.BringToFront();
        }
    }
}

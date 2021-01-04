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
    public partial class ToDoNote : Form
    {
        public int IdNote = 0;
        public int Check;

        public ToDoNote()
        {
            InitializeComponent();
        }
        private void ToDoNote_Load_1(object sender, EventArgs e)
        {
            RepeatCB.SelectedIndex = 0;
            if (string.IsNullOrWhiteSpace(FHoursCB.Text))
            {
                THoursCB.SelectedIndex = 0;
                TMinutesCB.SelectedIndex = 0;
                FHoursCB.SelectedIndex = 0;
                FMinutesCB.SelectedIndex = 0;
            }
            try
            {
                NoteData.Connect();
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }

        private void SaveBtn_Click_1(object sender, EventArgs e)
        {
            if (MainNote.Text == "Nhập ghi chú")
            {
                MessageBox.Show("Ghi chú không được rỗng");
                return;
            }
            if (DescriptionTB.Text == "Mô tả")
                DescriptionTB.Text = null;
            if (ImportantCheck.Checked == true) Check = 1;
            else Check = 0;
            string sql = "";

            if (NoteData.IsConfirm("Bạn có muốn lưu lại?"))
            {
                if (IdNote == 0)
                {
                    
                    if (RepeatCB.SelectedIndex == 0)
                    {
                        FromDtpk.Value.AddSeconds(1);
                        sql = $"insert into NoteByDate(NoteText,Description,AppDate,FromH,FromM,ToH,ToM,Important) " +
                           $"values('{MainNote.Text}','{DescriptionTB.Text}','{FromDtpk.Value}','{FHoursCB.Text}','{FMinutesCB.Text}','{THoursCB.Text}','{TMinutesCB.Text}','{Check}')";
                        NoteData.UpdateInsertDelete(sql);
                    }
                    else if (RepeatCB.SelectedIndex == 1)
                    {
                        while (FromDtpk.Value <= ToDtpk.Value)
                        {
                            sql = $"insert into NoteByDate(NoteText,Description,AppDate,FromH,FromM,ToH,ToM,Important) " +
                           $"values('{MainNote.Text}','{DescriptionTB.Text}','{FromDtpk.Value}','{FHoursCB.Text}','{FMinutesCB.Text}','{THoursCB.Text}','{TMinutesCB.Text}','{Check}')";
                            NoteData.UpdateInsertDelete(sql);
                            FromDtpk.Value = FromDtpk.Value.AddDays(1);
                        }
                    }
                    else if (RepeatCB.SelectedIndex == 2)
                    {
                        while (FromDtpk.Value <= ToDtpk.Value)
                        {
                            sql = $"insert into NoteByDate(NoteText,Description,AppDate,FromH,FromM,ToH,ToM,Important)" +
                           $"values('{MainNote.Text}','{DescriptionTB.Text}','{FromDtpk.Value}','{FHoursCB.Text}','{FMinutesCB.Text}','{THoursCB.Text}','{TMinutesCB.Text}','{Check}')";
                            NoteData.UpdateInsertDelete(sql);
                            FromDtpk.Value = FromDtpk.Value.AddDays(7);
                        }
                    }
                    else if (RepeatCB.SelectedIndex == 3)
                    {
                        while (FromDtpk.Value <= ToDtpk.Value)
                        {
                            sql = $"insert into NoteByDate(NoteText,Description,AppDate,FromH,FromM,ToH,ToM,Important) " +
                           $"values('{MainNote.Text}','{DescriptionTB.Text}','{FromDtpk.Value}','{FHoursCB.Text}','{FMinutesCB.Text}','{THoursCB.Text}','{TMinutesCB.Text}','{Check}')";
                            NoteData.UpdateInsertDelete(sql);
                            FromDtpk.Value = FromDtpk.Value.AddMonths(1);
                        }
                    }
                    else if (RepeatCB.SelectedIndex == 4)
                    {
                        while (FromDtpk.Value <= ToDtpk.Value)
                        {
                            sql = $"insert into NoteByDate(NoteText,Description,AppDate,FromH,FromM,ToH,ToM,Important) " +
                           $"values('{MainNote.Text}','{DescriptionTB.Text}','{FromDtpk.Value}','{FHoursCB.Text}','{FMinutesCB.Text}','{THoursCB.Text}','{TMinutesCB.Text}','{Check}')";
                            NoteData.UpdateInsertDelete(sql);
                            FromDtpk.Value = FromDtpk.Value.AddYears(1);
                        }
                    }
                }
                else
                {
                    sql = $"update NoteByDate set NoteText = '{MainNote.Text}', Description = '{DescriptionTB.Text}', AppDate = '{FromDtpk.Value}', FromH = '{FHoursCB.Text}', FromM = '{FMinutesCB.Text}', ToH = '{THoursCB.Text}', ToM = '{TMinutesCB.Text}', Important = '{Check}' where IdNote = {IdNote}";
                    NoteData.UpdateInsertDelete(sql);
                }
                MessageBox.Show("Lưu thành công");
                this.Close();
            }
        }

        private void RepeatCB_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (RepeatCB.Text == "Không lặp")
            {
                ToDate.Visible = false;
                ToDtpk.Visible = false;
            }
            else
            {
                ToDate.Visible = true;
                ToDtpk.Visible = true;
            }
        }

        private void ExitBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainNote_Enter_1(object sender, EventArgs e)
        {
            if (MainNote.Text == "Nhập ghi chú")
            {
                MainNote.Text = "";
                MainNote.ForeColor = Color.Black;
            }
        }

        private void MainNote_Leave_1(object sender, EventArgs e)
        {
            if (MainNote.Text == "")
            {
                MainNote.Text = "Nhập ghi chú";
                MainNote.ForeColor = Color.LightGray;
            }
        }

        private void DescriptionTB_Enter_1(object sender, EventArgs e)
        {
            if (DescriptionTB.Text == "Mô tả")
            {
                DescriptionTB.Text = "";
                DescriptionTB.ForeColor = Color.Black;
            }
        }

        private void DescriptionTB_Leave_1(object sender, EventArgs e)
        {
            if (DescriptionTB.Text == "")
            {
                DescriptionTB.Text = "Mô tả";
                DescriptionTB.ForeColor = Color.LightGray;
            }
        }


    }
}

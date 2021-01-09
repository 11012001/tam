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
    public partial class DeadLineNote : Form
    {
        public int ImportanceCheck;
        public int IDDeadLine = 0;
        public DeadLineNote()
        {
            
            InitializeComponent();
        }

        private void MainNote_Enter(object sender, EventArgs e)
        {
            if (MainNote.Text == "Ghi chú")
            {
                MainNote.Text = "";
                MainNote.ForeColor = Color.Black;
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }

        private void MainNote_Leave(object sender, EventArgs e)
        {
            if (MainNote.Text == "")
            {
                MainNote.Text = "Ghi chú";
                MainNote.ForeColor = Color.LightGray;
            }
        }

        private void DescriptionTB_Enter(object sender, EventArgs e)
        {
            if (DescriptionTB.Text == "Mô tả")
            {
                DescriptionTB.Text = "";
                DescriptionTB.ForeColor = Color.Black;
            }
        }

        private void DescriptionTB_Leave(object sender, EventArgs e)
        {
            if (MainNote.Text == "")
            {
                DescriptionTB.Text = "Mô tả";
                DescriptionTB.ForeColor = Color.LightGray;
            }
        }

        private void DeadLineNote_Load(object sender, EventArgs e)
        {
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (MainNote.Text == "Ghi chú")
            {
                MessageBox.Show("Ghi chú không được rỗng","Cảnh Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (DescriptionTB.Text == "Mô tả")
            {
                DescriptionTB.Text = null;
            }
            if (ImportantCheck.Checked == true)
            {
                ImportanceCheck = 1;
            }
            else
                ImportanceCheck = 0;
            Dtpk.Value = new DateTime(Dtpk.Value.Year, Dtpk.Value.Month, Dtpk.Value.Day, Int32.Parse(HoursCB.Text), Int32.Parse(MinutesCB.Text), 0);
            string sql;
            if (NoteData.IsConfirm("Bạn có muốn lưu lại?"))
            {
                try
                {
                    if (IDDeadLine == 0)
                    {
                        switch (UrgentCB.SelectedIndex)
                        {
                            case 0:
                                sql = $"insert into Deadline(DeadlineText,DescriptionText,DateEnd,TimeHEnd,TimeMEnd,Importance,UrgentCount)" +
                               $"values('{MainNote.Text}','{DescriptionTB.Text}','{Dtpk.Value}','{HoursCB.Text}','{MinutesCB.Text}','{ImportanceCheck}','{1}')";
                                NoteData.UpdateInsertDelete(sql);
                                break;
                            case 1:
                                sql = $"insert into Deadline(DeadlineText,DescriptionText,DateEnd,TimeHEnd,TimeMEnd,Importance,UrgentCount)" +
                               $"values('{MainNote.Text}','{DescriptionTB.Text}','{Dtpk.Value}','{HoursCB.Text}','{MinutesCB.Text}','{ImportanceCheck}','{3}')";
                                NoteData.UpdateInsertDelete(sql);
                                break;
                            case 2:
                                sql = $"insert into Deadline(DeadlineText,DescriptionText,DateEnd,TimeHEnd,TimeMEnd,Importance,UrgentCount)" +
                               $"values('{MainNote.Text}','{DescriptionTB.Text}','{Dtpk.Value}','{HoursCB.Text}','{MinutesCB.Text}','{ImportanceCheck}','{7}')";
                                NoteData.UpdateInsertDelete(sql);
                                break;
                            case 3:
                                sql = $"insert into Deadline(DeadlineText,DescriptionText,DateEnd,TimeHEnd,TimeMEnd,Importance,UrgentCount)" +
                               $"values('{MainNote.Text}','{DescriptionTB.Text}','{Dtpk.Value}','{HoursCB.Text}','{MinutesCB.Text}','{ImportanceCheck}','{14}')";
                                NoteData.UpdateInsertDelete(sql);
                                break;
                        }
                    }
                    else
                    {
                        switch (UrgentCB.SelectedIndex)
                        {
                            case 0:
                                sql = $"update Deadline set DeadlineText = '{MainNote.Text}', DescriptionText = '{DescriptionTB.Text}', DateEnd = '{Dtpk.Value}', TimeHEnd = '{HoursCB.Text}', TimeMEnd = '{MinutesCB.Text}', Importance = '{ImportanceCheck}',UrgentCount = '{1}' where IdDeadline = {IDDeadLine}";
                                NoteData.UpdateInsertDelete(sql);
                                break;
                            case 1:
                                sql = $"update Deadline set DeadlineText = '{MainNote.Text}', DescriptionText = '{DescriptionTB.Text}', DateEnd = '{Dtpk.Value}', TimeHEnd = '{HoursCB.Text}', TimeMEnd = '{MinutesCB.Text}', Importance = '{ImportanceCheck}',UrgentCount = '{3}' where IdDeadline = {IDDeadLine}";
                                NoteData.UpdateInsertDelete(sql);
                                break;
                            case 2:
                                sql = $"update Deadline set DeadlineText = '{MainNote.Text}', DescriptionText = '{DescriptionTB.Text}', DateEnd = '{Dtpk.Value}', TimeHEnd = '{HoursCB.Text}', TimeMEnd = '{MinutesCB.Text}', Importance = '{ImportanceCheck}',UrgentCount = '{7}' where IdDeadline = {IDDeadLine}";
                                NoteData.UpdateInsertDelete(sql);
                                break;
                            case 3:
                                sql = $"update Deadline set DeadlineText = '{MainNote.Text}', DescriptionText = '{DescriptionTB.Text}', DateEnd = '{Dtpk.Value}', TimeHEnd = '{HoursCB.Text}', TimeMEnd = '{MinutesCB.Text}', Importance = '{ImportanceCheck}',UrgentCount = '{14}' where IdDeadline = {IDDeadLine}";
                                NoteData.UpdateInsertDelete(sql);
                                break;

                        }
                    }
                    MessageBox.Show("Lưu dữ liệu thành công!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Lưu dữ liệu thất bại!","Báo Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

    }
}

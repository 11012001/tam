using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace Calendar
{
    public static class NoteData
    {
        private static OleDbConnection cn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = |DataDirectory|NoteByDateDatabase.accdb");

        public static void Connect()
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
        }
        public static bool UpdateInsertDelete(string sql)
        {
            Connect();
            OleDbCommand cmd = new OleDbCommand(sql, cn);
            return cmd.ExecuteNonQuery() > 0;
        }
        public static bool IsConfirm(string message)
        {
            return MessageBox.Show(message, "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
        public static DataTable QueryAsDatatable(string sql)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "result");
            return ds.Tables["result"];
        }

    }
}

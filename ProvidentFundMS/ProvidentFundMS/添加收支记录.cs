using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvidentFundMS
{
    public partial class 添加收支记录 : Form
    {
        public string enterprise_name = null;
        public string provident_number = null;
        public ListViewItem lv = null;

        String sqlConn = null;
        OleDbConnection myConn = null;

        public 添加收支记录()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            sqlConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= ../../database/ProvidentFundMS.mdb";
            myConn = new OleDbConnection(sqlConn);
        }

        private void confirm_add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                float test_float = float.Parse(this.income_textbox.Text);
                test_float = float.Parse(this.cost_textbox.Text);
                test_float = float.Parse(this.remain_textbox.Text);
            }
            catch
            {
                MessageBox.Show("存入、支出或余额输入格式不正确，请重新填写！");
                return;
            }

            myConn.Open();
            String selcet_sql = "select ID from enterprise where enterprise_name = '" + enterprise_name + "'";
            OleDbCommand myComm = new OleDbCommand(selcet_sql, myConn);
            OleDbDataReader myReader = myComm.ExecuteReader();

            int enterprise_id = 0;
            if (myReader.Read())
                enterprise_id = int.Parse(myReader[0].ToString());

            String insert_sql = "INSERT INTO incomecost ([date],[abstract],[income],[cost],[remain],[operator],[enterprise_id]) VALUES";
            insert_sql += "('" + this.date_textbox.Text + "',"
                          + "'" + this.abstract_comboBox.Text + "',"
                          + "'" + this.income_textbox.Text + "',"
                          + "'" + this.cost_textbox.Text + "',"
                          + "'" + this.remain_textbox.Text + "',"
                          + "'" + this.operator_textbox.Text + "',"
                                + enterprise_id + ")";

            myComm = new OleDbCommand(insert_sql, myConn);
            myComm.ExecuteNonQuery();



            String update_sql = "UPDATE enterprise SET";
            update_sql += " [remain] = " + this.remain_label.Text;
            update_sql += " WHERE [id] =" + enterprise_id;


            myComm = new OleDbCommand(update_sql, myConn);
            myComm.ExecuteNonQuery();


            myReader.Close();
            myConn.Close();

            MessageBox.Show("添加记录成功。");
        }

        private void AddIERecordForm_Load(object sender, EventArgs e)
        {
            this.enterprise_label.Text = enterprise_name;
            this.provident_found_number_label.Text = provident_number;
            this.remain_label.Text = lv.SubItems[4].Text.ToString();
            this.date_textbox.Text = DateTime.Now.ToString();
        }

        private void income_textbox_TextChanged(object sender, EventArgs e)
        {
             float remain = float.Parse(remain_label.Text) + float.Parse(this.income_textbox.Text) - float.Parse(this.cost_textbox.Text);
             this.remain_textbox.Text = remain.ToString();
        }

        private void cost_textbox_TextChanged(object sender, EventArgs e)
        {
            float remain = float.Parse(remain_label.Text) + float.Parse(this.income_textbox.Text) - float.Parse(this.cost_textbox.Text);
            this.remain_textbox.Text = remain.ToString();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

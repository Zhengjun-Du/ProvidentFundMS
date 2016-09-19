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

        public 添加收支记录()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void confirm_add_btn_Click(object sender, EventArgs e)
        {
            if (this.operator_textbox.Text == "" || this.abstract_comboBox.Text == "")
            {
                MessageBox.Show("摘要或经办人不能为空，请重新填写！");
                return;
            }

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

            int enterprise_id = int.Parse(lv.SubItems[5].Text);
            String insert_sql = "INSERT INTO incomecost ([date],[abstract],[income],[cost],[remain],[operator],[enterprise_id]) VALUES";
            insert_sql += "('" + this.date_textbox.Text + "',"
                          + "'" + this.abstract_comboBox.Text + "',"
                          + "'" + this.income_textbox.Text + "',"
                          + "'" + this.cost_textbox.Text + "',"
                          + "'" + this.remain_textbox.Text + "',"
                          + "'" + this.operator_textbox.Text + "',"
                                + enterprise_id + ")";

            new DataAccess().InsertData(insert_sql);

            this.remain_label.Text = this.remain_textbox.Text;


            String update_sql = "UPDATE enterprise SET";
                   update_sql += " [remain] = " + this.remain_textbox.Text;
                   update_sql += " WHERE [id] =" + enterprise_id;

            new DataAccess().UpdateData(update_sql);

            MessageBox.Show("添加记录成功。");
            this.Close();
        }

        private void AddIERecordForm_Load(object sender, EventArgs e)
        {
            this.enterprise_label.Text = enterprise_name;
            this.provident_found_number_label.Text = provident_number;
            this.date_textbox.Text = DateTime.Now.ToString();

            String selcet_sql_0 = "SELECT remain FROM enterprise WHERE id=" + lv.SubItems[5].Text;
            OleDbDataReader myReader = new DataAccess().SelectData(selcet_sql_0);
            if (myReader.Read())
                this.remain_label.Text = myReader["remain"].ToString();
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
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
    public partial class 修改收支明细 : Form
    {
        public string enterprise_name = null;
        public string provident_number = null;
        public ListViewItem lv = null;
        string original_modifytime;


        public 修改收支明细()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void ModifyIEinfoFrom_Load(object sender, EventArgs e)
        {
            this.date_textbox.Text = lv.SubItems[1].Text.ToString();
            this.income_textbox.Text = lv.SubItems[3].Text.ToString();
            this.cost_textbox.Text = lv.SubItems[4].Text.ToString();
            this.remain_textbox.Text  =  lv.SubItems[5].Text.ToString();
            this.operator_textbox.Text = lv.SubItems[6].Text.ToString();
            original_modifytime = lv.SubItems[1].Text.ToString();
        }

        private void confirm_modify_btn_Click(object sender, EventArgs e)
        {
            try
            {
                float test_float = float.Parse(this.income_textbox.Text);
                test_float = float.Parse(this.cost_textbox.Text);
                test_float = float.Parse(this.remain_textbox.Text);
            }
            catch {
                MessageBox.Show("存入、支出或余额输入格式不正确，请重新填写！");
                return;
            }

            String update_sql = "UPDATE incomecost SET";
            update_sql += " [abstract] = '" + this.abstract_comboBox.Text+ "',";
            update_sql += " [income] = " + this.income_textbox.Text + ",";
            update_sql += " [cost] = " + this.cost_textbox.Text + ",";
            update_sql += " [remain] = " + this.remain_textbox.Text + ",";
            update_sql += " [operator] = '" + this.operator_textbox.Text + "'";
            update_sql += " WHERE [date] = #" + original_modifytime + "#";

            new DataAccess().UpdateData(update_sql);

            MessageBox.Show("数据修改成功。");
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
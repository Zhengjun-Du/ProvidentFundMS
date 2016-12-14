using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvidentFundMS
{
    public partial class 修改党员信息 : Form
    {
        public ListViewItem display_content = null;

        public 修改党员信息()
        {
            InitializeComponent();

            this.birth_textbox.Format = DateTimePickerFormat.Custom;
            this.birth_textbox.CustomFormat = "yyyy-MM-dd";

            this.join_time_textbox.Format = DateTimePickerFormat.Custom;
            this.join_time_textbox.CustomFormat = "yyyy-MM-dd";
        }

        private void 修改党员信息_Load(object sender, EventArgs e)
        {
            this.name_textbox.Text = display_content.SubItems[1].Text.ToString();
            this.sex_textbox.Text = display_content.SubItems[2].Text.ToString();
            this.nationality_textbox.Text = display_content.SubItems[3].Text.ToString();
            this.birth_textbox.Text = display_content.SubItems[4].Text.ToString();
            this.join_time_textbox.Text = display_content.SubItems[5].Text.ToString();
            this.education_textbox.Text = display_content.SubItems[6].Text.ToString();
            this.workuint__textbox.Text = display_content.SubItems[7].Text.ToString();
            this.phone_textbox.Text = display_content.SubItems[8].Text.ToString();
        }

        private void confirm_modify_btn_Click(object sender, EventArgs e)
        {
            String update_sql = "UPDATE partMembers SET [name] = '" + this.name_textbox.Text + "',";
            update_sql += "[sex] = '" + this.sex_textbox.Text + "',";
            update_sql += "[nationality] = '" + this.nationality_textbox.Text + "',";
            update_sql += "[birth] = '" + this.birth_textbox.Text + "',";
            update_sql += "[joinTime] = '" + this.join_time_textbox.Text + "',";
            update_sql += "[education] = '" + this.education_textbox.Text + "',";
            update_sql += "[workUnit] = '" + this.workuint__textbox.Text + "',";
            update_sql += "[phone] = '" + this.phone_textbox.Text + "'";
            update_sql += "WHERE [ID] = " + display_content.SubItems[9].Text;

            new DataAccess().UpdateData(update_sql);

            MessageBox.Show("企业信息修改成功。");

            this.Close();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确认删除吗？", "提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                String delete_sql = "DELETE FROM partMembers WHERE [ID] = " + display_content.SubItems[9].Text;
                new DataAccess().DeleteData(delete_sql);

                MessageBox.Show("党员信息删除成功。");

                this.Close();
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class ModifyEnterpriseForm : Form
    {
        public ListViewItem display_content = null;
        string original_enterprise_name;

        public ModifyEnterpriseForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void ModifyEnterpriseForm_Load(object sender, EventArgs e)
        {
            this.enterprise_textbox.Text = display_content.Text;
            this.licence_textbox.Text = display_content.SubItems[1].Text.ToString();
            this.corporate_textbox.Text = display_content.SubItems[2].Text.ToString();
            this.enterprise_addr_textbox.Text = display_content.SubItems[3].Text.ToString();
            this.fundaccount_textbox.Text = display_content.SubItems[4].Text.ToString();
            this.contact_textbox.Text = display_content.SubItems[4].Text.ToString();

            original_enterprise_name = display_content.Text;
        }

        private void confirm_modify_btn_Click(object sender, EventArgs e)
        {
            String update_sql = "UPDATE enterprise SET [enterprise_name] = '" + this.enterprise_textbox.Text + "',";
            update_sql += "[licence_number] = '" + this.licence_textbox.Text + "',";
            update_sql += "[corporation] = '" + this.corporate_textbox.Text + "',";
            update_sql += "[enterprise_addr] = '" + this.enterprise_addr_textbox.Text + "',";
            update_sql += "[provident_found_number] = '" + this.fundaccount_textbox.Text + "',";
            update_sql += "[tel_number] = '" + this.contact_textbox.Text + "'";
            update_sql += "WHERE [enterprise_name] = '" + original_enterprise_name + "'";

            new DataAccess().UpdateData(update_sql);

            MessageBox.Show("企业信息修改成功。");

            this.Close();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确认删除吗？", "提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                String delete_sql = "DELETE FROM enterprise WHERE [enterprise_name] = '" + this.enterprise_textbox.Text + "'";
                new DataAccess().DeleteData(delete_sql);

                MessageBox.Show("企业信息删除成功。");

                this.Close();
            }
        }
    }
}
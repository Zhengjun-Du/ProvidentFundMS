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
    public partial class AddEnterpriseForm : Form
    {
        public AddEnterpriseForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void addEnterprise_btn_Click(object sender, EventArgs e)
        {
            if (this.enterpriseName_textbox.Text == "" ||
                this.licence_textbox.Text == "" ||
                this.corporation_textbox.Text == "" || 
                this.enterprise_addr_textbox.Text == "" || 
                this.provident_found_textbox.Text == "" ||
                this.telnumber_textbox.Text == "")
            {
                MessageBox.Show("页面有信息为空，请重新填写！");
                return;
            }

            String insert_sql = "INSERT INTO enterprise ([enterprise_name],[licence_number],[corporation],[enterprise_addr],[provident_found_number],[tel_number]) VALUES";
            insert_sql += "('" + this.enterpriseName_textbox.Text + "',"
                          + "'" + this.licence_textbox.Text + "',"
                          + "'" + this.corporation_textbox.Text + "',"
                          + "'" + this.enterprise_addr_textbox.Text + "',"
                          + "'" + this.provident_found_textbox.Text + "',"
                          + "'" + this.telnumber_textbox.Text + "')";

            new DataAccess().InsertData(insert_sql);

            MessageBox.Show("新增企业信息录入成功。");
            this.Close();
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

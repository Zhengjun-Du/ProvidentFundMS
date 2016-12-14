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
    public partial class 修改用户名密码 : Form
    {
        public 修改用户名密码()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void addEnterprise_btn_Click(object sender, EventArgs e)
        {

            if (currUsername_textBox.Text == "" ||
                currPassword_textBox.Text == "" ||
                newUsername_textBox.Text  == "" ||
                newPassword_textBox.Text  == "" ||
                confirm_textBox.Text == "")
            {
                MessageBox.Show("所有信息不能为空");
                return;
            }

            String selcet_sql = "select * from account where username = '" + currUsername_textBox.Text + "' and password = '" + currPassword_textBox.Text + "'";
            OleDbDataReader myReader = new DataAccess().SelectData(selcet_sql);
            if (myReader.Read())
            {
                if (confirm_textBox.Text != newPassword_textBox.Text)
                {
                    MessageBox.Show("两次输入密码不一致，请重新输入。");
                    return;
                }

                string s = myReader["id"].ToString();
                String update_sql = "UPDATE account SET [username] = '" + newUsername_textBox.Text + "', [password] = '" + newPassword_textBox.Text + "' WHERE id = " + myReader[0].ToString();
                new DataAccess().UpdateData(update_sql);

                MessageBox.Show("用户名或密码修改成功。");
            }
            else
            {
                MessageBox.Show("当前用户名或密码有误，请重新输入。");
            }
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

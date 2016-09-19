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
        private String sqlConn = null;
        OleDbConnection myConn = null;

        public 修改用户名密码()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            sqlConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= ../../database/ProvidentFundMS.mdb";
            myConn = new OleDbConnection(sqlConn);
            myConn.Open();
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
            OleDbCommand myComm = new OleDbCommand(selcet_sql, myConn);
            OleDbDataReader myReader = myComm.ExecuteReader();
            if (myReader.Read())
            {
                if (confirm_textBox.Text != newPassword_textBox.Text)
                {
                    MessageBox.Show("两次输入密码不一致，请重新输入。");
                    return;
                }

                string s = myReader["id"].ToString();
                String update_sql = "UPDATE account SET [username] = '" + newUsername_textBox.Text + "', [password] = '" + newPassword_textBox.Text + "' WHERE id = " + myReader[0].ToString();
                myComm = new OleDbCommand(update_sql, myConn);
                myComm.ExecuteNonQuery();

                MessageBox.Show("用户名或密码修改成功。");
            }
            else
            {
                MessageBox.Show("当前用户名或密码有误，请重新输入。");
            }
            myReader.Close();
            myConn.Close();
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

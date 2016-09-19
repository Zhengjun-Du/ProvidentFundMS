using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ProvidentFundMS
{
    public partial class 登录界面 : Form
    {
        private String sqlConn = null;
        OleDbConnection myConn;

        public 登录界面()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            sqlConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= ../../database/ProvidentFundMS.mdb";
            myConn = new OleDbConnection(sqlConn);
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            myConn.Open();
            String selcet_sql = "select * from account where username = '" + username_textbox.Text + "' and password = '" + password_textbox.Text+"'";
            OleDbCommand myComm = new OleDbCommand(selcet_sql, myConn); 
            OleDbDataReader myReader = myComm.ExecuteReader();
            if (myReader.Read())
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show("用户名或密码有误，请重新输入。");
            }
            myReader.Close();
            myConn.Close();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
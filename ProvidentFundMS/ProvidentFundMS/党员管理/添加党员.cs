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
    public partial class 添加党员 : Form
    {
        private String sqlConn = null;
        private OleDbConnection myConn = null;

        public 添加党员()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            sqlConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= ../../database/ProvidentFundMS.mdb";
            myConn = new OleDbConnection(sqlConn);
        }

        private void addPartMember_btn_Click(object sender, EventArgs e)
        {
            if (this.name_textbox.Text == "" ||
               this.sex_textbox.Text == "" ||
               this.nationality_textbox.Text == "" ||
               this.birth_textbox.Text == "" ||
               this.join_time_textbox.Text == "" ||
               this.education_textbox.Text == "" ||              
               this.workuint__textbox.Text == "" ||
               this.phone_textbox.Text == "")
            {
                MessageBox.Show("页面有信息为空，请重新填写！");
                return;
            }

            String insert_sql = "INSERT INTO partMembers ([name],[sex],[nationality],[birth],[joinTime],[education],[workUnit],[phone]) VALUES";
            insert_sql += "('" + this.name_textbox.Text + "',"
                          + "'" + this.sex_textbox.Text + "',"
                          + "'" + this.nationality_textbox.Text + "',"
                          + "'" + this.birth_textbox.Text + "',"
                          + "'" + this.join_time_textbox.Text + "',"
                          + "'" + this.education_textbox.Text + "',"
                          + "'" + this.workuint__textbox.Text + "',"
                          + "'" + this.phone_textbox.Text + "')";

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

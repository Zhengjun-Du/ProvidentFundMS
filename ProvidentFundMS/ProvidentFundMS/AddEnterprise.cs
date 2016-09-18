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
        private String sqlConn = null;
        OleDbConnection myConn;

        public AddEnterpriseForm()
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
            String insert_sql = "INSERT INTO enterprise ([enterprise_name],[licence_number],[corporation],[enterprise_addr],[provident_found_number],[tel_number]) VALUES";
            insert_sql += "('" + this.enterpriseName_textbox.Text + "',"
                          + "'" + this.licence_textbox.Text + "',"
                          + "'" + this.corporation_textbox.Text + "',"
                          + "'" + this.enterprise_addr_textbox.Text + "',"
                          + "'" + this.provident_found_textbox.Text + "',"
                          + "'" + this.telnumber_textbox.Text + "')";

            OleDbCommand myComm = new OleDbCommand(insert_sql, myConn);
            myComm.ExecuteNonQuery();

            MessageBox.Show("新增企业信息录入成功。");
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

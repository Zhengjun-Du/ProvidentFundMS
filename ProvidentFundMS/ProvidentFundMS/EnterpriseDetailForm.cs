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
    public partial class EnterpriseDetailForm : Form
    {
        private String sqlConn = null;
        private OleDbConnection myConn = null;
        public ListViewItem lv = null;

        public EnterpriseDetailForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.ProvidentFundDetail_ListView.GridLines = true;
            this.ProvidentFundDetail_ListView.FullRowSelect = true;

            sqlConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= ../../database/ProvidentFundMS.mdb";
            myConn = new OleDbConnection(sqlConn);
            myConn.Open();
        }

        private void EnterpriseDetailForm_Load(object sender, EventArgs e)
        {
            this.enterprise_label.Text = lv.SubItems[0].Text.ToString();
            this.provident_found_number_label.Text = lv.SubItems[3].Text.ToString();

            String selcet_sql  = "select e.enterprise_name, e.corporation, e.provident_found_number, e.licence_number,";
                   selcet_sql += "i.* from enterprise e, incomecost i where e.ID = i.enterprise_id and e.enterprise_name = '" + lv.SubItems[0].Text.ToString() + "'";

            OleDbCommand myComm = new OleDbCommand(selcet_sql, myConn);
            OleDbDataReader myReader = myComm.ExecuteReader();

            int i = 1;
            while (myReader.Read())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = (i++).ToString();
                lvi.SubItems.Add(myReader[5].ToString());
                lvi.SubItems.Add(myReader[6].ToString());
                lvi.SubItems.Add(myReader[7].ToString());
                lvi.SubItems.Add(myReader[8].ToString());
                lvi.SubItems.Add(myReader[9].ToString());
                lvi.SubItems.Add(myReader[10].ToString());

                this.ProvidentFundDetail_ListView.Items.Add(lvi);
            }
            this.ProvidentFundDetail_ListView.Refresh();
            myReader.Close();
        }

        private void modify_menu_Click(object sender, EventArgs e)
        {

        }

        private void delete_menu_Click(object sender, EventArgs e)
        {
            if (this.ProvidentFundDetail_ListView.SelectedIndices.Count > 0)
            {
                int index = this.ProvidentFundDetail_ListView.SelectedIndices[0];
                string enterprise_name = this.ProvidentFundDetail_ListView.SelectedItems[0].Text;

                DialogResult dr = MessageBox.Show("确认删除吗？", "提示", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    String delete_sql = "DELETE FROM enterprise WHERE [enterprise_name] = '" + enterprise_name + "'";
                    OleDbCommand myComm = new OleDbCommand(delete_sql, myConn);
                    myComm.ExecuteNonQuery();
                }
            }
        }
    }
}

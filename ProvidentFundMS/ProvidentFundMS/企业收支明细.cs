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
    public partial class 企业收支明细 : Form
    {
        private String sqlConn = null;
        private OleDbConnection myConn = null;
        public ListViewItem lv = null;

        public 企业收支明细()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.ProvidentFundDetail_ListView.GridLines = true;
            this.ProvidentFundDetail_ListView.FullRowSelect = true;

            sqlConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= ../../database/ProvidentFundMS.mdb";
            myConn = new OleDbConnection(sqlConn);
        }

        private void UpDataOfListView()
        {
            this.ProvidentFundDetail_ListView.Items.Clear();

            myConn.Open();
            String selcet_sql_0 = "SELECT remain FROM enterprise WHERE id=" + lv.SubItems[5].Text;
            OleDbCommand myComm = new OleDbCommand(selcet_sql_0, myConn);
            OleDbDataReader myReader = myComm.ExecuteReader();
            if (myReader.Read())
                this.remain_label.Text = myReader["remain"].ToString();



            String selcet_sql  = "SELECT e.enterprise_name,";
                   selcet_sql += "i.* FROM enterprise e, incomecost i WHERE e.ID = i.enterprise_id and e.enterprise_name = '" + lv.SubItems[0].Text.ToString() + "' order by i.date";

            myComm = new OleDbCommand(selcet_sql, myConn);
            myReader = myComm.ExecuteReader();

            int i = 1;
            while (myReader.Read())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = (i++).ToString();
                lvi.SubItems.Add(myReader["date"].ToString());
                lvi.SubItems.Add(myReader["abstract"].ToString());
                lvi.SubItems.Add(myReader["income"].ToString());
                lvi.SubItems.Add(myReader["cost"].ToString());
                lvi.SubItems.Add(myReader["remain"].ToString());
                lvi.SubItems.Add(myReader["operator"].ToString());

                this.ProvidentFundDetail_ListView.Items.Add(lvi);
            }
            this.ProvidentFundDetail_ListView.Refresh();

            myReader.Close();
            myConn.Close();
        }

        private void EnterpriseDetailForm_Load(object sender, EventArgs e)
        {
            this.enterprise_label.Text = lv.SubItems[0].Text.ToString();
            this.provident_found_number_label.Text = lv.SubItems[3].Text.ToString();

            UpDataOfListView();
        }


        private void ProvidentFundDetail_ListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            /*
            if (this.ProvidentFundDetail_ListView.SelectedIndices.Count > 0)
            {
                int index = this.ProvidentFundDetail_ListView.SelectedIndices[0];

                修改收支明细 modifyIEinfoFrom = new 修改收支明细();
                modifyIEinfoFrom.enterprise_name = this.enterprise_label.Text;
                modifyIEinfoFrom.provident_number = this.provident_found_number_label.Text;
                modifyIEinfoFrom.lv = this.ProvidentFundDetail_ListView.SelectedItems[0];

                modifyIEinfoFrom.ShowDialog();
                UpDataOfListView();
            }*/
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            添加收支记录 addIERecordForm = new 添加收支记录();
            addIERecordForm.enterprise_name = this.enterprise_label.Text;
            addIERecordForm.provident_number = this.provident_found_number_label.Text;
            addIERecordForm.lv = lv;
            addIERecordForm.ShowDialog();

            UpDataOfListView();
        }
    }
}
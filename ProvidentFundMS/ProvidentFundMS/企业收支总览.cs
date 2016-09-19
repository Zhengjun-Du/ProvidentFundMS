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
    public partial class 企业收支总览 : Form
    {
        private String sqlConn = null;
        private OleDbConnection myConn = null;

        public 企业收支总览()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.EnterPriseIEListView.GridLines = true;
            this.EnterPriseIEListView.FullRowSelect = true;

            sqlConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= ../../database/ProvidentFundMS.mdb";
            myConn = new OleDbConnection(sqlConn);
        }

        private void  UpdateDataOfListView()
        {
            this.EnterPriseIEListView.Items.Clear();

            myConn.Open();
            String selcet_sql = "select * from enterprise";
            OleDbCommand myComm = new OleDbCommand(selcet_sql, myConn);
            OleDbDataReader myReader = myComm.ExecuteReader();

            while (myReader.Read())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = myReader[1].ToString();
                lvi.SubItems.Add(myReader[3].ToString());
                lvi.SubItems.Add(myReader[6].ToString());
                lvi.SubItems.Add(myReader[5].ToString());
                lvi.SubItems.Add(myReader[7].ToString());

                this.EnterPriseIEListView.Items.Add(lvi);
            }

            myReader.Close();
            myConn.Close();
        }

        private void EnterpriseIEMForm_Load(object sender, EventArgs e)
        {
            UpdateDataOfListView();
        }

        private void EnterPriseIEListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.EnterPriseIEListView.SelectedIndices.Count > 0)
            {
                企业收支明细 enterpriseDetailForm = new 企业收支明细();
                enterpriseDetailForm.lv = this.EnterPriseIEListView.SelectedItems[0];
                enterpriseDetailForm.ShowDialog();
                UpdateDataOfListView();
            }
        }
    }
}
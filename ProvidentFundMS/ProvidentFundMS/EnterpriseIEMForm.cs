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
    public partial class EnterpriseIEMForm : Form
    {
        private String sqlConn = null;
        OleDbConnection myConn = null;

        public EnterpriseIEMForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.EnterPriseIEListView.GridLines = true;
            this.EnterPriseIEListView.FullRowSelect = true;

            sqlConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= ../../database/ProvidentFundMS.mdb";
            myConn = new OleDbConnection(sqlConn);
        }

        private void EnterpriseIEMForm_Load(object sender, EventArgs e)
        {
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
            this.EnterPriseIEListView.Refresh();
            myReader.Close();
            myConn.Close();
        }

        private void EnterPriseIEListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.EnterPriseIEListView.SelectedIndices.Count > 0)
            {
                EnterpriseDetailForm enterpriseDetailForm = new EnterpriseDetailForm();
                enterpriseDetailForm.lv = this.EnterPriseIEListView.SelectedItems[0];
                enterpriseDetailForm.ShowDialog();
            }
        }
    }
}
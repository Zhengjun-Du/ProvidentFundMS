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
        public 企业收支总览()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.EnterPriseIEListView.GridLines = true;
            this.EnterPriseIEListView.FullRowSelect = true;
        }

        private void  UpdateDataOfListView()
        {
            this.EnterPriseIEListView.Items.Clear();

            String selcet_sql = "select * from enterprise";
            OleDbDataReader myReader = new DataAccess().SelectData(selcet_sql);

            while (myReader.Read())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = myReader[1].ToString();
                lvi.SubItems.Add(myReader[3].ToString());
                lvi.SubItems.Add(myReader[6].ToString());
                lvi.SubItems.Add(myReader[5].ToString());
                lvi.SubItems.Add(((float)myReader[7]).ToString("0.00").PadLeft(10, ' '));
                lvi.SubItems.Add(myReader[0].ToString());

                this.EnterPriseIEListView.Items.Add(lvi);
            }
            myReader.Close();
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

        private void UpdateDataOfListViewBySearch(string search_str)
        {
            this.EnterPriseIEListView.Items.Clear();

            String selcet_sql = "select * from enterprise where enterprise_name like '%" + search_str + "%'";
            if (search_str == "")
                selcet_sql = "select * from enterprise";

            OleDbDataReader myReader = new DataAccess().SelectData(selcet_sql);

            while (myReader.Read())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = myReader[1].ToString();
                lvi.SubItems.Add(myReader[3].ToString());
                lvi.SubItems.Add(myReader[6].ToString());
                lvi.SubItems.Add(myReader[5].ToString());
                lvi.SubItems.Add(((float)myReader[7]).ToString("0.00").PadLeft(10, ' '));
                lvi.SubItems.Add(myReader[0].ToString());

                this.EnterPriseIEListView.Items.Add(lvi);
            }
            myReader.Close();
        }

        private void search_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {            
                 UpdateDataOfListViewBySearch(search_textbox.Text.Trim());
            }
        }

        private void all_enterprise_btn_Click(object sender, EventArgs e)
        {
            UpdateDataOfListView();
        }

        private void search_textbox_TextChanged(object sender, EventArgs e)
        {
            UpdateDataOfListViewBySearch(search_textbox.Text.Trim());
        }
    }
}
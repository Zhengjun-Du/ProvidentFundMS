﻿using System;
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
    public partial class 所有企业信息界面 : Form
    {
        public 所有企业信息界面()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            this.EnterPriseInfoListView.GridLines = true;
            this.EnterPriseInfoListView.FullRowSelect = true;
        }

        private void UpdateDataOfListView()
        {
            this.EnterPriseInfoListView.Items.Clear();

          
            String selcet_sql = "select * from enterprise";
            OleDbDataReader myReader = new DataAccess().SelectData(selcet_sql);

            while (myReader.Read())
            {
                string s1 = myReader[1].ToString();
                string s2 = myReader[2].ToString();
                string s3 = myReader[3].ToString();
                string s4 = myReader[4].ToString();
                string s5 = myReader[5].ToString();
                string s6 = myReader[6].ToString();

                ListViewItem lvi = new ListViewItem();
                lvi.Text = myReader[1].ToString();
                lvi.SubItems.Add(myReader[5].ToString());
                lvi.SubItems.Add(myReader[3].ToString());
                lvi.SubItems.Add(myReader[2].ToString());
                lvi.SubItems.Add(myReader[4].ToString());
                lvi.SubItems.Add(myReader[6].ToString());
                this.EnterPriseInfoListView.Items.Add(lvi);
            }

            myReader.Close();
        }

        private void EnterpriseInfoManageForm_Load(object sender, EventArgs e)
        {
            UpdateDataOfListView();
        }

        private void addEnterprise_btn_Click(object sender, EventArgs e)
        {
            AddEnterpriseForm addEnterpriseForm = new AddEnterpriseForm();
            addEnterpriseForm.ShowDialog();
            UpdateDataOfListView();
        }

        /*
        private void modify_enterpriseinfo_menu_Click(object sender, EventArgs e)
        {
            if (this.EnterPriseInfoListView.SelectedIndices.Count > 0)
            {
                ModifyEnterpriseForm modifyEnterpriseForm = new ModifyEnterpriseForm();
                modifyEnterpriseForm.display_content = this.EnterPriseInfoListView.SelectedItems[0];
                modifyEnterpriseForm.ShowDialog();
                UpdateDataOfListView();
            }
        }

        private void delete_enterprise_menu_Click(object sender, EventArgs e)
        {
            if (this.EnterPriseInfoListView.SelectedIndices.Count > 0)
            {
                int index = this.EnterPriseInfoListView.SelectedIndices[0];
                string enterprise_name = this.EnterPriseInfoListView.SelectedItems[0].Text;

                DialogResult dr = MessageBox.Show("确认删除吗？", "提示", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    String delete_sql = "DELETE FROM enterprise WHERE [enterprise_name] = '" + enterprise_name + "'";
                    new DataAccess().DeleteData(delete_sql);
                }
                UpdateDataOfListView();
            }
        }*/

        private void UpdateDataOfListViewBySearch(string search_str)
        {
            this.EnterPriseInfoListView.Items.Clear();


            String selcet_sql = "select * from enterprise where enterprise_name like '%" + search_str + "%'";
            if (search_str == "")
                selcet_sql = "select * from enterprise";

            OleDbDataReader myReader = new DataAccess().SelectData(selcet_sql);

            while (myReader.Read())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = myReader[1].ToString();
                lvi.SubItems.Add(myReader[2].ToString());
                lvi.SubItems.Add(myReader[3].ToString());
                lvi.SubItems.Add(myReader[5].ToString());
                lvi.SubItems.Add(myReader[4].ToString());
                lvi.SubItems.Add(myReader[6].ToString());
                this.EnterPriseInfoListView.Items.Add(lvi);
            }

            myReader.Close();
        }

        private void EnterPriseInfoListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.EnterPriseInfoListView.SelectedIndices.Count > 0)
            {
                //ModifyEnterpriseForm modifyEnterpriseForm = new ModifyEnterpriseForm();
                //modifyEnterpriseForm.display_content = this.EnterPriseInfoListView.SelectedItems[0];
                //modifyEnterpriseForm.ShowDialog();

                信息分类 infoCategoryForm = new 信息分类();
                infoCategoryForm.display_content = this.EnterPriseInfoListView.SelectedItems[0];
                infoCategoryForm.ShowDialog();
                UpdateDataOfListView();
            }
        }

        private void search_textbox_TextChanged(object sender, EventArgs e)
        {
            UpdateDataOfListViewBySearch(search_textbox.Text.Trim());
        }
    }
}
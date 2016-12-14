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
    public partial class 党员信息管理 : Form
    {
        private String sqlConn = null;
        private OleDbConnection myConn = null;
        private int partMemberID = 0;

        public 党员信息管理()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.partMemberListView.GridLines = true;
            this.partMemberListView.FullRowSelect = true;

            sqlConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= ../../database/ProvidentFundMS.mdb";
            myConn = new OleDbConnection(sqlConn);
        }

        private void 党员信息管理_Load(object sender, EventArgs e)
        {
            UpdateDataOfListView();
        }

        private void UpdateDataOfListView()
        {
            this.partMemberListView.Items.Clear();


            String selcet_sql = "select * from partMembers order by ID";
            OleDbDataReader myReader = new DataAccess().SelectData(selcet_sql);
            int i = 1;
            while (myReader.Read())
            {
                string s0 = (i++).ToString();
                string s1 = myReader["name"].ToString();
                string s2 = myReader["sex"].ToString();
                string s3 = myReader["nationality"].ToString();
                string s4 = ((DateTime)myReader["birth"]).ToString("yyy-MM-dd");
                string s5 = ((DateTime)myReader["joinTime"]).ToString("yyy-MM-dd");
                string s6 = myReader["education"].ToString();
                string s7 = myReader["workUnit"].ToString();
                string s8 = myReader["phone"].ToString();
                string s9 = myReader["ID"].ToString();

                ListViewItem lvi = new ListViewItem();
                lvi.Text = s0;
                lvi.SubItems.Add(s1);
                lvi.SubItems.Add(s2);
                lvi.SubItems.Add(s3);
                lvi.SubItems.Add(s4);
                lvi.SubItems.Add(s5);
                lvi.SubItems.Add(s6);
                lvi.SubItems.Add(s7);
                lvi.SubItems.Add(s8);
                lvi.SubItems.Add(s9);

                this.partMemberListView.Items.Add(lvi);
            }

            myReader.Close();
        }

        private void addPartMember_btn_Click(object sender, EventArgs e)
        {
            添加党员 addPartMemberForm = new 添加党员();
            addPartMemberForm.ShowDialog();
            UpdateDataOfListView();
        }

        private void partMemberListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.partMemberListView.SelectedIndices.Count > 0)
            {
                修改党员信息 modifyPartMemberForm = new 修改党员信息();
                modifyPartMemberForm.display_content = this.partMemberListView.SelectedItems[0];
                modifyPartMemberForm.ShowDialog();
                UpdateDataOfListView();
            }
        }

        private void UpdateDataOfListViewBySearch(string search_str)
        {
            this.partMemberListView.Items.Clear();


            String selcet_sql = "select * from partMembers where name like '%" + search_str + "%' order by ID";
            OleDbDataReader myReader = new DataAccess().SelectData(selcet_sql);
            int i = 1;
            while (myReader.Read())
            {
                string s0 = (i++).ToString();
                string s1 = myReader["name"].ToString();
                string s2 = myReader["sex"].ToString();
                string s3 = myReader["nationality"].ToString();
                string s4 = ((DateTime)myReader["birth"]).ToString("yyy-MM-dd");
                string s5 = ((DateTime)myReader["joinTime"]).ToString("yyy-MM-dd");
                string s6 = myReader["education"].ToString();
                string s7 = myReader["workUnit"].ToString();
                string s8 = myReader["phone"].ToString();
                string s9 = myReader["ID"].ToString();

                ListViewItem lvi = new ListViewItem();
                lvi.Text = s0;
                lvi.SubItems.Add(s1);
                lvi.SubItems.Add(s2);
                lvi.SubItems.Add(s3);
                lvi.SubItems.Add(s4);
                lvi.SubItems.Add(s5);
                lvi.SubItems.Add(s6);
                lvi.SubItems.Add(s7);
                lvi.SubItems.Add(s8);
                lvi.SubItems.Add(s9);

                this.partMemberListView.Items.Add(lvi);
            }

            myReader.Close();
        }

        private void search_textbox_TextChanged(object sender, EventArgs e)
        {
            UpdateDataOfListViewBySearch(search_textbox.Text.Trim());
        }
    }
}
 
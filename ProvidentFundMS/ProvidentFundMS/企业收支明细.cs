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
using System.Drawing.Printing;
using System.Collections;


namespace ProvidentFundMS
{
    public class IncomeCostInfo
    {
        public string index;
        public string date;
        public string abstract_;
        public string income;
        public string cost;
        public string remain;
        public string operator_;
    }

    public partial class 企业收支明细 : Form
    {
        private String sqlConn = null;
        private OleDbConnection myConn = null;
        public ListViewItem lv = null;
        PrintDocument myPrintDocument = new PrintDocument();
        打印范围 printRangeDlg = new 打印范围();;

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

            String selcet_sql_0 = "SELECT remain FROM enterprise WHERE id=" + lv.SubItems[5].Text;
            OleDbDataReader myReader = new DataAccess().SelectData(selcet_sql_0);
            if (myReader.Read())
                this.remain_label.Text = myReader["remain"].ToString();

            String selcet_sql  = "SELECT e.enterprise_name,i.* FROM enterprise e, incomecost i ";
            selcet_sql += " WHERE e.ID = i.enterprise_id and e.enterprise_name = '" + lv.SubItems[0].Text.ToString() + "'";
            selcet_sql += " ORDER BY i.date";
            myReader = new DataAccess().SelectData(selcet_sql);

            int i = 1;
            while (myReader.Read())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = (i++).ToString();
                lvi.SubItems.Add(((DateTime)myReader["date"]).ToString("yyyy-MM-dd HH:mm:ss"));
                lvi.SubItems.Add(myReader["abstract"].ToString());
                lvi.SubItems.Add(((float)myReader["income"]).ToString("0.00").PadLeft(10,' '));
                lvi.SubItems.Add(((float)myReader["cost"]).ToString("0.00").PadLeft(10, ' '));
                lvi.SubItems.Add(((float)myReader["remain"]).ToString("0.00").PadLeft(10, ' '));
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

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            ArrayList IncomeCostInfos = new ArrayList();

            String selcet_sql = "SELECT e.enterprise_name,i.* FROM enterprise e, incomecost i ";
            selcet_sql += " WHERE e.ID = i.enterprise_id and e.enterprise_name = '" + lv.SubItems[0].Text.ToString() + "'";
            selcet_sql += " ORDER BY i.date";
            OleDbDataReader myReader = new DataAccess().SelectData(selcet_sql);
            int itemIndex = 1;
            while (myReader.Read())
            {
                IncomeCostInfo incomecoatInfo = new IncomeCostInfo();

                incomecoatInfo.index = (itemIndex++).ToString();
                incomecoatInfo.date = ((DateTime)myReader["date"]).ToString("yyyy-MM-dd");
                incomecoatInfo.abstract_ = myReader["abstract"].ToString();
                incomecoatInfo.income = ((float)myReader["income"]).ToString("0.00").PadLeft(10,' ');
                incomecoatInfo.cost = ((float)myReader["cost"]).ToString("0.00").PadLeft(10, ' ');
                incomecoatInfo.remain = ((float)myReader["remain"]).ToString("0.00").PadLeft(10, ' ');
                incomecoatInfo.operator_ = myReader["operator"].ToString();

                IncomeCostInfos.Add(incomecoatInfo);
            }
            
            myReader.Close();
            myConn.Close();

            if(IncomeCostInfos.Count == 0) return;

            int startItemIndex = IncomeCostInfos.Count -1;
            int endItemIndex = IncomeCostInfos.Count -1;
            if(printRangeDlg.selctedItem == 1)
                startItemIndex = 0;
            else if(printRangeDlg.selctedItem == 2)
            {
                startItemIndex = printRangeDlg.startItemIndex;
                endItemIndex = printRangeDlg.endItemIndex;
            }

            for(int i = startItemIndex; i <= endItemIndex; i++)
            {
                e.Graphics.DrawString(((IncomeCostInfo)IncomeCostInfos[i]).index, new Font(new FontFamily("黑体"), 11), System.Drawing.Brushes.Black, 0, 20*i);
                e.Graphics.DrawString(((IncomeCostInfo)IncomeCostInfos[i]).date, new Font(new FontFamily("黑体"), 11), System.Drawing.Brushes.Black, 80, 20 * i);
                e.Graphics.DrawString(((IncomeCostInfo)IncomeCostInfos[i]).abstract_, new Font(new FontFamily("黑体"), 11), System.Drawing.Brushes.Black, 200, 20 * i);
                e.Graphics.DrawString(((IncomeCostInfo)IncomeCostInfos[i]).income, new Font(new FontFamily("黑体"), 11), System.Drawing.Brushes.Black, 300, 20 * i);
                e.Graphics.DrawString(((IncomeCostInfo)IncomeCostInfos[i]).cost, new Font(new FontFamily("黑体"), 11), System.Drawing.Brushes.Black, 450, 20 * i);
                e.Graphics.DrawString(((IncomeCostInfo)IncomeCostInfos[i]).remain, new Font(new FontFamily("黑体"), 11), System.Drawing.Brushes.Black, 550, 20 * i);
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            myPrintDocument.PrintPage += new PrintPageEventHandler(this.printDocument2_PrintPage);
            printPreviewDialog1.Document = myPrintDocument;
            printDialog1.Document = myPrintDocument;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
                myPrintDocument.Print();
        }

        private void printSet_btn_Click(object sender, EventArgs e)
        {
            printRangeDlg.ShowDialog();
        }
    }
}
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
    public partial class 企业收支明细 : Form
    {
        private String sqlConn = null;
        private OleDbConnection myConn = null;
        public ListViewItem lv = null;
        PrintDocument myPrintDocument = new PrintDocument();
        打印范围 printRangeDlg = new 打印范围();

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

            //默认为0：即打印当前记录，1：打印全部记录，2：自选范围
            int startItemIndex = IncomeCostInfos.Count -1;
            int endItemIndex = IncomeCostInfos.Count -1;
            if(printRangeDlg.selctedItem == 1)
                startItemIndex = 0;
            else if(printRangeDlg.selctedItem == 2)
            {
                startItemIndex = printRangeDlg.startItemIndex-1;
                endItemIndex = printRangeDlg.endItemIndex-1;
            }

            //如果选的记录索引大于最大记录数目，则按记录实际数目为准
            if (endItemIndex + 1 >= IncomeCostInfos.Count) endItemIndex = IncomeCostInfos.Count - 1;
            for(int i = startItemIndex; i <= endItemIndex; i++)
            {
                int rowIndex = i - startItemIndex;
                IncomeCostInfo currRecord = (IncomeCostInfo)IncomeCostInfos[i];
                e.Graphics.DrawString(currRecord.index,     new Font(new FontFamily("宋体"), 11), Brushes.Black, 30,  50 + 20 * rowIndex);
                e.Graphics.DrawString(currRecord.date,      new Font(new FontFamily("宋体"), 11), Brushes.Black, 80,  50 + 20 * rowIndex);
                e.Graphics.DrawString(currRecord.abstract_, new Font(new FontFamily("宋体"), 11), Brushes.Black, 180, 50 + 20 * rowIndex);
                e.Graphics.DrawString(currRecord.income,    new Font(new FontFamily("宋体"), 11), Brushes.Black, 280, 50 + 20 * rowIndex);
                e.Graphics.DrawString(currRecord.cost,      new Font(new FontFamily("宋体"), 11), Brushes.Black, 380, 50 + 20 * rowIndex);
                e.Graphics.DrawString(currRecord.remain,    new Font(new FontFamily("宋体"), 11), Brushes.Black, 480, 50 + 20 * rowIndex);
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            myPrintDocument.PrintPage += new PrintPageEventHandler(this.printDocument2_PrintPage);
            printDialog1.Document = myPrintDocument;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
                myPrintDocument.Print();
        }

        private void printSet_btn_Click(object sender, EventArgs e)
        {
            printRangeDlg.ShowDialog();
        }

        private void preViewBtn_Click(object sender, EventArgs e)
        {
            myPrintDocument.PrintPage += new PrintPageEventHandler(this.printDocument2_PrintPage);
            printPreviewDialog.Document = myPrintDocument;
            ((Form)(printPreviewDialog)).WindowState = FormWindowState.Maximized;
            printPreviewDialog.PrintPreviewControl.Zoom = 1.5;
            printPreviewDialog.ShowDialog();
        }
    }

    //显示的报表信息
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
}
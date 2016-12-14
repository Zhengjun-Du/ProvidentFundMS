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
        private const int ALL_NOT_PRINTED_RECORDS = 0;
        private const int ALL_RECORDS = 1;
        private const int PRINT = 0;
        private const int PRINT_PREVIEW = 1;

        private String sqlConn = null;
        private OleDbConnection myConn = null;
        public ListViewItem lv = null;
        private 打印范围对话框 printRangeDlg = new 打印范围对话框();
        private int currentPrintRowIndex = 0;
        private int printOrPreview = PRINT_PREVIEW;
        private List<IncomeCostRecord> AllIncomeCostRecords = new List<IncomeCostRecord>();
        private List<IncomeCostRecord> ToPrintIncomeCostRecords = new List<IncomeCostRecord>();

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
            this.AllIncomeCostRecords.Clear();

            String selcet_sql_0 = "SELECT remain FROM enterprise WHERE id=" + lv.SubItems[5].Text;
            OleDbDataReader myReader = new DataAccess().SelectData(selcet_sql_0);
            if (myReader.Read())
                this.remain_label.Text = myReader["remain"].ToString();

            String selcet_sql = "SELECT e.enterprise_name,i.* FROM enterprise e, incomecost i ";
            selcet_sql += " WHERE e.ID = i.enterprise_id and e.enterprise_name = '" + lv.SubItems[0].Text.ToString() + "'";
            selcet_sql += " ORDER BY i.date";
            myReader = new DataAccess().SelectData(selcet_sql);

            int i = 0;
            while (myReader.Read())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = (i+1).ToString();
                lvi.SubItems.Add(((DateTime)myReader["date"]).ToString("yyyyMMdd"));
                lvi.SubItems.Add(myReader["abstract"].ToString());
                lvi.SubItems.Add(((float)myReader["income"]).ToString("0.00").PadLeft(10, ' '));
                lvi.SubItems.Add(((float)myReader["cost"]).ToString("0.00").PadLeft(10, ' '));
                lvi.SubItems.Add(((float)myReader["remain"]).ToString("0.00").PadLeft(10, ' '));
                lvi.SubItems.Add(myReader["operator"].ToString());
                this.ProvidentFundDetail_ListView.Items.Add(lvi);

                IncomeCostRecord incomecoatrecord = new IncomeCostRecord();
                incomecoatrecord.record_id = (int)myReader["ID"];
                incomecoatrecord.seqnum = (i).ToString();
                incomecoatrecord.date = ((DateTime)myReader["date"]).ToString("yyyyMMdd");
                incomecoatrecord.abstract_ = myReader["abstract"].ToString();
                incomecoatrecord.income = ((float)myReader["income"]).ToString("0.00").PadLeft(10, ' ');
                incomecoatrecord.cost = ((float)myReader["cost"]).ToString("0.00").PadLeft(10, ' ');
                incomecoatrecord.remain = ((float)myReader["remain"]).ToString("0.00").PadLeft(10, ' ');
                incomecoatrecord.operator_ = myReader["operator"].ToString();
                incomecoatrecord.printed = (myReader["printed"].ToString() == "False") ? false : true;
                this.AllIncomeCostRecords.Add(incomecoatrecord);

                i++;
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

        private void printSet_btn_Click(object sender, EventArgs e)
        {
            printRangeDlg.ShowDialog();
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            PrintController printController = new PrintController(ToPrintIncomeCostRecords, printOrPreview);
            currentPrintRowIndex = printController.OutputIncomeCostRecords(e, currentPrintRowIndex);
        }

        //打印按钮事件
        private void print_btn_Click(object sender, EventArgs e)
        { 
            if (ALL_NOT_PRINTED_RECORDS == printRangeDlg.selctedItem)
            {
                ToPrintIncomeCostRecords = (from IncomeCostRecord item in AllIncomeCostRecords where item.printed == false select item).ToList();
                if (ToPrintIncomeCostRecords.Count == 0)
                {
                    MessageBox.Show("没有未打印的数据！"); 
                    return;
                }
            }
            else
            {
                ToPrintIncomeCostRecords = AllIncomeCostRecords;
                if (ToPrintIncomeCostRecords.Count == 0)
                {
                    MessageBox.Show("没有数据！"); 
                    return;
                }
            }

            printOrPreview = PRINT;
            currentPrintRowIndex = Convert.ToInt32(ToPrintIncomeCostRecords[0].seqnum);
            PrintDocument myPrintDocument = new PrintDocument();
            //myPrintDocument.DefaultPageSettings.PaperSize = new PaperSize("Custum", 500, 300);
            myPrintDocument.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1170);
            myPrintDocument.PrintPage += new PrintPageEventHandler(this.printDocument2_PrintPage);
            printDialog.Document = myPrintDocument;
            DialogResult result = printDialog.ShowDialog();
            if (result == DialogResult.OK)
                myPrintDocument.Print();
        }

        //打印预览按钮事件
        private void preViewBtn_Click(object sender, EventArgs e)
        {
            if (ALL_NOT_PRINTED_RECORDS == printRangeDlg.selctedItem)
            {
                ToPrintIncomeCostRecords = (from IncomeCostRecord item in AllIncomeCostRecords where item.printed == false select item).ToList();
                if (ToPrintIncomeCostRecords.Count == 0)
                {
                    MessageBox.Show("没有未打印的数据！"); 
                    return;
                }
            }
            else
            {
                ToPrintIncomeCostRecords = AllIncomeCostRecords;
                if (ToPrintIncomeCostRecords.Count == 0)
                {
                    MessageBox.Show("没有数据！");  
                    return;
                }
            }

            printOrPreview = PRINT_PREVIEW;            
            currentPrintRowIndex = Convert.ToInt32(ToPrintIncomeCostRecords[0].seqnum);
            PrintDocument myPrintDocument = new PrintDocument();
           // myPrintDocument.DefaultPageSettings.PaperSize = new PaperSize("Custum",500,300);
            myPrintDocument.DefaultPageSettings.PaperSize = new PaperSize("A4",827, 1170);
            myPrintDocument.PrintPage += new PrintPageEventHandler(this.printDocument2_PrintPage);
            printPreviewDialog.Document = myPrintDocument;
            ((Form)(printPreviewDialog)).WindowState = FormWindowState.Maximized;
            printPreviewDialog.PrintPreviewControl.Zoom = 1.5;
            printPreviewDialog.ShowDialog();
        }
    }
}
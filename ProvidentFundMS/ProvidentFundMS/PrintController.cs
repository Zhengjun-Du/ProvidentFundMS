using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentFundMS
{
    class PrintController
    {
        private const int PRINT = 0;
        private const int PRINT_PREVIEW = 1;

        public List<IncomeCostRecord> toPrintIncomeCostRecords = null;
        public int printOrPreview = PRINT_PREVIEW;
        public int itemsInApage = 52;
        public int lastSeqNum = 0;
        public string enterprise_name;

        public PrintController(List<IncomeCostRecord> toPrintIncomeCostRecords_, int printOrPreview_)
        {
            toPrintIncomeCostRecords = toPrintIncomeCostRecords_;
            printOrPreview = printOrPreview_;

            lastSeqNum = Convert.ToInt32(toPrintIncomeCostRecords[toPrintIncomeCostRecords.Count - 1].seqnum);
        }

        public PrintController()
        {
        }

        public int OutputIncomeCostRecords(System.Drawing.Printing.PrintPageEventArgs e, int startSeqNum)
        {
            if (startSeqNum > lastSeqNum)
            {
                e.HasMorePages = false;
                return -1;
            }

            int endSeqNum = ((startSeqNum / itemsInApage) + 1) * itemsInApage;
            if (endSeqNum > lastSeqNum)
                endSeqNum = lastSeqNum + 1;

            for (int i = 0; i < toPrintIncomeCostRecords.Count; i++)
            {
                IncomeCostRecord currRecord = (IncomeCostRecord)toPrintIncomeCostRecords[i];
                int currRecordSeqNum = Convert.ToInt32(currRecord.seqnum);

                if (startSeqNum <= currRecordSeqNum && currRecordSeqNum < endSeqNum)
                {
                    int rowIndexOfPage = currRecordSeqNum % itemsInApage + 1;
                    int seqno = Convert.ToInt32(currRecord.seqnum);

                    if (seqno == startSeqNum)
                    {
                        Font title_font = new Font(new FontFamily("宋体"), 12,FontStyle.Bold);
                        e.Graphics.DrawString(enterprise_name+" 收支明细对账单", title_font, Brushes.Black, 200, 40);

                        Font head_font = new Font(new FontFamily("宋体"), 10, FontStyle.Bold);
                        e.Graphics.DrawString("序号", head_font, Brushes.Black, 90, 95);
                        e.Graphics.DrawString("记账日期", head_font, Brushes.Black, 150, 95);
                        e.Graphics.DrawString("摘    要", head_font, Brushes.Black, 250, 95);
                        e.Graphics.DrawString("存     入", head_font, Brushes.Black, 355, 95);
                        e.Graphics.DrawString("支     出", head_font, Brushes.Black, 455, 95);
                        e.Graphics.DrawString("余     额", head_font, Brushes.Black, 555, 95);
                        e.Graphics.DrawString("经办人", head_font, Brushes.Black, 660, 95);
                    }

                   Font font = new Font(new FontFamily("宋体"), 10);
                   e.Graphics.DrawString((seqno+1).ToString(), font, Brushes.Black, 100, 100 + 20 * rowIndexOfPage);
                   e.Graphics.DrawString(currRecord.date, font, Brushes.Black, 152, 100 + 20 * rowIndexOfPage);
                   e.Graphics.DrawString(currRecord.abstract_, font, Brushes.Black, 250, 100 + 20 * rowIndexOfPage);
                   e.Graphics.DrawString(currRecord.income, font, Brushes.Black, 352, 100 + 20 * rowIndexOfPage);
                   e.Graphics.DrawString(currRecord.cost, font, Brushes.Black, 452, 100 + 20 * rowIndexOfPage);
                   e.Graphics.DrawString(currRecord.remain, font, Brushes.Black, 552, 100 + 20 * rowIndexOfPage);
                   e.Graphics.DrawString(currRecord.operator_, font, Brushes.Black, 660, 100 + 20 * rowIndexOfPage);
                   
                    /*
                     for (int j = 0; j < 50; j++)
                     {
                         rowIndexOfPage = j + 1;
                        
                         e.Graphics.DrawString(rowIndexOfPage.ToString(), font, Brushes.Black, 100, 100 + 20 * rowIndexOfPage);
                         e.Graphics.DrawString(currRecord.date, font, Brushes.Black, 152, 100 + 20 * rowIndexOfPage);
                         e.Graphics.DrawString(currRecord.abstract_, font, Brushes.Black, 250, 100 + 20 * rowIndexOfPage);
                         e.Graphics.DrawString("999999.00", font, Brushes.Black, 352, 100 + 20 * rowIndexOfPage);
                         e.Graphics.DrawString("999999.00", font, Brushes.Black, 452, 100 + 20 * rowIndexOfPage);
                         e.Graphics.DrawString("999999.00", font, Brushes.Black, 552, 100 + 20 * rowIndexOfPage);
                         e.Graphics.DrawString("杜正君", font, Brushes.Black, 642, 100 + 20 * rowIndexOfPage);
                     }
                     return 50;
                     * 
                     */ 
                    

                    if (PRINT == printOrPreview)
                    {
                        String update_sql = "UPDATE incomecost SET [printed] = -1 WHERE [ID] = " + currRecord.record_id;
                        new DataAccess().UpdateData(update_sql);
                    }
                }

                else
                    continue;
            }
     
            if (endSeqNum <= lastSeqNum)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;

            return endSeqNum;
        }
    }
}
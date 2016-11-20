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
        public List<IncomeCostRecord> toPrintIncomeCostRecords = null;
        public bool printOrPreview = false;
        public int itemsInApage = 3;
        public int lastSeqNum = 0;

        public PrintController(List<IncomeCostRecord> toPrintIncomeCostRecords_, bool printOrPreview_)
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
                    int rowIndexOfPage = currRecordSeqNum % itemsInApage;

                    Font font = new Font(new FontFamily("宋体"), 11);
                    e.Graphics.DrawString(currRecord.date, font,        Brushes.Black, 80,  50 + 20 * rowIndexOfPage);
                    e.Graphics.DrawString(currRecord.abstract_, font,   Brushes.Black, 180, 50 + 20 * rowIndexOfPage);
                    e.Graphics.DrawString(currRecord.income, font,      Brushes.Black, 280, 50 + 20 * rowIndexOfPage);
                    e.Graphics.DrawString(currRecord.cost, font,        Brushes.Black, 380, 50 + 20 * rowIndexOfPage);
                    e.Graphics.DrawString(currRecord.remain, font,      Brushes.Black, 480, 50 + 20 * rowIndexOfPage);

                    if (printOrPreview)
                    {
                        String update_sql = "UPDATE incomecost SET [printed] = -1 WHERE [ID] = " + currRecord.record_id;
                        new DataAccess().UpdateData(update_sql);
                    }
                }
            }
     
            if (endSeqNum <= lastSeqNum)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;

            return endSeqNum;
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvidentFundMS
{
    public partial class EnterpriseDetailForm : Form
    {
        public EnterpriseDetailForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.listView1.GridLines = true;
            this.listView1.FullRowSelect = true;
        }

        private void EnterpriseDetailForm_Load(object sender, EventArgs e)
        {

            ListViewItem[] listViewItems = new ListViewItem[10];
            for (int i = 0; i < 10; i++)
            {
                listViewItems[i] = new ListViewItem(new string[] {
            (i+1).ToString(),
            "2016.09.01",
            "管理中心转入",
            "5000",
            "",
            "5000",
            "管理员"}, -1);
            }

            this.listView1.Items.AddRange(listViewItems);
        }
    }
}

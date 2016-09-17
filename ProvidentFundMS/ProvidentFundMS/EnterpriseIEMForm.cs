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
    public partial class EnterpriseIEMForm : Form
    {
        public EnterpriseIEMForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.EnterPriseIEListView.GridLines = true;
            this.EnterPriseIEListView.FullRowSelect = true;
        }

        private void EnterpriseIEMForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.ImageIndex = i;
                lvi.Text = "青海君东信息科技有限责任公司";
                lvi.SubItems.Add("杜正君");
                lvi.SubItems.Add("13897408428");
                lvi.SubItems.Add("513721198910176312");
                lvi.SubItems.Add("5000");

                this.EnterPriseIEListView.Items.Add(lvi);
            }
        }

        private void EnterPriseIEListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EnterpriseDetailForm enterpriseDetailForm = new EnterpriseDetailForm();
            enterpriseDetailForm.ShowDialog();
        }
    }
}

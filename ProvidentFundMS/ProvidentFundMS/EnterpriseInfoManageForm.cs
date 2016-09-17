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
    public partial class EnterpriseInfoManageForm : Form
    {
        public EnterpriseInfoManageForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            this.EnterPriseInfoListView.GridLines = true;
            this.EnterPriseInfoListView.FullRowSelect = true;
        }

        private void EnterpriseInfoManageForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 30; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.ImageIndex = i;
                lvi.Text = "青海君东信息科技有限责任公司";
                lvi.SubItems.Add("20168888888XYZW");
                lvi.SubItems.Add("杜正君");
                lvi.SubItems.Add("513721198910176312");
                lvi.SubItems.Add("青海省西宁市城北区生物园区");
                lvi.SubItems.Add("13897408428");

                this.EnterPriseInfoListView.Items.Add(lvi);
            }
        }

        private void addEnterprise_btn_Click(object sender, EventArgs e)
        {
            AddEnterpriseForm addEnterpriseForm = new AddEnterpriseForm();
            addEnterpriseForm.ShowDialog();
        }
    }
}

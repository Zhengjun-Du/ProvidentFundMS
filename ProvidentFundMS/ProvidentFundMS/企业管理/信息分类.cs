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
    public partial class 信息分类 : Form
    {
        public ListViewItem display_content = null;
        public string enterprise_name;

        public 信息分类()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void partyMemberBtn_Click(object sender, EventArgs e)
        {
            党员信息管理 partyMemberForm = new 党员信息管理();
            partyMemberForm.enterprise_name = display_content.SubItems[0].Text.ToString();
            partyMemberForm.ShowDialog();
        }

        private void addEnterprise_btn_Click(object sender, EventArgs e)
        {
            ModifyEnterpriseForm modifyEnterpriseForm = new ModifyEnterpriseForm();
            modifyEnterpriseForm.display_content = display_content;
            modifyEnterpriseForm.ShowDialog();
        }
    }
}

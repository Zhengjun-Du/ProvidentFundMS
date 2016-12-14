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
    public partial class 主界面 : Form
    {
        public 主界面()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void addEnterprise_btn_Click(object sender, EventArgs e)
        {
            所有企业信息界面 enterpriseInfoManageForm = new 所有企业信息界面();
            enterpriseInfoManageForm.ShowDialog();
        }

        private void enterpriseIEM_btn_Click(object sender, EventArgs e)
        {
            企业收支总览 enterpriseIEMForm = new 企业收支总览();
            enterpriseIEMForm.ShowDialog();
        }

        private void modifyAccount_btn_Click(object sender, EventArgs e)
        {
            修改用户名密码 accountMangaForm = new 修改用户名密码();
            accountMangaForm.ShowDialog();
        }

        private void partyMemberBtn_Click(object sender, EventArgs e)
        {
            党员信息管理 partyMemberForm = new 党员信息管理();
            partyMemberForm.ShowDialog();
        }
    }
}
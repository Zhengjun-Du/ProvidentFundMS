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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void addEnterprise_btn_Click(object sender, EventArgs e)
        {
            AddEnterpriseForm addEnterpriseForm = new AddEnterpriseForm();
            addEnterpriseForm.Show();
        }

        private void enterpriseIEM_btn_Click(object sender, EventArgs e)
        {
            EnterpriseIEMForm enterpriseIEMForm = new EnterpriseIEMForm();
            enterpriseIEMForm.Show();
        }

        private void enterpriseInfoSearch_btn_Click(object sender, EventArgs e)
        {
            EnterpriseInfoForm enterpriseInfoForm = new EnterpriseInfoForm();
            enterpriseInfoForm.Show();
        }
    }
}
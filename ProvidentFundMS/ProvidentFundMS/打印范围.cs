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
    public partial class 打印范围对话框 : Form
    {
        public int selctedItem = 0;

        public 打印范围对话框()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void radioBtn_curr_Click(object sender, EventArgs e)
        {
            selctedItem = 0;
        }

        private void radioBtn_all_CheckedChanged(object sender, EventArgs e)
        {
            selctedItem = 1;
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

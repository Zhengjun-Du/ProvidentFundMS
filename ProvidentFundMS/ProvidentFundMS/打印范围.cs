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
    public partial class 打印范围 : Form
    {
        public int selctedItem = 0;
        public int startItemIndex = 1;
        public int endItemIndex = 1;

        public 打印范围()
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

        private void radioBtn_setrange_CheckedChanged(object sender, EventArgs e)
        {
            selctedItem = 2;
        }

        private void numericUpDown_start_ValueChanged(object sender, EventArgs e)
        {
            startItemIndex = Convert.ToInt32(numericUpDown_start.Value);
        }

        private void numericUpDown_end_ValueChanged(object sender, EventArgs e)
        {
            endItemIndex = Convert.ToInt32(numericUpDown_end.Value);
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

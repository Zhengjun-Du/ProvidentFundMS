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
    public partial class EnterpriseInfoForm : Form
    {
        private Button button = new Button();

        public EnterpriseInfoForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.EnterPriseInfoListView.HeaderStyle = ColumnHeaderStyle.Clickable;
        }

        private void EnterpriseInfoForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 30; i++)   //添加10行数据 
            {
                ListViewItem lvi = new ListViewItem();

                lvi.ImageIndex = i;     //通过与imageList绑定，显示imageList中第i项图标 

                lvi.Text = "青海君东信息科技有限责任公司" + i;
                lvi.SubItems.Add("杜正君");
                lvi.SubItems.Add("13897408428");
                lvi.SubItems.Add("513721198910176312");
                lvi.SubItems.Add("5000");

                this.EnterPriseInfoListView.Items.Add(lvi);

               
            }

            button.Visible = false;
            button.Text = "...";
            //button.Click += this.button_Click;  
            this.EnterPriseInfoListView.Controls.Add(button);
            this.button.Size = new Size(this.EnterPriseInfoListView.Items[0].SubItems[4].Bounds.Width,
                                        this.EnterPriseInfoListView.Items[0].SubItems[4].Bounds.Height);

        }

        private void EnterPriseInfoListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.button.Location = new Point(this.EnterPriseInfoListView.SelectedItems[0].SubItems[4].Bounds.Left,
            this.EnterPriseInfoListView.SelectedItems[0].SubItems[4].Bounds.Top);
            this.button.Visible = true;  
        }
    }
}

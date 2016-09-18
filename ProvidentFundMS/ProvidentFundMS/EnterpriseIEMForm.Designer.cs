namespace ProvidentFundMS
{
    partial class EnterpriseIEMForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.EnterPriseIEListView = new System.Windows.Forms.ListView();
            this.name_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.corporate_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contact_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fundaccount_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.remainder_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 52);
            this.label1.TabIndex = 4;
            this.label1.Text = "企业收支管理";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnterPriseIEListView
            // 
            this.EnterPriseIEListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name_title,
            this.corporate_title,
            this.contact_title,
            this.fundaccount_title,
            this.remainder_title});
            this.EnterPriseIEListView.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EnterPriseIEListView.Location = new System.Drawing.Point(19, 71);
            this.EnterPriseIEListView.Margin = new System.Windows.Forms.Padding(10);
            this.EnterPriseIEListView.Name = "EnterPriseIEListView";
            this.EnterPriseIEListView.Size = new System.Drawing.Size(866, 526);
            this.EnterPriseIEListView.TabIndex = 9;
            this.EnterPriseIEListView.UseCompatibleStateImageBehavior = false;
            this.EnterPriseIEListView.View = System.Windows.Forms.View.Details;
            this.EnterPriseIEListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.EnterPriseIEListView_MouseDoubleClick);
            // 
            // name_title
            // 
            this.name_title.Text = "企业名称";
            this.name_title.Width = 250;
            // 
            // corporate_title
            // 
            this.corporate_title.Text = "企业法人";
            this.corporate_title.Width = 114;
            // 
            // contact_title
            // 
            this.contact_title.Text = "联系方式";
            this.contact_title.Width = 135;
            // 
            // fundaccount_title
            // 
            this.fundaccount_title.Text = "公积金账号";
            this.fundaccount_title.Width = 190;
            // 
            // remainder_title
            // 
            this.remainder_title.Text = "公积金余额";
            this.remainder_title.Width = 130;
            // 
            // EnterpriseIEMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 647);
            this.Controls.Add(this.EnterPriseIEListView);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EnterpriseIEMForm";
            this.Text = "城西区环新宁广场商圈党建公积金管理系统";
            this.Load += new System.EventHandler(this.EnterpriseIEMForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView EnterPriseIEListView;
        private System.Windows.Forms.ColumnHeader name_title;
        private System.Windows.Forms.ColumnHeader corporate_title;
        private System.Windows.Forms.ColumnHeader contact_title;
        private System.Windows.Forms.ColumnHeader fundaccount_title;
        private System.Windows.Forms.ColumnHeader remainder_title;
    }
}
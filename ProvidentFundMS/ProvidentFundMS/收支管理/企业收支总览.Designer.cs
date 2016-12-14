namespace ProvidentFundMS
{
    partial class 企业收支总览
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(企业收支总览));
            this.label1 = new System.Windows.Forms.Label();
            this.EnterPriseIEListView = new System.Windows.Forms.ListView();
            this.name_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.corporate_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contact_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fundaccount_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.remainder_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.enterprise_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(10, 4);
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
            this.remainder_title,
            this.enterprise_id});
            this.EnterPriseIEListView.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EnterPriseIEListView.Location = new System.Drawing.Point(19, 109);
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
            this.fundaccount_title.Width = 209;
            // 
            // remainder_title
            // 
            this.remainder_title.Text = "公积金余额";
            this.remainder_title.Width = 154;
            // 
            // enterprise_id
            // 
            this.enterprise_id.Text = "";
            this.enterprise_id.Width = 0;
            // 
            // search_textbox
            // 
            this.search_textbox.Font = new System.Drawing.Font("宋体", 14F);
            this.search_textbox.Location = new System.Drawing.Point(156, 61);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(375, 29);
            this.search_textbox.TabIndex = 10;
            this.search_textbox.TextChanged += new System.EventHandler(this.search_textbox_TextChanged);
            this.search_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_textbox_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(19, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "按名称搜索:";
            // 
            // 企业收支总览
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 647);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search_textbox);
            this.Controls.Add(this.EnterPriseIEListView);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "企业收支总览";
            this.Text = "城西区环新宁广场商圈党建公积金管理系统";
            this.Load += new System.EventHandler(this.EnterpriseIEMForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView EnterPriseIEListView;
        private System.Windows.Forms.ColumnHeader name_title;
        private System.Windows.Forms.ColumnHeader corporate_title;
        private System.Windows.Forms.ColumnHeader contact_title;
        private System.Windows.Forms.ColumnHeader fundaccount_title;
        private System.Windows.Forms.ColumnHeader remainder_title;
        private System.Windows.Forms.ColumnHeader enterprise_id;
        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.Label label2;
    }
}
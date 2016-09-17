namespace ProvidentFundMS
{
    partial class EnterpriseInfoForm
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
            this.searchInput_textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.EnterPriseInfoListView = new System.Windows.Forms.ListView();
            this.name_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.corporate_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contact_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fundaccount_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.remainder_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.detail_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 52);
            this.label1.TabIndex = 4;
            this.label1.Text = "企业信息查询";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchInput_textbox
            // 
            this.searchInput_textbox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.searchInput_textbox.Location = new System.Drawing.Point(23, 73);
            this.searchInput_textbox.Name = "searchInput_textbox";
            this.searchInput_textbox.Size = new System.Drawing.Size(387, 29);
            this.searchInput_textbox.TabIndex = 6;
            this.searchInput_textbox.Text = "输入企业名称搜索...";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(432, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "搜索";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EnterPriseInfoListView
            // 
            this.EnterPriseInfoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name_title,
            this.corporate_title,
            this.contact_title,
            this.fundaccount_title,
            this.remainder_title,
            this.detail_title});
            this.EnterPriseInfoListView.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EnterPriseInfoListView.Location = new System.Drawing.Point(23, 121);
            this.EnterPriseInfoListView.Margin = new System.Windows.Forms.Padding(10);
            this.EnterPriseInfoListView.Name = "EnterPriseInfoListView";
            this.EnterPriseInfoListView.Size = new System.Drawing.Size(844, 535);
            this.EnterPriseInfoListView.TabIndex = 8;
            this.EnterPriseInfoListView.UseCompatibleStateImageBehavior = false;
            this.EnterPriseInfoListView.View = System.Windows.Forms.View.Details;
            this.EnterPriseInfoListView.SelectedIndexChanged += new System.EventHandler(this.EnterPriseInfoListView_SelectedIndexChanged);
            // 
            // name_title
            // 
            this.name_title.Text = "企业名称";
            this.name_title.Width = 163;
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
            this.remainder_title.Width = 122;
            // 
            // detail_title
            // 
            this.detail_title.Text = "查看";
            this.detail_title.Width = 113;
            // 
            // EnterpriseInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 704);
            this.Controls.Add(this.EnterPriseInfoListView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchInput_textbox);
            this.Controls.Add(this.label1);
            this.Name = "EnterpriseInfoForm";
            this.Text = "城西区环新宁广场商圈党建公积金管理系统";
            this.Load += new System.EventHandler(this.EnterpriseInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchInput_textbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView EnterPriseInfoListView;
        private System.Windows.Forms.ColumnHeader name_title;
        private System.Windows.Forms.ColumnHeader corporate_title;
        private System.Windows.Forms.ColumnHeader contact_title;
        private System.Windows.Forms.ColumnHeader fundaccount_title;
        private System.Windows.Forms.ColumnHeader remainder_title;
        private System.Windows.Forms.ColumnHeader detail_title;
    }
}
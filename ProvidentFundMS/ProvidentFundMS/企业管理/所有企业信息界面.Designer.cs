namespace ProvidentFundMS
{
    partial class 所有企业信息界面
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(所有企业信息界面));
            this.EnterPriseInfoListView = new System.Windows.Forms.ListView();
            this.name_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fundaccount_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.corporate_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.licence_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contact_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.addEnterprise_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EnterPriseInfoListView
            // 
            this.EnterPriseInfoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name_title,
            this.fundaccount_title,
            this.corporate_title,
            this.licence_title,
            this.address_title,
            this.contact_title});
            this.EnterPriseInfoListView.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EnterPriseInfoListView.Location = new System.Drawing.Point(19, 120);
            this.EnterPriseInfoListView.Margin = new System.Windows.Forms.Padding(10);
            this.EnterPriseInfoListView.Name = "EnterPriseInfoListView";
            this.EnterPriseInfoListView.Size = new System.Drawing.Size(868, 526);
            this.EnterPriseInfoListView.TabIndex = 9;
            this.EnterPriseInfoListView.UseCompatibleStateImageBehavior = false;
            this.EnterPriseInfoListView.View = System.Windows.Forms.View.Details;
            this.EnterPriseInfoListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.EnterPriseInfoListView_MouseDoubleClick);
            // 
            // name_title
            // 
            this.name_title.Text = "企业名称";
            this.name_title.Width = 170;
            // 
            // fundaccount_title
            // 
            this.fundaccount_title.Text = "公积金账号";
            this.fundaccount_title.Width = 145;
            // 
            // corporate_title
            // 
            this.corporate_title.Text = "企业法人";
            this.corporate_title.Width = 114;
            // 
            // licence_title
            // 
            this.licence_title.Text = "营业执照编号";
            this.licence_title.Width = 135;
            // 
            // address_title
            // 
            this.address_title.Text = "企业地址";
            this.address_title.Width = 156;
            // 
            // contact_title
            // 
            this.contact_title.Text = "联系方式";
            this.contact_title.Width = 144;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 43);
            this.label1.TabIndex = 10;
            this.label1.Text = "企业信息维护";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addEnterprise_btn
            // 
            this.addEnterprise_btn.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addEnterprise_btn.Location = new System.Drawing.Point(647, 59);
            this.addEnterprise_btn.Name = "addEnterprise_btn";
            this.addEnterprise_btn.Size = new System.Drawing.Size(241, 38);
            this.addEnterprise_btn.TabIndex = 11;
            this.addEnterprise_btn.Text = "新增企业录入";
            this.addEnterprise_btn.UseVisualStyleBackColor = true;
            this.addEnterprise_btn.Click += new System.EventHandler(this.addEnterprise_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(21, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "按名称搜索:";
            // 
            // search_textbox
            // 
            this.search_textbox.Font = new System.Drawing.Font("宋体", 14F);
            this.search_textbox.Location = new System.Drawing.Point(147, 68);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(375, 29);
            this.search_textbox.TabIndex = 12;
            this.search_textbox.TextChanged += new System.EventHandler(this.search_textbox_TextChanged);
            // 
            // 所有企业信息界面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 657);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search_textbox);
            this.Controls.Add(this.addEnterprise_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnterPriseInfoListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "所有企业信息界面";
            this.Text = "城西区环新宁广场商圈党建公积金管理系统";
            this.Load += new System.EventHandler(this.EnterpriseInfoManageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView EnterPriseInfoListView;
        private System.Windows.Forms.ColumnHeader name_title;
        private System.Windows.Forms.ColumnHeader corporate_title;
        private System.Windows.Forms.ColumnHeader licence_title;
        private System.Windows.Forms.ColumnHeader fundaccount_title;
        private System.Windows.Forms.ColumnHeader address_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader contact_title;
        private System.Windows.Forms.Button addEnterprise_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox search_textbox;
    }
}
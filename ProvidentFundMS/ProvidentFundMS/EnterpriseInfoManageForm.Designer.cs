namespace ProvidentFundMS
{
    partial class EnterpriseInfoManageForm
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
            this.components = new System.ComponentModel.Container();
            this.EnterPriseInfoListView = new System.Windows.Forms.ListView();
            this.name_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fundaccount_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.corporate_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.licence_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contact_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modify_enterpriseinfo_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.addEnterprise_btn = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
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
            this.EnterPriseInfoListView.ContextMenuStrip = this.contextMenuStrip1;
            this.EnterPriseInfoListView.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EnterPriseInfoListView.Location = new System.Drawing.Point(19, 120);
            this.EnterPriseInfoListView.Margin = new System.Windows.Forms.Padding(10);
            this.EnterPriseInfoListView.Name = "EnterPriseInfoListView";
            this.EnterPriseInfoListView.Size = new System.Drawing.Size(868, 526);
            this.EnterPriseInfoListView.TabIndex = 9;
            this.EnterPriseInfoListView.UseCompatibleStateImageBehavior = false;
            this.EnterPriseInfoListView.View = System.Windows.Forms.View.Details;
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
            this.contact_title.Width = 94;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modify_enterpriseinfo_menu,
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            // 
            // modify_enterpriseinfo_menu
            // 
            this.modify_enterpriseinfo_menu.Name = "modify_enterpriseinfo_menu";
            this.modify_enterpriseinfo_menu.Size = new System.Drawing.Size(152, 22);
            this.modify_enterpriseinfo_menu.Text = "修改";
            this.modify_enterpriseinfo_menu.Click += new System.EventHandler(this.modify_enterpriseinfo_menu_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.删除ToolStripMenuItem.Text = "删除";
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
            this.addEnterprise_btn.Location = new System.Drawing.Point(622, 55);
            this.addEnterprise_btn.Name = "addEnterprise_btn";
            this.addEnterprise_btn.Size = new System.Drawing.Size(241, 42);
            this.addEnterprise_btn.TabIndex = 11;
            this.addEnterprise_btn.Text = "新增企业录入";
            this.addEnterprise_btn.UseVisualStyleBackColor = true;
            this.addEnterprise_btn.Click += new System.EventHandler(this.addEnterprise_btn_Click);
            // 
            // EnterpriseInfoManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 657);
            this.Controls.Add(this.addEnterprise_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnterPriseInfoListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EnterpriseInfoManageForm";
            this.Text = "城西区环新宁广场商圈党建公积金管理系统";
            this.Load += new System.EventHandler(this.EnterpriseInfoManageForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modify_enterpriseinfo_menu;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
    }
}
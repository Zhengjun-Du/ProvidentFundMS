﻿namespace ProvidentFundMS
{
    partial class 企业收支明细
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(企业收支明细));
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ProvidentFundDetail_ListView = new System.Windows.Forms.ListView();
            this.id_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.abstract_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.income_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expend_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.remain_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.operator_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.enterprise_label = new System.Windows.Forms.Label();
            this.provident_found_number_label = new System.Windows.Forms.Label();
            this.print_btn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.new_btn = new System.Windows.Forms.Button();
            this.remain_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printSet_btn = new System.Windows.Forms.Button();
            this.preViewBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 52);
            this.label1.TabIndex = 5;
            this.label1.Text = "企业收支明细";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(13, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 37);
            this.label6.TabIndex = 7;
            this.label6.Text = "党建公积金账号：";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 37);
            this.label2.TabIndex = 11;
            this.label2.Text = "企   业    名   称：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(10, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(873, 103);
            this.label8.TabIndex = 12;
            // 
            // ProvidentFundDetail_ListView
            // 
            this.ProvidentFundDetail_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id_title,
            this.date_title,
            this.abstract_title,
            this.income_title,
            this.expend_title,
            this.remain_title,
            this.operator_title});
            this.ProvidentFundDetail_ListView.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ProvidentFundDetail_ListView.Location = new System.Drawing.Point(10, 185);
            this.ProvidentFundDetail_ListView.Name = "ProvidentFundDetail_ListView";
            this.ProvidentFundDetail_ListView.Size = new System.Drawing.Size(874, 420);
            this.ProvidentFundDetail_ListView.TabIndex = 13;
            this.ProvidentFundDetail_ListView.UseCompatibleStateImageBehavior = false;
            this.ProvidentFundDetail_ListView.View = System.Windows.Forms.View.Details;
            this.ProvidentFundDetail_ListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ProvidentFundDetail_ListView_MouseDoubleClick);
            // 
            // id_title
            // 
            this.id_title.Text = "序号";
            this.id_title.Width = 72;
            // 
            // date_title
            // 
            this.date_title.Text = "日期";
            this.date_title.Width = 184;
            // 
            // abstract_title
            // 
            this.abstract_title.Text = "摘要";
            this.abstract_title.Width = 174;
            // 
            // income_title
            // 
            this.income_title.Text = "存入";
            this.income_title.Width = 104;
            // 
            // expend_title
            // 
            this.expend_title.Text = "支出";
            this.expend_title.Width = 104;
            // 
            // remain_title
            // 
            this.remain_title.Text = "余额";
            this.remain_title.Width = 107;
            // 
            // operator_title
            // 
            this.operator_title.Text = "经办人";
            this.operator_title.Width = 128;
            // 
            // enterprise_label
            // 
            this.enterprise_label.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.enterprise_label.ForeColor = System.Drawing.Color.Black;
            this.enterprise_label.Location = new System.Drawing.Point(195, 73);
            this.enterprise_label.Name = "enterprise_label";
            this.enterprise_label.Size = new System.Drawing.Size(295, 37);
            this.enterprise_label.TabIndex = 11;
            this.enterprise_label.Text = "青海君东信息科技有限责任公司";
            this.enterprise_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // provident_found_number_label
            // 
            this.provident_found_number_label.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.provident_found_number_label.ForeColor = System.Drawing.Color.Black;
            this.provident_found_number_label.Location = new System.Drawing.Point(195, 113);
            this.provident_found_number_label.Name = "provident_found_number_label";
            this.provident_found_number_label.Size = new System.Drawing.Size(259, 37);
            this.provident_found_number_label.TabIndex = 11;
            this.provident_found_number_label.Text = "201688888888";
            this.provident_found_number_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // print_btn
            // 
            this.print_btn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.print_btn.Location = new System.Drawing.Point(761, 611);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(124, 39);
            this.print_btn.TabIndex = 14;
            this.print_btn.Text = "打 印";
            this.print_btn.UseVisualStyleBackColor = true;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(426, 611);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // new_btn
            // 
            this.new_btn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.new_btn.Location = new System.Drawing.Point(10, 611);
            this.new_btn.Name = "new_btn";
            this.new_btn.Size = new System.Drawing.Size(180, 39);
            this.new_btn.TabIndex = 14;
            this.new_btn.Text = "新增记录";
            this.new_btn.UseVisualStyleBackColor = true;
            this.new_btn.Click += new System.EventHandler(this.new_btn_Click);
            // 
            // remain_label
            // 
            this.remain_label.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.remain_label.ForeColor = System.Drawing.Color.Red;
            this.remain_label.Location = new System.Drawing.Point(729, 113);
            this.remain_label.Name = "remain_label";
            this.remain_label.Size = new System.Drawing.Size(128, 37);
            this.remain_label.TabIndex = 11;
            this.remain_label.Text = "0";
            this.remain_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(580, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "公积金余额：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // printSet_btn
            // 
            this.printSet_btn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.printSet_btn.Location = new System.Drawing.Point(479, 611);
            this.printSet_btn.Name = "printSet_btn";
            this.printSet_btn.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.printSet_btn.Size = new System.Drawing.Size(122, 39);
            this.printSet_btn.TabIndex = 16;
            this.printSet_btn.Text = "打印范围设定";
            this.printSet_btn.UseVisualStyleBackColor = true;
            this.printSet_btn.Click += new System.EventHandler(this.printSet_btn_Click);
            // 
            // preViewBtn
            // 
            this.preViewBtn.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.preViewBtn.Location = new System.Drawing.Point(626, 612);
            this.preViewBtn.Name = "preViewBtn";
            this.preViewBtn.Size = new System.Drawing.Size(113, 38);
            this.preViewBtn.TabIndex = 17;
            this.preViewBtn.Text = "打印预览";
            this.preViewBtn.UseVisualStyleBackColor = true;
            this.preViewBtn.Click += new System.EventHandler(this.preViewBtn_Click);
            // 
            // 企业收支明细
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 662);
            this.Controls.Add(this.preViewBtn);
            this.Controls.Add(this.printSet_btn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.new_btn);
            this.Controls.Add(this.print_btn);
            this.Controls.Add(this.ProvidentFundDetail_ListView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.remain_label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.provident_found_number_label);
            this.Controls.Add(this.enterprise_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "企业收支明细";
            this.Text = "城西区环新宁广场商圈党建公积金管理系统";
            this.Load += new System.EventHandler(this.EnterpriseDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView ProvidentFundDetail_ListView;
        private System.Windows.Forms.Label enterprise_label;
        private System.Windows.Forms.Label provident_found_number_label;
        private System.Windows.Forms.ColumnHeader id_title;
        private System.Windows.Forms.ColumnHeader date_title;
        private System.Windows.Forms.ColumnHeader abstract_title;
        private System.Windows.Forms.ColumnHeader income_title;
        private System.Windows.Forms.ColumnHeader expend_title;
        private System.Windows.Forms.ColumnHeader remain_title;
        private System.Windows.Forms.ColumnHeader operator_title;
        private System.Windows.Forms.Button print_btn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button new_btn;
        private System.Windows.Forms.Label remain_label;
        private System.Windows.Forms.Label label4;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.Button printSet_btn;
        private System.Windows.Forms.Button preViewBtn;
    }
}
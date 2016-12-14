namespace ProvidentFundMS
{
    partial class 党员信息管理
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
            this.partMemberListView = new System.Windows.Forms.ListView();
            this.seqno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nationality = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.birth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.joinTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.education = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.workUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.addPartMember_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // partMemberListView
            // 
            this.partMemberListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.seqno,
            this.name,
            this.sex,
            this.nationality,
            this.birth,
            this.joinTime,
            this.education,
            this.workUnit,
            this.phone});
            this.partMemberListView.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.partMemberListView.Location = new System.Drawing.Point(23, 117);
            this.partMemberListView.Margin = new System.Windows.Forms.Padding(10);
            this.partMemberListView.Name = "partMemberListView";
            this.partMemberListView.Size = new System.Drawing.Size(868, 526);
            this.partMemberListView.TabIndex = 14;
            this.partMemberListView.UseCompatibleStateImageBehavior = false;
            this.partMemberListView.View = System.Windows.Forms.View.Details;
            this.partMemberListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.partMemberListView_MouseDoubleClick);
            // 
            // seqno
            // 
            this.seqno.Text = "序号";
            this.seqno.Width = 58;
            // 
            // name
            // 
            this.name.Text = "姓名";
            this.name.Width = 108;
            // 
            // sex
            // 
            this.sex.Text = "性别";
            this.sex.Width = 70;
            // 
            // nationality
            // 
            this.nationality.Text = "民族";
            this.nationality.Width = 75;
            // 
            // birth
            // 
            this.birth.Text = "出生年月";
            this.birth.Width = 116;
            // 
            // joinTime
            // 
            this.joinTime.Text = "入党时间";
            this.joinTime.Width = 114;
            // 
            // education
            // 
            this.education.Text = "学历";
            this.education.Width = 91;
            // 
            // workUnit
            // 
            this.workUnit.Text = "工作单位";
            this.workUnit.Width = 109;
            // 
            // phone
            // 
            this.phone.Text = "联系电话";
            this.phone.Width = 121;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(19, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "按姓名搜索:";
            // 
            // search_textbox
            // 
            this.search_textbox.Font = new System.Drawing.Font("宋体", 14F);
            this.search_textbox.Location = new System.Drawing.Point(145, 72);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(375, 29);
            this.search_textbox.TabIndex = 17;
            this.search_textbox.TextChanged += new System.EventHandler(this.search_textbox_TextChanged);
            // 
            // addPartMember_btn
            // 
            this.addPartMember_btn.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addPartMember_btn.Location = new System.Drawing.Point(645, 63);
            this.addPartMember_btn.Name = "addPartMember_btn";
            this.addPartMember_btn.Size = new System.Drawing.Size(241, 38);
            this.addPartMember_btn.TabIndex = 16;
            this.addPartMember_btn.Text = "新增党员";
            this.addPartMember_btn.UseVisualStyleBackColor = true;
            this.addPartMember_btn.Click += new System.EventHandler(this.addPartMember_btn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 43);
            this.label1.TabIndex = 15;
            this.label1.Text = "党员信息管理";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 党员信息管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 662);
            this.Controls.Add(this.partMemberListView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search_textbox);
            this.Controls.Add(this.addPartMember_btn);
            this.Controls.Add(this.label1);
            this.Name = "党员信息管理";
            this.Text = "党员信息管理";
            this.Load += new System.EventHandler(this.党员信息管理_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView partMemberListView;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader sex;
        private System.Windows.Forms.ColumnHeader nationality;
        private System.Windows.Forms.ColumnHeader birth;
        private System.Windows.Forms.ColumnHeader joinTime;
        private System.Windows.Forms.ColumnHeader education;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.Button addPartMember_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader seqno;
        private System.Windows.Forms.ColumnHeader workUnit;
        private System.Windows.Forms.ColumnHeader phone;
    }
}
namespace ProvidentFundMS
{
    partial class 添加收支记录
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
            this.abstract_comboBox = new System.Windows.Forms.ComboBox();
            this.exit_btn = new System.Windows.Forms.Button();
            this.confirm_add_btn = new System.Windows.Forms.Button();
            this.operator_textbox = new System.Windows.Forms.TextBox();
            this.remain_textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cost_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.income_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.date_textbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.provident_found_number_label = new System.Windows.Forms.Label();
            this.enterprise_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.remain_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // abstract_comboBox
            // 
            this.abstract_comboBox.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.abstract_comboBox.FormattingEnabled = true;
            this.abstract_comboBox.Items.AddRange(new object[] {
            "企业预存",
            "商圈配套",
            "党费返补",
            "会议支出",
            "党建支出"});
            this.abstract_comboBox.Location = new System.Drawing.Point(290, 277);
            this.abstract_comboBox.Name = "abstract_comboBox";
            this.abstract_comboBox.Size = new System.Drawing.Size(387, 27);
            this.abstract_comboBox.TabIndex = 56;
            // 
            // exit_btn
            // 
            this.exit_btn.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exit_btn.Location = new System.Drawing.Point(503, 566);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(174, 48);
            this.exit_btn.TabIndex = 54;
            this.exit_btn.Text = "退出";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // confirm_add_btn
            // 
            this.confirm_add_btn.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirm_add_btn.Location = new System.Drawing.Point(290, 566);
            this.confirm_add_btn.Name = "confirm_add_btn";
            this.confirm_add_btn.Size = new System.Drawing.Size(188, 48);
            this.confirm_add_btn.TabIndex = 55;
            this.confirm_add_btn.Text = "确认增加";
            this.confirm_add_btn.UseVisualStyleBackColor = true;
            this.confirm_add_btn.Click += new System.EventHandler(this.confirm_add_btn_Click);
            // 
            // operator_textbox
            // 
            this.operator_textbox.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.operator_textbox.Location = new System.Drawing.Point(290, 504);
            this.operator_textbox.Name = "operator_textbox";
            this.operator_textbox.Size = new System.Drawing.Size(387, 29);
            this.operator_textbox.TabIndex = 53;
            // 
            // remain_textbox
            // 
            this.remain_textbox.BackColor = System.Drawing.Color.White;
            this.remain_textbox.Enabled = false;
            this.remain_textbox.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.remain_textbox.Location = new System.Drawing.Point(290, 441);
            this.remain_textbox.Name = "remain_textbox";
            this.remain_textbox.Size = new System.Drawing.Size(387, 29);
            this.remain_textbox.TabIndex = 51;
            this.remain_textbox.Text = "0";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(142, 498);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 37);
            this.label7.TabIndex = 43;
            this.label7.Text = "经办人：";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cost_textbox
            // 
            this.cost_textbox.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cost_textbox.Location = new System.Drawing.Point(290, 384);
            this.cost_textbox.Name = "cost_textbox";
            this.cost_textbox.Size = new System.Drawing.Size(387, 29);
            this.cost_textbox.TabIndex = 50;
            this.cost_textbox.Text = "0";
            this.cost_textbox.TextChanged += new System.EventHandler(this.cost_textbox_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(164, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 37);
            this.label3.TabIndex = 44;
            this.label3.Text = "余额：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // income_textbox
            // 
            this.income_textbox.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.income_textbox.Location = new System.Drawing.Point(290, 325);
            this.income_textbox.Name = "income_textbox";
            this.income_textbox.Size = new System.Drawing.Size(387, 29);
            this.income_textbox.TabIndex = 45;
            this.income_textbox.Text = "0";
            this.income_textbox.TextChanged += new System.EventHandler(this.income_textbox_TextChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(147, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 37);
            this.label5.TabIndex = 46;
            this.label5.Text = "支出：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(148, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 37);
            this.label4.TabIndex = 47;
            this.label4.Text = "存入：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date_textbox
            // 
            this.date_textbox.BackColor = System.Drawing.Color.White;
            this.date_textbox.Enabled = false;
            this.date_textbox.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.date_textbox.Location = new System.Drawing.Point(290, 217);
            this.date_textbox.Name = "date_textbox";
            this.date_textbox.Size = new System.Drawing.Size(387, 29);
            this.date_textbox.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(162, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 37);
            this.label9.TabIndex = 48;
            this.label9.Text = "摘要：";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(143, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 37);
            this.label10.TabIndex = 49;
            this.label10.Text = "日期：";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(15, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(873, 437);
            this.label11.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(18, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 37);
            this.label6.TabIndex = 37;
            this.label6.Text = "党建公积金账号：";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // provident_found_number_label
            // 
            this.provident_found_number_label.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.provident_found_number_label.ForeColor = System.Drawing.Color.Black;
            this.provident_found_number_label.Location = new System.Drawing.Point(200, 135);
            this.provident_found_number_label.Name = "provident_found_number_label";
            this.provident_found_number_label.Size = new System.Drawing.Size(259, 37);
            this.provident_found_number_label.TabIndex = 38;
            this.provident_found_number_label.Text = "201688888888";
            this.provident_found_number_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // enterprise_label
            // 
            this.enterprise_label.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.enterprise_label.ForeColor = System.Drawing.Color.Black;
            this.enterprise_label.Location = new System.Drawing.Point(200, 93);
            this.enterprise_label.Name = "enterprise_label";
            this.enterprise_label.Size = new System.Drawing.Size(295, 37);
            this.enterprise_label.TabIndex = 39;
            this.enterprise_label.Text = "青海君东信息科技有限责任公司";
            this.enterprise_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 37);
            this.label2.TabIndex = 40;
            this.label2.Text = "企   业    名   称：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 52);
            this.label1.TabIndex = 36;
            this.label1.Text = "新增收支明细";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(15, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(873, 103);
            this.label8.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(563, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 37);
            this.label12.TabIndex = 57;
            this.label12.Text = "公积金余额：";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // remain_label
            // 
            this.remain_label.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.remain_label.ForeColor = System.Drawing.Color.Red;
            this.remain_label.Location = new System.Drawing.Point(712, 135);
            this.remain_label.Name = "remain_label";
            this.remain_label.Size = new System.Drawing.Size(128, 37);
            this.remain_label.TabIndex = 58;
            this.remain_label.Text = "0";
            this.remain_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // 添加收支记录
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 662);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.remain_label);
            this.Controls.Add(this.abstract_comboBox);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.confirm_add_btn);
            this.Controls.Add(this.operator_textbox);
            this.Controls.Add(this.remain_textbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cost_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.income_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.date_textbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.provident_found_number_label);
            this.Controls.Add(this.enterprise_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Name = "添加收支记录";
            this.Text = "城西区环新宁广场商圈党建公积金管理系统";
            this.Load += new System.EventHandler(this.AddIERecordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox abstract_comboBox;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button confirm_add_btn;
        private System.Windows.Forms.TextBox operator_textbox;
        public  System.Windows.Forms.TextBox remain_textbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cost_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox income_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox date_textbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label provident_found_number_label;
        private System.Windows.Forms.Label enterprise_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label remain_label;

    }
}
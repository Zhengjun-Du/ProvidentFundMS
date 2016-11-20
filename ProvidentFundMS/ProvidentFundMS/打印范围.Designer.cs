namespace ProvidentFundMS
{
    partial class 打印范围对话框
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
            this.radioBtn_curr = new System.Windows.Forms.RadioButton();
            this.radioBtn_all = new System.Windows.Forms.RadioButton();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.ok_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "打印范围对话框设定：";
            // 
            // radioBtn_curr
            // 
            this.radioBtn_curr.AutoSize = true;
            this.radioBtn_curr.Checked = true;
            this.radioBtn_curr.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioBtn_curr.Location = new System.Drawing.Point(29, 73);
            this.radioBtn_curr.Name = "radioBtn_curr";
            this.radioBtn_curr.Size = new System.Drawing.Size(154, 20);
            this.radioBtn_curr.TabIndex = 1;
            this.radioBtn_curr.TabStop = true;
            this.radioBtn_curr.Text = "所有未打印的记录";
            this.radioBtn_curr.UseVisualStyleBackColor = true;
            this.radioBtn_curr.Click += new System.EventHandler(this.radioBtn_curr_Click);
            // 
            // radioBtn_all
            // 
            this.radioBtn_all.AutoSize = true;
            this.radioBtn_all.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioBtn_all.Location = new System.Drawing.Point(29, 112);
            this.radioBtn_all.Name = "radioBtn_all";
            this.radioBtn_all.Size = new System.Drawing.Size(90, 20);
            this.radioBtn_all.TabIndex = 1;
            this.radioBtn_all.Text = "所有记录";
            this.radioBtn_all.UseVisualStyleBackColor = true;
            this.radioBtn_all.CheckedChanged += new System.EventHandler(this.radioBtn_all_CheckedChanged);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // ok_btn
            // 
            this.ok_btn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ok_btn.Location = new System.Drawing.Point(29, 161);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(122, 41);
            this.ok_btn.TabIndex = 3;
            this.ok_btn.Text = "确 定";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // 打印范围对话框
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(425, 220);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.radioBtn_all);
            this.Controls.Add(this.radioBtn_curr);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "打印范围对话框";
            this.Text = "打印设置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioBtn_curr;
        private System.Windows.Forms.RadioButton radioBtn_all;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.Button ok_btn;
    }
}
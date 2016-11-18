namespace ProvidentFundMS
{
    partial class 打印范围
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
            this.radioBtn_setrange = new System.Windows.Forms.RadioButton();
            this.numericUpDown_start = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_end = new System.Windows.Forms.NumericUpDown();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_end)).BeginInit();
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
            this.label1.Text = "打印范围设定：";
            // 
            // radioBtn_curr
            // 
            this.radioBtn_curr.AutoSize = true;
            this.radioBtn_curr.Checked = true;
            this.radioBtn_curr.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioBtn_curr.Location = new System.Drawing.Point(29, 73);
            this.radioBtn_curr.Name = "radioBtn_curr";
            this.radioBtn_curr.Size = new System.Drawing.Size(90, 20);
            this.radioBtn_curr.TabIndex = 1;
            this.radioBtn_curr.TabStop = true;
            this.radioBtn_curr.Text = "当前记录";
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
            // radioBtn_setrange
            // 
            this.radioBtn_setrange.AutoSize = true;
            this.radioBtn_setrange.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioBtn_setrange.Location = new System.Drawing.Point(29, 155);
            this.radioBtn_setrange.Name = "radioBtn_setrange";
            this.radioBtn_setrange.Size = new System.Drawing.Size(106, 20);
            this.radioBtn_setrange.TabIndex = 1;
            this.radioBtn_setrange.Text = "自定义范围";
            this.radioBtn_setrange.UseVisualStyleBackColor = true;
            this.radioBtn_setrange.CheckedChanged += new System.EventHandler(this.radioBtn_setrange_CheckedChanged);
            // 
            // numericUpDown_start
            // 
            this.numericUpDown_start.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDown_start.Location = new System.Drawing.Point(153, 149);
            this.numericUpDown_start.Name = "numericUpDown_start";
            this.numericUpDown_start.Size = new System.Drawing.Size(37, 26);
            this.numericUpDown_start.TabIndex = 2;
            this.numericUpDown_start.ValueChanged += new System.EventHandler(this.numericUpDown_start_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(196, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "--";
            // 
            // numericUpDown_end
            // 
            this.numericUpDown_end.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDown_end.Location = new System.Drawing.Point(231, 149);
            this.numericUpDown_end.Name = "numericUpDown_end";
            this.numericUpDown_end.Size = new System.Drawing.Size(37, 26);
            this.numericUpDown_end.TabIndex = 2;
            this.numericUpDown_end.ValueChanged += new System.EventHandler(this.numericUpDown_end_ValueChanged);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // 打印范围
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(425, 214);
            this.Controls.Add(this.numericUpDown_end);
            this.Controls.Add(this.numericUpDown_start);
            this.Controls.Add(this.radioBtn_setrange);
            this.Controls.Add(this.radioBtn_all);
            this.Controls.Add(this.radioBtn_curr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "打印范围";
            this.Text = "打印设置";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_end)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioBtn_curr;
        private System.Windows.Forms.RadioButton radioBtn_all;
        private System.Windows.Forms.RadioButton radioBtn_setrange;
        private System.Windows.Forms.NumericUpDown numericUpDown_start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_end;
        private System.Windows.Forms.PrintDialog printDialog;
    }
}
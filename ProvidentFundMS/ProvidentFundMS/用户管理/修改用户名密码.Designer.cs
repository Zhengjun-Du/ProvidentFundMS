namespace ProvidentFundMS
{
    partial class 修改用户名密码
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(修改用户名密码));
            this.label1 = new System.Windows.Forms.Label();
            this.reset_btn = new System.Windows.Forms.Button();
            this.addEnterprise_btn = new System.Windows.Forms.Button();
            this.confirm_textBox = new System.Windows.Forms.TextBox();
            this.newPassword_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.newUsername_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.currPassword_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.currUsername_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 52);
            this.label1.TabIndex = 4;
            this.label1.Text = "用户名密码修改";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reset_btn
            // 
            this.reset_btn.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reset_btn.Location = new System.Drawing.Point(550, 380);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(174, 48);
            this.reset_btn.TabIndex = 20;
            this.reset_btn.Text = "退出";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // addEnterprise_btn
            // 
            this.addEnterprise_btn.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addEnterprise_btn.Location = new System.Drawing.Point(337, 380);
            this.addEnterprise_btn.Name = "addEnterprise_btn";
            this.addEnterprise_btn.Size = new System.Drawing.Size(188, 48);
            this.addEnterprise_btn.TabIndex = 21;
            this.addEnterprise_btn.Text = "确认修改";
            this.addEnterprise_btn.UseVisualStyleBackColor = true;
            this.addEnterprise_btn.Click += new System.EventHandler(this.addEnterprise_btn_Click);
            // 
            // confirm_textBox
            // 
            this.confirm_textBox.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirm_textBox.Location = new System.Drawing.Point(337, 314);
            this.confirm_textBox.Name = "confirm_textBox";
            this.confirm_textBox.PasswordChar = '*';
            this.confirm_textBox.Size = new System.Drawing.Size(387, 29);
            this.confirm_textBox.TabIndex = 14;
            // 
            // newPassword_textBox
            // 
            this.newPassword_textBox.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.newPassword_textBox.Location = new System.Drawing.Point(337, 257);
            this.newPassword_textBox.Name = "newPassword_textBox";
            this.newPassword_textBox.PasswordChar = '*';
            this.newPassword_textBox.Size = new System.Drawing.Size(387, 29);
            this.newPassword_textBox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(174, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 37);
            this.label6.TabIndex = 8;
            this.label6.Text = "确认新密码：";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newUsername_textBox
            // 
            this.newUsername_textBox.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.newUsername_textBox.Location = new System.Drawing.Point(337, 198);
            this.newUsername_textBox.Name = "newUsername_textBox";
            this.newUsername_textBox.Size = new System.Drawing.Size(387, 29);
            this.newUsername_textBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(215, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 37);
            this.label5.TabIndex = 9;
            this.label5.Text = "新密码：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currPassword_textBox
            // 
            this.currPassword_textBox.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.currPassword_textBox.Location = new System.Drawing.Point(337, 144);
            this.currPassword_textBox.Name = "currPassword_textBox";
            this.currPassword_textBox.PasswordChar = '*';
            this.currPassword_textBox.Size = new System.Drawing.Size(387, 29);
            this.currPassword_textBox.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(195, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 37);
            this.label4.TabIndex = 10;
            this.label4.Text = "新用户名：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currUsername_textBox
            // 
            this.currUsername_textBox.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.currUsername_textBox.Location = new System.Drawing.Point(337, 90);
            this.currUsername_textBox.Name = "currUsername_textBox";
            this.currUsername_textBox.Size = new System.Drawing.Size(387, 29);
            this.currUsername_textBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(193, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 37);
            this.label3.TabIndex = 11;
            this.label3.Text = "当前密码：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(168, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 37);
            this.label2.TabIndex = 12;
            this.label2.Text = "当前用户名：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(65, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(773, 397);
            this.label8.TabIndex = 19;
            // 
            // 修改用户名密码
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 538);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.addEnterprise_btn);
            this.Controls.Add(this.confirm_textBox);
            this.Controls.Add(this.newPassword_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.newUsername_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.currPassword_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.currUsername_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "修改用户名密码";
            this.Text = "AccountMangaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button addEnterprise_btn;
        private System.Windows.Forms.TextBox confirm_textBox;
        private System.Windows.Forms.TextBox newPassword_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox newUsername_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox currPassword_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox currUsername_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
    }
}
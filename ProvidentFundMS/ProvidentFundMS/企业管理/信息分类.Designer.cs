namespace ProvidentFundMS
{
    partial class 信息分类
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(信息分类));
            this.partyMemberBtn = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addEnterprise_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // partyMemberBtn
            // 
            this.partyMemberBtn.Font = new System.Drawing.Font("微软雅黑", 21.75F);
            this.partyMemberBtn.Location = new System.Drawing.Point(402, 175);
            this.partyMemberBtn.Name = "partyMemberBtn";
            this.partyMemberBtn.Size = new System.Drawing.Size(317, 70);
            this.partyMemberBtn.TabIndex = 8;
            this.partyMemberBtn.Text = "党员信息管理";
            this.partyMemberBtn.UseVisualStyleBackColor = true;
            this.partyMemberBtn.Click += new System.EventHandler(this.partyMemberBtn_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(256, 175);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(92, 71);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(256, 293);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // addEnterprise_btn
            // 
            this.addEnterprise_btn.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addEnterprise_btn.Location = new System.Drawing.Point(402, 293);
            this.addEnterprise_btn.Name = "addEnterprise_btn";
            this.addEnterprise_btn.Size = new System.Drawing.Size(317, 70);
            this.addEnterprise_btn.TabIndex = 5;
            this.addEnterprise_btn.Text = "企业信息管理";
            this.addEnterprise_btn.UseVisualStyleBackColor = true;
            this.addEnterprise_btn.Click += new System.EventHandler(this.addEnterprise_btn_Click);
            // 
            // 信息分类
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 538);
            this.Controls.Add(this.partyMemberBtn);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addEnterprise_btn);
            this.Name = "信息分类";
            this.Text = "信息分类";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button partyMemberBtn;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addEnterprise_btn;
    }
}
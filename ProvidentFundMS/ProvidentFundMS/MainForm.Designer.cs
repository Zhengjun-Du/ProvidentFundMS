namespace ProvidentFundMS
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.addEnterprise_btn = new System.Windows.Forms.Button();
            this.enterpriseIEM_btn = new System.Windows.Forms.Button();
            this.enterpriseInfoSearch_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // addEnterprise_btn
            // 
            this.addEnterprise_btn.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addEnterprise_btn.Location = new System.Drawing.Point(389, 160);
            this.addEnterprise_btn.Name = "addEnterprise_btn";
            this.addEnterprise_btn.Size = new System.Drawing.Size(239, 70);
            this.addEnterprise_btn.TabIndex = 0;
            this.addEnterprise_btn.Text = "新增企业录入";
            this.addEnterprise_btn.UseVisualStyleBackColor = true;
            this.addEnterprise_btn.Click += new System.EventHandler(this.addEnterprise_btn_Click);
            // 
            // enterpriseIEM_btn
            // 
            this.enterpriseIEM_btn.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.enterpriseIEM_btn.Location = new System.Drawing.Point(389, 264);
            this.enterpriseIEM_btn.Name = "enterpriseIEM_btn";
            this.enterpriseIEM_btn.Size = new System.Drawing.Size(239, 70);
            this.enterpriseIEM_btn.TabIndex = 0;
            this.enterpriseIEM_btn.Text = "企业收支管理";
            this.enterpriseIEM_btn.UseVisualStyleBackColor = true;
            this.enterpriseIEM_btn.Click += new System.EventHandler(this.enterpriseIEM_btn_Click);
            // 
            // enterpriseInfoSearch_btn
            // 
            this.enterpriseInfoSearch_btn.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.enterpriseInfoSearch_btn.Location = new System.Drawing.Point(389, 373);
            this.enterpriseInfoSearch_btn.Name = "enterpriseInfoSearch_btn";
            this.enterpriseInfoSearch_btn.Size = new System.Drawing.Size(239, 70);
            this.enterpriseInfoSearch_btn.TabIndex = 0;
            this.enterpriseInfoSearch_btn.Text = "企业信息查询";
            this.enterpriseInfoSearch_btn.UseVisualStyleBackColor = true;
            this.enterpriseInfoSearch_btn.Click += new System.EventHandler(this.enterpriseInfoSearch_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(250, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(249, 264);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(93, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(249, 373);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(93, 70);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(130, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(677, 94);
            this.label1.TabIndex = 2;
            this.label1.Text = "环新宁广场商圈党建公积金管理系统操作面板";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 538);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.enterpriseIEM_btn);
            this.Controls.Add(this.enterpriseInfoSearch_btn);
            this.Controls.Add(this.addEnterprise_btn);
            this.Name = "MainForm";
            this.Text = "城西区环新宁广场商圈党建公积金管理系统";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addEnterprise_btn;
        private System.Windows.Forms.Button enterpriseIEM_btn;
        private System.Windows.Forms.Button enterpriseInfoSearch_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
    }
}
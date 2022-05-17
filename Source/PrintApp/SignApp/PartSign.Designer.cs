namespace SignApp
{
    partial class PartSign
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelWelcome = new System.Windows.Forms.Label();
            this.btSign = new System.Windows.Forms.Button();
            this.lbMobileNO = new System.Windows.Forms.Label();
            this.btFirst = new System.Windows.Forms.Button();
            this.tbCustNO = new PrintApp.Common.WatermarkTextBox();
            this.rbNO = new System.Windows.Forms.RadioButton();
            this.rbMobile = new System.Windows.Forms.RadioButton();
            this.lbCustInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelWelcome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelWelcome.Location = new System.Drawing.Point(3, 9);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(79, 20);
            this.labelWelcome.TabIndex = 8;
            this.labelWelcome.Text = "当前分会场";
            // 
            // btSign
            // 
            this.btSign.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSign.BackgroundImage = global::SignApp.Properties.Resources.确定;
            this.btSign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSign.Enabled = false;
            this.btSign.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.btSign.Location = new System.Drawing.Point(255, 312);
            this.btSign.Name = "btSign";
            this.btSign.Size = new System.Drawing.Size(141, 52);
            this.btSign.TabIndex = 2;
            this.btSign.UseVisualStyleBackColor = true;
            this.btSign.Click += new System.EventHandler(this.btSign_Click);
            // 
            // lbMobileNO
            // 
            this.lbMobileNO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbMobileNO.AutoSize = true;
            this.lbMobileNO.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMobileNO.Location = new System.Drawing.Point(196, 9);
            this.lbMobileNO.Name = "lbMobileNO";
            this.lbMobileNO.Size = new System.Drawing.Size(0, 75);
            this.lbMobileNO.TabIndex = 0;
            // 
            // btFirst
            // 
            this.btFirst.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btFirst.BackgroundImage = global::SignApp.Properties.Resources.返回;
            this.btFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btFirst.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.btFirst.Location = new System.Drawing.Point(402, 312);
            this.btFirst.Name = "btFirst";
            this.btFirst.Size = new System.Drawing.Size(141, 52);
            this.btFirst.TabIndex = 11;
            this.btFirst.UseVisualStyleBackColor = true;
            this.btFirst.Click += new System.EventHandler(this.btFirst_Click);
            // 
            // tbCustNO
            // 
            this.tbCustNO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCustNO.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold);
            this.tbCustNO.Location = new System.Drawing.Point(196, 106);
            this.tbCustNO.MaxLength = 5;
            this.tbCustNO.Name = "tbCustNO";
            this.tbCustNO.Size = new System.Drawing.Size(419, 46);
            this.tbCustNO.TabIndex = 12;
            this.tbCustNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCustNO.WatermarkText = "请输入手机或编号";
            this.tbCustNO.TextChanged += new System.EventHandler(this.tbCustNO_TextChanged);
            // 
            // rbNO
            // 
            this.rbNO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbNO.AutoSize = true;
            this.rbNO.BackColor = System.Drawing.Color.Transparent;
            this.rbNO.Checked = true;
            this.rbNO.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbNO.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbNO.Location = new System.Drawing.Point(260, 221);
            this.rbNO.Name = "rbNO";
            this.rbNO.Size = new System.Drawing.Size(114, 32);
            this.rbNO.TabIndex = 13;
            this.rbNO.TabStop = true;
            this.rbNO.Text = "客户编号";
            this.rbNO.UseVisualStyleBackColor = false;
            this.rbNO.CheckedChanged += new System.EventHandler(this.rbNO_CheckedChanged);
            // 
            // rbMobile
            // 
            this.rbMobile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbMobile.AutoSize = true;
            this.rbMobile.BackColor = System.Drawing.Color.Transparent;
            this.rbMobile.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbMobile.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbMobile.Location = new System.Drawing.Point(411, 221);
            this.rbMobile.Name = "rbMobile";
            this.rbMobile.Size = new System.Drawing.Size(93, 32);
            this.rbMobile.TabIndex = 14;
            this.rbMobile.Text = "手机号";
            this.rbMobile.UseVisualStyleBackColor = false;
            this.rbMobile.CheckedChanged += new System.EventHandler(this.rbNO_CheckedChanged);
            // 
            // lbCustInfo
            // 
            this.lbCustInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCustInfo.AutoSize = true;
            this.lbCustInfo.BackColor = System.Drawing.Color.Transparent;
            this.lbCustInfo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCustInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbCustInfo.Location = new System.Drawing.Point(205, 170);
            this.lbCustInfo.Name = "lbCustInfo";
            this.lbCustInfo.Size = new System.Drawing.Size(65, 20);
            this.lbCustInfo.TabIndex = 15;
            this.lbCustInfo.Text = "客户信息";
            // 
            // PartSign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lbCustInfo);
            this.Controls.Add(this.rbMobile);
            this.Controls.Add(this.rbNO);
            this.Controls.Add(this.tbCustNO);
            this.Controls.Add(this.btFirst);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.btSign);
            this.Controls.Add(this.lbMobileNO);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "PartSign";
            this.Size = new System.Drawing.Size(814, 456);
            this.Load += new System.EventHandler(this.PartSign_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMobileNO;
        private System.Windows.Forms.Button btSign;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button btFirst;
        private PrintApp.Common.WatermarkTextBox tbCustNO;
        private System.Windows.Forms.RadioButton rbNO;
        private System.Windows.Forms.RadioButton rbMobile;
        private System.Windows.Forms.Label lbCustInfo;
    }
}

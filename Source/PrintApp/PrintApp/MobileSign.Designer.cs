namespace PrintApp
{
    partial class MobileSign
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
            this.label1 = new System.Windows.Forms.Label();
            this.btSign = new System.Windows.Forms.Button();
            this.btFirst = new System.Windows.Forms.Button();
            this.lbCustInfo = new System.Windows.Forms.Label();
            this.tbMobile = new PrintApp.Common.WatermarkTextBox();
            this.keyBoard1 = new PrintApp.KeyBoard();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "请输入手机号";
            // 
            // btSign
            // 
            this.btSign.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSign.BackgroundImage = global::PrintApp.Properties.Resources.确定;
            this.btSign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSign.Enabled = false;
            this.btSign.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.btSign.Location = new System.Drawing.Point(264, 419);
            this.btSign.Name = "btSign";
            this.btSign.Size = new System.Drawing.Size(141, 52);
            this.btSign.TabIndex = 2;
            this.btSign.UseVisualStyleBackColor = true;
            this.btSign.Click += new System.EventHandler(this.btSign_Click);
            // 
            // btFirst
            // 
            this.btFirst.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btFirst.BackgroundImage = global::PrintApp.Properties.Resources.返回;
            this.btFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btFirst.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.btFirst.Location = new System.Drawing.Point(411, 419);
            this.btFirst.Name = "btFirst";
            this.btFirst.Size = new System.Drawing.Size(141, 52);
            this.btFirst.TabIndex = 11;
            this.btFirst.UseVisualStyleBackColor = true;
            this.btFirst.Click += new System.EventHandler(this.btFirst_Click);
            // 
            // lbCustInfo
            // 
            this.lbCustInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCustInfo.AutoSize = true;
            this.lbCustInfo.BackColor = System.Drawing.Color.Transparent;
            this.lbCustInfo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCustInfo.ForeColor = System.Drawing.Color.Gray;
            this.lbCustInfo.Location = new System.Drawing.Point(233, 89);
            this.lbCustInfo.Name = "lbCustInfo";
            this.lbCustInfo.Size = new System.Drawing.Size(65, 20);
            this.lbCustInfo.TabIndex = 16;
            this.lbCustInfo.Text = "客户信息";
            this.lbCustInfo.Visible = false;
            // 
            // tbMobile
            // 
            this.tbMobile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbMobile.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbMobile.Location = new System.Drawing.Point(230, 39);
            this.tbMobile.MaxLength = 11;
            this.tbMobile.Name = "tbMobile";
            this.tbMobile.Size = new System.Drawing.Size(360, 46);
            this.tbMobile.TabIndex = 17;
            this.tbMobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMobile.WatermarkText = "请输入手机号";
            this.tbMobile.TextChanged += new System.EventHandler(this.tbMobile_TextChanged);
            // 
            // keyBoard1
            // 
            this.keyBoard1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.keyBoard1.BackColor = System.Drawing.Color.Transparent;
            this.keyBoard1.Location = new System.Drawing.Point(227, 125);
            this.keyBoard1.Name = "keyBoard1";
            this.keyBoard1.Size = new System.Drawing.Size(379, 247);
            this.keyBoard1.TabIndex = 18;
            // 
            // MobileSign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.keyBoard1);
            this.Controls.Add(this.tbMobile);
            this.Controls.Add(this.lbCustInfo);
            this.Controls.Add(this.btFirst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSign);
            this.DoubleBuffered = true;
            this.Name = "MobileSign";
            this.Size = new System.Drawing.Size(833, 496);
            this.Load += new System.EventHandler(this.MobileSign_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btFirst;
        private System.Windows.Forms.Label lbCustInfo;
        private Common.WatermarkTextBox tbMobile;
        private KeyBoard keyBoard1;
    }
}

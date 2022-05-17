namespace PrintApp
{
    partial class PrintPage
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
            this.btSign = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCustNO = new PrintApp.Common.WatermarkTextBox();
            this.btFirst = new System.Windows.Forms.Button();
            this.lbCustInfo = new System.Windows.Forms.Label();
            this.keyBoard1 = new PrintApp.KeyBoard();
            this.SuspendLayout();
            // 
            // btSign
            // 
            this.btSign.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSign.BackgroundImage = global::PrintApp.Properties.Resources.确定;
            this.btSign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSign.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.btSign.Location = new System.Drawing.Point(277, 374);
            this.btSign.Name = "btSign";
            this.btSign.Size = new System.Drawing.Size(141, 52);
            this.btSign.TabIndex = 5;
            this.btSign.UseVisualStyleBackColor = true;
            this.btSign.Click += new System.EventHandler(this.btSign_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "请输入手机号或者客户号";
            // 
            // tbCustNO
            // 
            this.tbCustNO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCustNO.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold);
            this.tbCustNO.Location = new System.Drawing.Point(216, 15);
            this.tbCustNO.MaxLength = 15;
            this.tbCustNO.Name = "tbCustNO";
            this.tbCustNO.Size = new System.Drawing.Size(392, 46);
            this.tbCustNO.TabIndex = 10;
            this.tbCustNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCustNO.WatermarkText = "手机号或编号";
            this.tbCustNO.TextChanged += new System.EventHandler(this.tbCustNO_TextChanged);
            // 
            // btFirst
            // 
            this.btFirst.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btFirst.BackgroundImage = global::PrintApp.Properties.Resources.返回;
            this.btFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btFirst.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.btFirst.Location = new System.Drawing.Point(424, 374);
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
            this.lbCustInfo.Location = new System.Drawing.Point(220, 64);
            this.lbCustInfo.Name = "lbCustInfo";
            this.lbCustInfo.Size = new System.Drawing.Size(65, 20);
            this.lbCustInfo.TabIndex = 17;
            this.lbCustInfo.Text = "客户信息";
            // 
            // keyBoard1
            // 
            this.keyBoard1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.keyBoard1.BackColor = System.Drawing.Color.Transparent;
            this.keyBoard1.Location = new System.Drawing.Point(229, 101);
            this.keyBoard1.Name = "keyBoard1";
            this.keyBoard1.Size = new System.Drawing.Size(379, 247);
            this.keyBoard1.TabIndex = 18;
            // 
            // PrintPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.keyBoard1);
            this.Controls.Add(this.lbCustInfo);
            this.Controls.Add(this.btFirst);
            this.Controls.Add(this.tbCustNO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSign);
            this.DoubleBuffered = true;
            this.Name = "PrintPage";
            this.Size = new System.Drawing.Size(837, 448);
            this.Load += new System.EventHandler(this.PrintPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSign;
        private System.Windows.Forms.Label label1;
        private Common.WatermarkTextBox tbCustNO;
        private System.Windows.Forms.Button btFirst;
        private System.Windows.Forms.Label lbCustInfo;
        private KeyBoard keyBoard1;
    }
}

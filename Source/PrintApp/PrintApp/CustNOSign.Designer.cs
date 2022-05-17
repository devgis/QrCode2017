namespace PrintApp
{
    partial class CustNOSign
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
            this.tbCustNO = new PrintApp.Common.WatermarkTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btFirst = new System.Windows.Forms.Button();
            this.lbCustInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbCustNO
            // 
            this.tbCustNO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCustNO.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbCustNO.Location = new System.Drawing.Point(350, 406);
            this.tbCustNO.MaxLength = 5;
            this.tbCustNO.Name = "tbCustNO";
            this.tbCustNO.Size = new System.Drawing.Size(228, 46);
            this.tbCustNO.TabIndex = 9;
            this.tbCustNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCustNO.WatermarkText = "请扫码";
            this.tbCustNO.TextChanged += new System.EventHandler(this.tbCustNO_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "请输入客户号";
            // 
            // btFirst
            // 
            this.btFirst.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btFirst.BackgroundImage = global::PrintApp.Properties.Resources.返回;
            this.btFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btFirst.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btFirst.Location = new System.Drawing.Point(575, 411);
            this.btFirst.Name = "btFirst";
            this.btFirst.Size = new System.Drawing.Size(141, 52);
            this.btFirst.TabIndex = 10;
            this.btFirst.UseVisualStyleBackColor = true;
            this.btFirst.Visible = false;
            this.btFirst.Click += new System.EventHandler(this.btFirst_Click);
            // 
            // lbCustInfo
            // 
            this.lbCustInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCustInfo.AutoSize = true;
            this.lbCustInfo.BackColor = System.Drawing.Color.Transparent;
            this.lbCustInfo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCustInfo.ForeColor = System.Drawing.Color.Gray;
            this.lbCustInfo.Location = new System.Drawing.Point(584, 415);
            this.lbCustInfo.Name = "lbCustInfo";
            this.lbCustInfo.Size = new System.Drawing.Size(65, 20);
            this.lbCustInfo.TabIndex = 16;
            this.lbCustInfo.Text = "客户信息";
            this.lbCustInfo.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(172, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 27);
            this.label2.TabIndex = 17;
            this.label2.Text = "获取条形码的号码";
            // 
            // CustNOSign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PrintApp.Properties.Resources.二维码签到页面;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCustInfo);
            this.Controls.Add(this.btFirst);
            this.Controls.Add(this.tbCustNO);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "CustNOSign";
            this.Size = new System.Drawing.Size(833, 496);
            this.Load += new System.EventHandler(this.CustNOSign_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private PrintApp.Common.WatermarkTextBox tbCustNO;
        private System.Windows.Forms.Button btFirst;
        private System.Windows.Forms.Label lbCustInfo;
        private System.Windows.Forms.Label label2;
    }
}

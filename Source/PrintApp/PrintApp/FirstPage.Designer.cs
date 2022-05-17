namespace PrintApp
{
    partial class FirstPage
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
            this.btQrCodeSign = new System.Windows.Forms.Button();
            this.btMobileSign = new System.Windows.Forms.Button();
            this.lbPrint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btQrCodeSign
            // 
            this.btQrCodeSign.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btQrCodeSign.BackgroundImage = global::PrintApp.Properties.Resources.二维码签到;
            this.btQrCodeSign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btQrCodeSign.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btQrCodeSign.Location = new System.Drawing.Point(116, 343);
            this.btQrCodeSign.Name = "btQrCodeSign";
            this.btQrCodeSign.Size = new System.Drawing.Size(183, 49);
            this.btQrCodeSign.TabIndex = 0;
            this.btQrCodeSign.UseVisualStyleBackColor = true;
            this.btQrCodeSign.Click += new System.EventHandler(this.btQrCodeSign_Click);
            // 
            // btMobileSign
            // 
            this.btMobileSign.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btMobileSign.BackgroundImage = global::PrintApp.Properties.Resources.手机号签到;
            this.btMobileSign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btMobileSign.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btMobileSign.Location = new System.Drawing.Point(446, 342);
            this.btMobileSign.Name = "btMobileSign";
            this.btMobileSign.Size = new System.Drawing.Size(183, 49);
            this.btMobileSign.TabIndex = 1;
            this.btMobileSign.UseVisualStyleBackColor = true;
            this.btMobileSign.Click += new System.EventHandler(this.btMobileSign_Click);
            // 
            // lbPrint
            // 
            this.lbPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPrint.AutoSize = true;
            this.lbPrint.BackColor = System.Drawing.Color.Transparent;
            this.lbPrint.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPrint.ForeColor = System.Drawing.Color.White;
            this.lbPrint.Location = new System.Drawing.Point(660, 400);
            this.lbPrint.Name = "lbPrint";
            this.lbPrint.Size = new System.Drawing.Size(65, 20);
            this.lbPrint.TabIndex = 3;
            this.lbPrint.Text = "遗失打印";
            this.lbPrint.Click += new System.EventHandler(this.lbPrint_Click);
            // 
            // FirstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PrintApp.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lbPrint);
            this.Controls.Add(this.btMobileSign);
            this.Controls.Add(this.btQrCodeSign);
            this.DoubleBuffered = true;
            this.Name = "FirstPage";
            this.Size = new System.Drawing.Size(745, 439);
            this.Load += new System.EventHandler(this.FirstPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btQrCodeSign;
        private System.Windows.Forms.Button btMobileSign;
        private System.Windows.Forms.Label lbPrint;
    }
}

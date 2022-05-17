namespace Dine
{
    partial class MainForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label2 = new System.Windows.Forms.Label();
            this.tbCustNO = new PrintApp.Common.WatermarkTextBox();
            this.btSign = new System.Windows.Forms.Button();
            this.lbShowInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(111, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 62);
            this.label2.TabIndex = 16;
            this.label2.Text = "客户编号";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCustNO
            // 
            this.tbCustNO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCustNO.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbCustNO.Location = new System.Drawing.Point(360, 188);
            this.tbCustNO.MaxLength = 5;
            this.tbCustNO.Name = "tbCustNO";
            this.tbCustNO.Size = new System.Drawing.Size(239, 71);
            this.tbCustNO.TabIndex = 20;
            this.tbCustNO.WatermarkText = "客户编号";
            this.tbCustNO.TextChanged += new System.EventHandler(this.tbCustNO_TextChanged);
            // 
            // btSign
            // 
            this.btSign.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSign.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSign.Location = new System.Drawing.Point(222, 347);
            this.btSign.Name = "btSign";
            this.btSign.Size = new System.Drawing.Size(294, 54);
            this.btSign.TabIndex = 24;
            this.btSign.Text = "就餐验证";
            this.btSign.UseVisualStyleBackColor = true;
            this.btSign.Click += new System.EventHandler(this.btSign_Click);
            // 
            // lbShowInfo
            // 
            this.lbShowInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbShowInfo.AutoSize = true;
            this.lbShowInfo.BackColor = System.Drawing.Color.Transparent;
            this.lbShowInfo.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbShowInfo.Location = new System.Drawing.Point(225, 301);
            this.lbShowInfo.Name = "lbShowInfo";
            this.lbShowInfo.Size = new System.Drawing.Size(44, 38);
            this.lbShowInfo.TabIndex = 25;
            this.lbShowInfo.Text = "   ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(723, 449);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCustNO);
            this.Controls.Add(this.btSign);
            this.Controls.Add(this.lbShowInfo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "临时签到打印程序";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private PrintApp.Common.WatermarkTextBox tbCustNO;
        private System.Windows.Forms.Button btSign;
        private System.Windows.Forms.Label lbShowInfo;

    }
}


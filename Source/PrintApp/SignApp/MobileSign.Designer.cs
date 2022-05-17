namespace SignApp
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
            this.keyBoard1 = new SignApp.KeyBoard();
            this.btSign = new System.Windows.Forms.Button();
            this.lbMobileNO = new System.Windows.Forms.Label();
            this.btFirst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "请输入手机号";
            // 
            // keyBoard1
            // 
            this.keyBoard1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.keyBoard1.Location = new System.Drawing.Point(210, 89);
            this.keyBoard1.Name = "keyBoard1";
            this.keyBoard1.Size = new System.Drawing.Size(379, 247);
            this.keyBoard1.TabIndex = 3;
            // 
            // btSign
            // 
            this.btSign.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btSign.Enabled = false;
            this.btSign.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.btSign.Location = new System.Drawing.Point(255, 363);
            this.btSign.Name = "btSign";
            this.btSign.Size = new System.Drawing.Size(141, 52);
            this.btSign.TabIndex = 2;
            this.btSign.Text = "确认";
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
            this.btFirst.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btFirst.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.btFirst.Location = new System.Drawing.Point(402, 363);
            this.btFirst.Name = "btFirst";
            this.btFirst.Size = new System.Drawing.Size(141, 52);
            this.btFirst.TabIndex = 11;
            this.btFirst.Text = "返回";
            this.btFirst.UseVisualStyleBackColor = true;
            this.btFirst.Click += new System.EventHandler(this.btFirst_Click);
            // 
            // MobileSign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btFirst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keyBoard1);
            this.Controls.Add(this.btSign);
            this.Controls.Add(this.lbMobileNO);
            this.Name = "MobileSign";
            this.Size = new System.Drawing.Size(814, 456);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMobileNO;
        private System.Windows.Forms.Button btSign;
        private KeyBoard keyBoard1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btFirst;
    }
}

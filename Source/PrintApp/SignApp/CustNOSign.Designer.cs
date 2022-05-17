namespace SignApp
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
            this.tbCustNO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSign = new System.Windows.Forms.Button();
            this.keyBoard1 = new SignApp.KeyBoard();
            this.btFirst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCustNO
            // 
            this.tbCustNO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbCustNO.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Bold);
            this.tbCustNO.Location = new System.Drawing.Point(319, 17);
            this.tbCustNO.MaxLength = 5;
            this.tbCustNO.Name = "tbCustNO";
            this.tbCustNO.Size = new System.Drawing.Size(187, 81);
            this.tbCustNO.TabIndex = 9;
            this.tbCustNO.TextChanged += new System.EventHandler(this.tbCustNO_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "请输入客户号";
            // 
            // btSign
            // 
            this.btSign.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btSign.Enabled = false;
            this.btSign.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSign.Location = new System.Drawing.Point(269, 389);
            this.btSign.Name = "btSign";
            this.btSign.Size = new System.Drawing.Size(141, 52);
            this.btSign.TabIndex = 5;
            this.btSign.Text = "确认";
            this.btSign.UseVisualStyleBackColor = true;
            this.btSign.Click += new System.EventHandler(this.btSign_Click);
            // 
            // keyBoard1
            // 
            this.keyBoard1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.keyBoard1.Location = new System.Drawing.Point(227, 116);
            this.keyBoard1.Name = "keyBoard1";
            this.keyBoard1.Size = new System.Drawing.Size(379, 247);
            this.keyBoard1.TabIndex = 6;
            // 
            // btFirst
            // 
            this.btFirst.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btFirst.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btFirst.Location = new System.Drawing.Point(416, 389);
            this.btFirst.Name = "btFirst";
            this.btFirst.Size = new System.Drawing.Size(141, 52);
            this.btFirst.TabIndex = 10;
            this.btFirst.Text = "返回";
            this.btFirst.UseVisualStyleBackColor = true;
            this.btFirst.Click += new System.EventHandler(this.btFirst_Click);
            // 
            // CustNOSign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btFirst);
            this.Controls.Add(this.tbCustNO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keyBoard1);
            this.Controls.Add(this.btSign);
            this.Name = "CustNOSign";
            this.Size = new System.Drawing.Size(833, 496);
            this.Load += new System.EventHandler(this.CustNOSign_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KeyBoard keyBoard1;
        private System.Windows.Forms.Button btSign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCustNO;
        private System.Windows.Forms.Button btFirst;
    }
}

namespace Test
{
    partial class Form1
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
            this.watermarkTextBox1 = new PrintApp.Common.WatermarkTextBox();
            this.watermarkTextBox2 = new PrintApp.Common.WatermarkTextBox();
            this.SuspendLayout();
            // 
            // watermarkTextBox1
            // 
            this.watermarkTextBox1.Location = new System.Drawing.Point(128, 82);
            this.watermarkTextBox1.Name = "watermarkTextBox1";
            this.watermarkTextBox1.Size = new System.Drawing.Size(100, 21);
            this.watermarkTextBox1.TabIndex = 0;
            this.watermarkTextBox1.WatermarkText = "hha";
            // 
            // watermarkTextBox2
            // 
            this.watermarkTextBox2.Location = new System.Drawing.Point(128, 109);
            this.watermarkTextBox2.Name = "watermarkTextBox2";
            this.watermarkTextBox2.Size = new System.Drawing.Size(100, 21);
            this.watermarkTextBox2.TabIndex = 1;
            this.watermarkTextBox2.WatermarkText = "hha";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.watermarkTextBox2);
            this.Controls.Add(this.watermarkTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PrintApp.Common.WatermarkTextBox watermarkTextBox1;
        private PrintApp.Common.WatermarkTextBox watermarkTextBox2;
    }
}


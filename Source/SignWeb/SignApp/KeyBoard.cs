using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SignApp
{
    public class KeyBoard : UserControl
    {
        private Panel panel1;
        public MainForm mainform = null;

        public KeyBoard()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelClear = new System.Windows.Forms.Panel();
            this.labelClear = new System.Windows.Forms.Label();
            this.panel0 = new System.Windows.Forms.Panel();
            this.label0 = new System.Windows.Forms.Label();
            this.panelDelete = new System.Windows.Forms.Panel();
            this.labelDelete = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelClear.SuspendLayout();
            this.panel0.SuspendLayout();
            this.panelDelete.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.panelClear, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel0, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panelDelete, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(566, 263);
            this.tableLayoutPanel1.TabIndex = 6;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.panel9_Click);
            // 
            // panelClear
            // 
            this.panelClear.BackgroundImage = global::SignApp.Properties.Resources.重置;
            this.panelClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelClear.Controls.Add(this.labelClear);
            this.panelClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelClear.Location = new System.Drawing.Point(379, 198);
            this.panelClear.Name = "panelClear";
            this.panelClear.Size = new System.Drawing.Size(184, 62);
            this.panelClear.TabIndex = 15;
            this.panelClear.Click += new System.EventHandler(this.panel9_Click);
            // 
            // labelClear
            // 
            this.labelClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelClear.AutoSize = true;
            this.labelClear.BackColor = System.Drawing.Color.Transparent;
            this.labelClear.Location = new System.Drawing.Point(66, 2);
            this.labelClear.Name = "labelClear";
            this.labelClear.Size = new System.Drawing.Size(55, 46);
            this.labelClear.TabIndex = 0;
            this.labelClear.Text = "清";
            this.labelClear.Visible = false;
            this.labelClear.Click += new System.EventHandler(this.panel9_Click);
            // 
            // panel0
            // 
            this.panel0.BackgroundImage = global::SignApp.Properties.Resources._00;
            this.panel0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel0.Controls.Add(this.label0);
            this.panel0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel0.Location = new System.Drawing.Point(191, 198);
            this.panel0.Name = "panel0";
            this.panel0.Size = new System.Drawing.Size(182, 62);
            this.panel0.TabIndex = 14;
            this.panel0.Click += new System.EventHandler(this.panel9_Click);
            // 
            // label0
            // 
            this.label0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label0.AutoSize = true;
            this.label0.BackColor = System.Drawing.Color.Transparent;
            this.label0.Location = new System.Drawing.Point(66, 2);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(42, 46);
            this.label0.TabIndex = 0;
            this.label0.Text = "0";
            this.label0.Visible = false;
            this.label0.Click += new System.EventHandler(this.panel9_Click);
            // 
            // panelDelete
            // 
            this.panelDelete.BackgroundImage = global::SignApp.Properties.Resources.删除;
            this.panelDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDelete.Controls.Add(this.labelDelete);
            this.panelDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDelete.Location = new System.Drawing.Point(3, 198);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(182, 62);
            this.panelDelete.TabIndex = 13;
            this.panelDelete.Click += new System.EventHandler(this.panel9_Click);
            // 
            // labelDelete
            // 
            this.labelDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDelete.AutoSize = true;
            this.labelDelete.BackColor = System.Drawing.Color.Transparent;
            this.labelDelete.Location = new System.Drawing.Point(66, 2);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(55, 46);
            this.labelDelete.TabIndex = 0;
            this.labelDelete.Text = "删";
            this.labelDelete.Visible = false;
            this.labelDelete.Click += new System.EventHandler(this.panel9_Click);
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = global::SignApp.Properties.Resources._09;
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel9.Controls.Add(this.label9);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(379, 133);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(184, 59);
            this.panel9.TabIndex = 12;
            this.panel9.Click += new System.EventHandler(this.panel9_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(66, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 46);
            this.label9.TabIndex = 0;
            this.label9.Text = "9";
            this.label9.Visible = false;
            this.label9.Click += new System.EventHandler(this.panel9_Click);
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = global::SignApp.Properties.Resources._08;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Controls.Add(this.label8);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(191, 133);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(182, 59);
            this.panel8.TabIndex = 11;
            this.panel8.Click += new System.EventHandler(this.panel9_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(66, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 46);
            this.label8.TabIndex = 0;
            this.label8.Text = "8";
            this.label8.Visible = false;
            this.label8.Click += new System.EventHandler(this.panel9_Click);
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = global::SignApp.Properties.Resources._07;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Controls.Add(this.label7);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 133);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(182, 59);
            this.panel7.TabIndex = 10;
            this.panel7.Click += new System.EventHandler(this.panel9_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(66, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 46);
            this.label7.TabIndex = 0;
            this.label7.Text = "7";
            this.label7.Visible = false;
            this.label7.Click += new System.EventHandler(this.panel9_Click);
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::SignApp.Properties.Resources._06;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.label6);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(379, 68);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(184, 59);
            this.panel6.TabIndex = 9;
            this.panel6.Click += new System.EventHandler(this.panel9_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(66, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 46);
            this.label6.TabIndex = 0;
            this.label6.Text = "6";
            this.label6.Visible = false;
            this.label6.Click += new System.EventHandler(this.panel9_Click);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::SignApp.Properties.Resources._05;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(191, 68);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(182, 59);
            this.panel5.TabIndex = 8;
            this.panel5.Click += new System.EventHandler(this.panel9_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(66, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 46);
            this.label5.TabIndex = 0;
            this.label5.Text = "5";
            this.label5.Visible = false;
            this.label5.Click += new System.EventHandler(this.panel9_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::SignApp.Properties.Resources._04;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 68);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(182, 59);
            this.panel4.TabIndex = 6;
            this.panel4.Click += new System.EventHandler(this.panel9_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(66, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 46);
            this.label4.TabIndex = 0;
            this.label4.Text = "4";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.panel9_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::SignApp.Properties.Resources._03;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(379, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 59);
            this.panel3.TabIndex = 7;
            this.panel3.Click += new System.EventHandler(this.panel9_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(66, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 46);
            this.label3.TabIndex = 0;
            this.label3.Text = "3";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.panel9_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::SignApp.Properties.Resources._02;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(191, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 59);
            this.panel2.TabIndex = 6;
            this.panel2.Click += new System.EventHandler(this.panel9_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(66, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "2";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.panel9_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SignApp.Properties.Resources._01;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 59);
            this.panel1.TabIndex = 5;
            this.panel1.Click += new System.EventHandler(this.panel9_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(66, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "1";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.panel9_Click);
            // 
            // KeyBoard
            // 
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "KeyBoard";
            this.Size = new System.Drawing.Size(566, 263);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelClear.ResumeLayout(false);
            this.panelClear.PerformLayout();
            this.panel0.ResumeLayout(false);
            this.panel0.PerformLayout();
            this.panelDelete.ResumeLayout(false);
            this.panelDelete.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelClear;
        private Label labelClear;
        private Panel panel0;
        private Label label0;
        private Panel panelDelete;
        private Label labelDelete;
        private Panel panel9;
        private Label label9;
        private Panel panel8;
        private Label label8;
        private Panel panel7;
        private Label label7;
        private Panel panel6;
        private Label label6;
        private Panel panel5;
        private Label label5;
        private Panel panel4;
        private Label label4;
        private Panel panel3;
        private Label label3;
        private Panel panel2;
        private Label label2;

        public Control KeyBordContent = null;
        public int MaxLength = 4;

        private void panel9_Click(object sender, EventArgs e)
        {
            string Name=string.Empty;
            if (sender is Label)
            {
                Name = (sender as Label).Name; 
            }
            else if (sender is Panel)
            {
                Name = (sender as Panel).Name;
            }
            if (!string.IsNullOrEmpty(Name))
            {
                string value = string.Empty;
                switch (Name)
                {
                    case "label0":
                    case "panel0":
                        value = "0";
                        break;
                    case "label1":
                    case "panel1":
                        value = "1";
                        break;
                    case "label2":
                    case "panel2":
                        value = "2";
                        break;
                    case "label3":
                    case "panel3":
                        value = "3";
                        break;
                    case "label4":
                    case "panel4":
                        value = "4";
                        break;
                    case "label5":
                    case "panel5":
                        value = "5";
                        break;
                    case "label6":
                    case "panel6":
                        value = "6";
                        break;
                    case "label7":
                    case "panel7":
                        value = "7";
                        break;
                    case "label8":
                    case "panel8":
                        value = "8";
                        break;
                    case "label9":
                    case "panel9":
                        value = "9";
                        break;
                    case "labelDelete":
                    case "panelDelete":
                        value = "delete";
                        break;
                    case "labelClear":
                    case "panelClear":
                        value = "clear";
                        break;
                }

                if (!string.IsNullOrEmpty(value))
                {
                    if (KeyBordContent != null)
                    {
                        if ("clear".Equals(value))
                        {
                            KeyBordContent.Text = string.Empty;
                        }
                        else if ("delete".Equals(value))
                        {
                            if (!string.IsNullOrEmpty(KeyBordContent.Text))
                            {
                                KeyBordContent.Text = KeyBordContent.Text.Remove(KeyBordContent.Text.Length - 1);
                            }
                        }
                        else
                        {
                            if (KeyBordContent.Text.Length <= MaxLength - 1)
                            {
                                KeyBordContent.Text += value;
                            }
                        }
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PrintApp
{
    public class KeyBoard : UserControl
    {
        private Panel panel1;
        public MainForm mainform = null;

        public KeyBoard()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            tableLayoutPanel1.GetType().GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(tableLayoutPanel1,
                true, null);
            base.OnLoad(e);
        }

        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelClear = new System.Windows.Forms.Panel();
            this.panel0 = new System.Windows.Forms.Panel();
            this.panelDelete = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.panelClear.BackgroundImage = global::PrintApp.Properties.Resources.重置;
            this.panelClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelClear.Location = new System.Drawing.Point(379, 198);
            this.panelClear.Name = "panelClear";
            this.panelClear.Size = new System.Drawing.Size(184, 62);
            this.panelClear.TabIndex = 15;
            this.panelClear.Click += new System.EventHandler(this.panel9_Click);
            // 
            // panel0
            // 
            this.panel0.BackgroundImage = global::PrintApp.Properties.Resources._00;
            this.panel0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel0.Location = new System.Drawing.Point(191, 198);
            this.panel0.Name = "panel0";
            this.panel0.Size = new System.Drawing.Size(182, 62);
            this.panel0.TabIndex = 14;
            this.panel0.Click += new System.EventHandler(this.panel9_Click);
            // 
            // panelDelete
            // 
            this.panelDelete.BackgroundImage = global::PrintApp.Properties.Resources.删除;
            this.panelDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDelete.Location = new System.Drawing.Point(3, 198);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(182, 62);
            this.panelDelete.TabIndex = 13;
            this.panelDelete.Click += new System.EventHandler(this.panel9_Click);
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = global::PrintApp.Properties.Resources._09;
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(379, 133);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(184, 59);
            this.panel9.TabIndex = 12;
            this.panel9.Click += new System.EventHandler(this.panel9_Click);
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = global::PrintApp.Properties.Resources._08;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(191, 133);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(182, 59);
            this.panel8.TabIndex = 11;
            this.panel8.Click += new System.EventHandler(this.panel9_Click);
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = global::PrintApp.Properties.Resources._07;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 133);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(182, 59);
            this.panel7.TabIndex = 10;
            this.panel7.Click += new System.EventHandler(this.panel9_Click);
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::PrintApp.Properties.Resources._06;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(379, 68);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(184, 59);
            this.panel6.TabIndex = 9;
            this.panel6.Click += new System.EventHandler(this.panel9_Click);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::PrintApp.Properties.Resources._05;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(191, 68);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(182, 59);
            this.panel5.TabIndex = 8;
            this.panel5.Click += new System.EventHandler(this.panel9_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::PrintApp.Properties.Resources._04;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 68);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(182, 59);
            this.panel4.TabIndex = 6;
            this.panel4.Click += new System.EventHandler(this.panel9_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::PrintApp.Properties.Resources._03;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(379, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 59);
            this.panel3.TabIndex = 7;
            this.panel3.Click += new System.EventHandler(this.panel9_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::PrintApp.Properties.Resources._02;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(191, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 59);
            this.panel2.TabIndex = 6;
            this.panel2.Click += new System.EventHandler(this.panel9_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PrintApp.Properties.Resources._01;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 59);
            this.panel1.TabIndex = 5;
            this.panel1.Click += new System.EventHandler(this.panel9_Click);
            // 
            // KeyBoard
            // 
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "KeyBoard";
            this.Size = new System.Drawing.Size(566, 263);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelClear;
        private Panel panel0;
        private Panel panelDelete;
        private Panel panel9;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;

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

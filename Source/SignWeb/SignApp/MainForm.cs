using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;

namespace SignApp
{
    public partial class MainForm : Form
    {
        PrintDocument objDocument = null;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            PartSign firstPage = new PartSign();
            firstPage.MainFormWindow = this;
            firstPage.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(firstPage);

        }

    }
}

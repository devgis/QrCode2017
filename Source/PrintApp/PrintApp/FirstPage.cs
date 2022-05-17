using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace PrintApp
{
    public partial class FirstPage : MyWindow
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        private void btQrCodeSign_Click(object sender, EventArgs e)
        {
            CustNOSign custNOSign = new CustNOSign();
            custNOSign.Dock = DockStyle.Fill;
            custNOSign.MainFormWindow = this.MainFormWindow;
            this.MainFormWindow.Controls.Clear();
            this.MainFormWindow.Controls.Add(custNOSign);
        }

        private void btMobileSign_Click(object sender, EventArgs e)
        {
            MobileSign mobileSign = new MobileSign();
            mobileSign.Dock = DockStyle.Fill;
            mobileSign.MainFormWindow = this.MainFormWindow;
            this.MainFormWindow.Controls.Clear();
            this.MainFormWindow.Controls.Add(mobileSign);
        }

        //private void btPrint_Click(object sender, EventArgs e)
        //{
        //    PrintPage printPage = new PrintPage();
        //    printPage.Dock = DockStyle.Fill;
        //    printPage.MainFormWindow = this.MainFormWindow;
        //    this.MainFormWindow.Controls.Clear();
        //    this.MainFormWindow.Controls.Add(printPage);
        //}

        private void lbPrint_Click(object sender, EventArgs e)
        {
            PrintPage printPage = new PrintPage();
            printPage.Dock = DockStyle.Fill;
            printPage.MainFormWindow = this.MainFormWindow;
            this.MainFormWindow.Controls.Clear();
            this.MainFormWindow.Controls.Add(printPage);
        }

        private void FirstPage_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SignApp
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

        private void btPrint_Click(object sender, EventArgs e)
        {
            PrintPage printPage = new PrintPage();
            printPage.Dock = DockStyle.Fill;
            printPage.MainFormWindow = this.MainFormWindow;
            this.MainFormWindow.Controls.Clear();
            this.MainFormWindow.Controls.Add(printPage);
        }

        private void btnSelectFHS(object sender, EventArgs e)
        {
            int fhcNO = 0;
            if (sender is Button)
            {
                switch ((sender as Button).Name)
                {
                    case "btFHC1":
                        fhcNO = 1;
                        break;
                    case "btFHC2":
                        fhcNO = 2;
                        break;
                    case "btFHC3":
                        fhcNO = 3;
                        break;
                    case "btFHC4":
                        fhcNO = 4;
                        break;
                    case "btFHC5":
                        fhcNO = 5;
                        break;
                    case "btFHC6":
                        fhcNO = 6;
                        break;
                }
                if (fhcNO > 0)
                {
                    PartSign partSign = new PartSign(fhcNO);
                    partSign.Dock = DockStyle.Fill;
                    partSign.MainFormWindow = this.MainFormWindow;
                    this.MainFormWindow.Controls.Clear();
                    this.MainFormWindow.Controls.Add(partSign);
                }
            }
        }
    }
}

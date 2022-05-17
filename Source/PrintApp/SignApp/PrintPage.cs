using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using PrintApp.Common;

namespace SignApp
{
    public partial class PrintPage : MyWindow
    {
        public PrintPage()
        {
            InitializeComponent();
            keyBoard1.KeyBordContent = tbCustNO;
            keyBoard1.MaxLength = 11;
        }

        private void btFirst_Click(object sender, EventArgs e)
        {
            FirstPage firstPage = new FirstPage();
            firstPage.Dock = DockStyle.Fill;
            firstPage.MainFormWindow = this.MainFormWindow;
            this.MainFormWindow.Controls.Clear();
            this.MainFormWindow.Controls.Add(firstPage);
        }

        private void btSign_Click(object sender, EventArgs e)
        {
            try
            {
                string custNO = string.Empty;
                if (CustomHelper.CanPrint(tbCustNO.Text, out custNO))
                {
                    this.MainFormWindow.Print(custNO);
                    //string[] arr = new string[] { "打印中", "请妥善保管" };
                    ShowResultPage showResultPage = new ShowResultPage(2);
                    showResultPage.Dock = DockStyle.Fill;
                    showResultPage.MainFormWindow = this.MainFormWindow;
                    this.MainFormWindow.Controls.Clear();
                    this.MainFormWindow.Controls.Add(showResultPage);
                }
                else
                {
                    //string[] arr = new string[] { "打印失败", "最大只能打印三次或者链接网络失败，请稍后再试" };
                    ShowResultPage showResultPage = new ShowResultPage(3);
                    showResultPage.Dock = DockStyle.Fill;
                    showResultPage.MainFormWindow = this.MainFormWindow;
                    this.MainFormWindow.Controls.Clear();
                    this.MainFormWindow.Controls.Add(showResultPage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("失败:" + ex.Message);
            }
        }
    }
}

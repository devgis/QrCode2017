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
    public partial class MobileSign : MyWindow
    {
        public MobileSign()
        {
            InitializeComponent();
            keyBoard1.KeyBordContent = lbMobileNO;
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
                string CustNO = string.Empty;
                if (CustomHelper.CustomSignByMobile(lbMobileNO.Text, out CustNO))
                {
                    if (!string.IsNullOrEmpty(CustNO))
                    {
                        this.MainFormWindow.Print(CustNO);
                    }
                    //string[] arr = new string[] { "签到成功", "正在为您打印大会条形码", "请妥善保管" };
                    ShowResultPage showResultPage = new ShowResultPage(1);
                    showResultPage.Dock = DockStyle.Fill;
                    showResultPage.MainFormWindow = this.MainFormWindow;
                    this.MainFormWindow.Controls.Clear();
                    this.MainFormWindow.Controls.Add(showResultPage);
                }
                else
                {
                    //string[] arr = new string[] { "签到失败", "请重新用二维码或者手机号进行签到", "" };
                    ShowResultPage showResultPage = new ShowResultPage(0);
                    showResultPage.Dock = DockStyle.Fill;
                    showResultPage.MainFormWindow = this.MainFormWindow;
                    this.MainFormWindow.Controls.Clear();
                    this.MainFormWindow.Controls.Add(showResultPage);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("失败:" + ex.Message);
                //string[] arr = new string[] { "签到失败", ex.Message, "" };
                ShowResultPage showResultPage = new ShowResultPage(0);
                showResultPage.Dock = DockStyle.Fill;
                showResultPage.MainFormWindow = this.MainFormWindow;
                this.MainFormWindow.Controls.Clear();
                this.MainFormWindow.Controls.Add(showResultPage);
            }
        }
    }
}

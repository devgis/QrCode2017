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
    public partial class CustNOSign : MyWindow
    {
        public CustNOSign()
        {
            InitializeComponent();
            keyBoard1.KeyBordContent = tbCustNO;
            keyBoard1.MaxLength = 4;
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
                if (CustomHelper.CustomSign(tbCustNO.Text))
                {
                    this.MainFormWindow.Print(tbCustNO.Text);
                    //string[] arr = new string[] { "签到成功", "正在为您打印大会条形码", "请妥善保管" };
                    ShowResultPage showResultPage = new ShowResultPage(1);
                    showResultPage.Dock = DockStyle.Fill;
                    showResultPage.MainFormWindow = this.MainFormWindow;
                    this.MainFormWindow.Controls.Clear();
                    this.MainFormWindow.Controls.Add(showResultPage);
                }
                else
                {
                    //string[] arr = new string[] { "签到失败可能已签到", "请重新用二维码或者手机号进行签到", "" };
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
            }
        }

        private void CustNOSign_Load(object sender, EventArgs e)
        {
            tbCustNO.Focus();
        }

        private void tbCustNO_TextChanged(object sender, EventArgs e)
        {
            if (tbCustNO.Text.Length == 5)
            {
                btSign.PerformClick();
            }
        }

    }
}

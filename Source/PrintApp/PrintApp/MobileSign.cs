using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using PrintApp.Common;

namespace PrintApp
{
    public partial class MobileSign : MyWindow
    {
        public MobileSign()
        {
            InitializeComponent();
            keyBoard1.KeyBordContent = tbMobile;
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
                ConfirmInfo confirmInfo = new ConfirmInfo(CSTNO);
                confirmInfo.Dock = DockStyle.Fill;
                confirmInfo.MainFormWindow = this.MainFormWindow;
                this.MainFormWindow.Controls.Clear();
                this.MainFormWindow.Controls.Add(confirmInfo);
                //if (CustomHelper.CustomSign(CSTNO))
                //{
                //    if (!string.IsNullOrEmpty(CSTNO))
                //    {
                //        this.MainFormWindow.Print(CSTNO);
                //    }
                //    //string[] arr = new string[] { "签到成功", "正在为您打印大会条形码", "请妥善保管" };
                //    ShowResultPage showResultPage = new ShowResultPage(1);
                //    showResultPage.Dock = DockStyle.Fill;
                //    showResultPage.MainFormWindow = this.MainFormWindow;
                //    this.MainFormWindow.Controls.Clear();
                //    this.MainFormWindow.Controls.Add(showResultPage);
                //}
                //else
                //{
                //    //string[] arr = new string[] { "签到失败", "请重新用二维码或者手机号进行签到", "" };
                //    ShowResultPage showResultPage = new ShowResultPage(0);
                //    showResultPage.Dock = DockStyle.Fill;
                //    showResultPage.MainFormWindow = this.MainFormWindow;
                //    this.MainFormWindow.Controls.Clear();
                //    this.MainFormWindow.Controls.Add(showResultPage);
                //}
            }
            catch (Exception ex)
            {
                ////MessageBox.Show("失败:" + ex.Message);
                ////string[] arr = new string[] { "签到失败", ex.Message, "" };
                //ShowResultPage showResultPage = new ShowResultPage(0);
                //showResultPage.Dock = DockStyle.Fill;
                //showResultPage.MainFormWindow = this.MainFormWindow;
                //this.MainFormWindow.Controls.Clear();
                //this.MainFormWindow.Controls.Add(showResultPage);
            }
        }
        string CSTNO = string.Empty;
        private void lbMobileNO_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void tbMobile_TextChanged(object sender, EventArgs e)
        {
            CSTNO = CustomHelper.GetCustomNo(tbMobile.Text);

            if (!string.IsNullOrEmpty(CSTNO))
            {
                DataRow row = CustomHelper.GetCustomRow(CSTNO);
                if (row != null)
                {
                    lbCustInfo.Text = row["CUSTNAME"].ToString();
                    btSign.Enabled = true;
                }
                else
                {
                    lbCustInfo.Text = string.Empty;
                    btSign.Enabled = false;
                }
            }
            else
            {
                lbCustInfo.Text = string.Empty;
                btSign.Enabled = false;
            }
        }

        private void MobileSign_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = MainForm.backimage;
        }
    }
}

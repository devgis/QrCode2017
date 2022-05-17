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
    public partial class CustNOSign : MyWindow
    {
        public CustNOSign()
        {
            InitializeComponent();
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
                //if (CustomHelper.CustomSign(CSTNO))
                //{
                //    this.MainFormWindow.Print(CSTNO);
                //    //string[] arr = new string[] { "签到成功", "正在为您打印大会条形码", "请妥善保管" };
                //    ShowResultPage showResultPage = new ShowResultPage(1);
                //    showResultPage.Dock = DockStyle.Fill;
                //    showResultPage.MainFormWindow = this.MainFormWindow;
                //    this.MainFormWindow.Controls.Clear();
                //    this.MainFormWindow.Controls.Add(showResultPage);
                //}
                //else
                //{
                //    //string[] arr = new string[] { "签到失败可能已签到", "请重新用二维码或者手机号进行签到", "" };
                //    ShowResultPage showResultPage = new ShowResultPage(0);
                //    showResultPage.Dock = DockStyle.Fill;
                //    showResultPage.MainFormWindow = this.MainFormWindow;
                //    this.MainFormWindow.Controls.Clear();
                //    this.MainFormWindow.Controls.Add(showResultPage);
                //}
                ConfirmInfo confirmInfo = new ConfirmInfo(CSTNO);
                confirmInfo.Dock = DockStyle.Fill;
                confirmInfo.MainFormWindow = this.MainFormWindow;
                this.MainFormWindow.Controls.Clear();
                this.MainFormWindow.Controls.Add(confirmInfo);
                
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

        string CSTNO = string.Empty;
        private void tbCustNO_TextChanged(object sender, EventArgs e)
        {
            if (tbCustNO.Text.Length < 5)
                return;
            //btSign.PerformClick();
            CSTNO = CustomHelper.GetCustomNo(tbCustNO.Text);
            if (!string.IsNullOrEmpty(CSTNO))
            {
                DataRow row = CustomHelper.GetCustomRow(CSTNO);
                if (row != null)
                {
                    lbCustInfo.Text = row["CUSTNAME"].ToString();
                    ConfirmInfo confirmInfo = new ConfirmInfo(CSTNO);
                    confirmInfo.Dock = DockStyle.Fill;
                    confirmInfo.MainFormWindow = this.MainFormWindow;
                    this.MainFormWindow.Controls.Clear();
                    this.MainFormWindow.Controls.Add(confirmInfo);
                }
                else
                {
                    lbCustInfo.Text = "未识别用户";
                }
            }
            else
            {
                lbCustInfo.Text = string.Empty;
            }
        }

    }
}

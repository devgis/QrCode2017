using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using PrintApp.Common;

namespace PrintApp
{
    public partial class ConfirmInfo : MyWindow
    {
        string CustNO = null;
        public ConfirmInfo(string custNO)
        {
            InitializeComponent();
            CustNO = custNO;
        }


        private void btFIrst_Click(object sender, EventArgs e)
        {
            FirstPage firstPage = new FirstPage();
            firstPage.Dock = DockStyle.Fill;
            firstPage.MainFormWindow = this.MainFormWindow;
            this.MainFormWindow.Controls.Clear();
            this.MainFormWindow.Controls.Add(firstPage);
        }

        private void LoadData(string custNO)
        {
            DataRow dr = CustomHelper.GetCustomRow(custNO);
            if (dr != null)
            {
                try
                {
                    tbCustType.Text = dr["CUSTTYPE"].ToString();
                }
                catch
                { }

                try
                {
                    tbCustName.Text = dr["CUSTNAME"].ToString();
                }
                catch
                { }

                try
                {
                    tbCompany.Text = dr["COMPANY"].ToString();
                }
                catch
                { }

                try
                {
                    tbPosition.Text = dr["POSITION"].ToString();
                }
                catch
                { }

                try
                {
                    tbMobile.Text = dr["MOBILE"].ToString();
                }
                catch
                { }
            }
        }

        private void btSign_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustomHelper.CustomSign(CustNO))
                {
                    this.MainFormWindow.Print(CustNO);
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
                //已签到
                ShowResultPage showResultPage = new ShowResultPage(5);
                showResultPage.Dock = DockStyle.Fill;
                showResultPage.MainFormWindow = this.MainFormWindow;
                this.MainFormWindow.Controls.Clear();
                this.MainFormWindow.Controls.Add(showResultPage);
            }
        }

        private void ConfirmInfo_Load(object sender, EventArgs e)
        {
            LoadData(CustNO);
        }
    }
}

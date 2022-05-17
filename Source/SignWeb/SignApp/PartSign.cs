using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SignWeb.Common;

namespace SignApp
{
    public partial class PartSign : MyWindow
    {
        public PartSign()
        {
            InitializeComponent();
            this.labelWelcome.Text = "";
        }

        private void btFirst_Click(object sender, EventArgs e)
        {
        }

        private void btSign_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustomHelper.CustomSign(CSTNO))
                {
                    this.lbCustInfo.Text = "签到成功！";
                }
                else
                {
                    this.lbCustInfo.Text = "签到失败！";
                }
            }
            catch (Exception ex)
            {
                this.lbCustInfo.Text = "签到失败:"+ex.Message;
            }
        }

        string CSTNO = string.Empty;
        private void tbCustNO_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CSTNO = CustomHelper.GetCustomNo(tbCustNO.Text);
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
            catch
            { }
        }
        private void PartSign_Load(object sender, EventArgs e)
        {
            //this.BackgroundImage = global::SignApp.Properties.Resources._2;
        }
    }
}

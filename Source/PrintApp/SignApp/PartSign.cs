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
    public partial class PartSign : MyWindow
    {
        int partno = 0;
        public PartSign(int partNO)
        {
            InitializeComponent();
            partno = partNO;
            this.labelWelcome.Text = string.Format("当前分会场：分会场{0}", partNO);
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
                if (CustomHelper.CustomSign(CSTNO, partno))
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
            CSTNO = tbCustNO.Text;
            if (rbMobile.Checked)
            {
                CSTNO = CustomHelper.GetCustomNo(tbCustNO.Text);
            }
            if (!string.IsNullOrEmpty(CSTNO))
            {
                DataRow row= CustomHelper.GetCustomRow(CSTNO);
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

        private void rbNO_CheckedChanged(object sender, EventArgs e)
        {
            tbCustNO.Text = string.Empty;
            if (rbNO.Checked)
            {
                tbCustNO.MaxLength = 5;
            }
            else
            {
                tbCustNO.MaxLength = 11;
            }
            tbCustNO_TextChanged(sender, e);
        }

        private void PartSign_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = global::SignApp.Properties.Resources._2;
        }
    }
}

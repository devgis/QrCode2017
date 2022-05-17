using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using SignWeb.Common;

namespace SignExport
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btExport_Click(object sender, EventArgs e)
        {
            DataTable dt = CustomHelper.GetAllCustom();
            if (dt == null || dt.Rows.Count <= 0)
            {
                MessageBox.Show("查询数据失败！");
            }
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV文件|*.csv";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("客户编号,客户名称,职位,公司,公司地址,邀请人,手机号,邮箱,签到时间,打印次数");
                    foreach (DataRow dr in dt.Rows)
                    {
                        string cstno = string.Empty;
                        string cstname = string.Empty;
                        string company = string.Empty;
                        string position = string.Empty;
                        string mobile = string.Empty;
                        string email = string.Empty;
                        string signtime = string.Empty;
                        string printcout = string.Empty;
                        string companyadd = string.Empty;
                        string inviter = string.Empty;
                        try
                        {
                            cstno = dr["CUSTNO"].ToString();
                        }
                        catch
                        { }

                        try
                        {
                            companyadd = dr["COMPANYADD"].ToString();
                        }
                        catch
                        { }

                        try
                        {
                            inviter = dr["INVITER"].ToString();
                        }
                        catch
                        { }


                        try
                        {
                            cstname = dr["CUSTNAME"].ToString();
                        }
                        catch
                        { }

                        try
                        {
                            company = dr["COMPANY"].ToString();
                        }
                        catch
                        { }

                        try
                        {
                            position = dr["POSITION"].ToString();
                        }
                        catch
                        { }

                        try
                        {
                            mobile = dr["MOBILE"].ToString();
                        }
                        catch
                        { }
                        try
                        {
                            email = dr["EMAIL"].ToString();
                        }
                        catch
                        { }

                        try
                        {
                            signtime = dr["SIGNTIME"].ToString();
                        }
                        catch
                        { }

                        try
                        {
                            printcout = dr["PRINTCOUNT"].ToString();
                        }
                        catch
                        { }


                        sb.AppendLine(string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", ((char)(9)).ToString() + cstno, cstname, position, company, companyadd,inviter, mobile, email, signtime, printcout));

                    }
                    try
                    {
                        File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.Default);
                        MessageBox.Show("导出成功！");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("导出失败:" + ex.Message);

                    }

                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ExportApp
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
            DataTable dt = PrintApp.Common.CustomHelper.GetAllCustom();
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
                    sb.AppendLine("客户编号,嘉宾类型,客户名称,职位,公司,手机号,签到时间,打印次数");
                    foreach (DataRow dr in dt.Rows)
                    {
                        string cstno = string.Empty;
                        string csttype = string.Empty;
                        string cstname = string.Empty;
                        string company=string.Empty;
                        string position=string.Empty;
                        string mobile = string.Empty;
                        string signtime = string.Empty;
                        string printcout = string.Empty;
                        try
                        {
                            cstno = dr["CUSTNO"].ToString();
                        }
                        catch
                        { }
                        try
                        {
                            csttype = dr["CUSTTYPE"].ToString();
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


                        sb.AppendLine(string.Format("{0},{1},{2},{3},{4},{5},{6},{7}", ((char)(9)).ToString() + cstno,csttype, cstname, position, company, mobile, signtime, printcout));

                    }
                    try
                    {
                        File.WriteAllText(sfd.FileName, sb.ToString(),Encoding.Default);
                        MessageBox.Show("导出成功！");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("导出失败:" + ex.Message);
 
                    }

                }
            }
        }
    }
}

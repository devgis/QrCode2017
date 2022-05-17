using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using BarcodeLib;
using PrintApp.Common;

namespace TempSign
{
    public partial class MainForm : Form
    {
        PrintDocument objDocument = null;
        public MainForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            //foreach (Control c in this.Controls)
            //{
            //    c.DoubleBuffered = true;
            //}
        }

        private void btSign_Click(object sender, EventArgs e)
        {
            lbShowInfo.ForeColor = Color.White;
            lbShowInfo.Text = string.Empty;
            //if (string.IsNullOrEmpty(tbCustNO.Text.Trim()))
            //{
            //    lbShowInfo.Text="请输入客户编号！";
            //    lbShowInfo.ForeColor = Color.Red;
            //    tbCustNO.Focus();
            //    return;
            //}

            if (string.IsNullOrEmpty(cbCustType.Text.Trim()))
            {
                lbShowInfo.Text = "请选择嘉宾类型！";
                lbShowInfo.ForeColor = Color.Red;
                tbCustName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(tbCustName.Text.Trim()))
            {
                lbShowInfo.Text = "请输入客户名称！";
                lbShowInfo.ForeColor = Color.Red;
                tbCustName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(tbMobile.Text.Trim()))
            {
                lbShowInfo.Text = "请输入客户手机！";
                lbShowInfo.ForeColor = Color.Red;
                tbMobile.Focus();
                return;
            }

            //if (!string.IsNullOrEmpty(CustomHelper.GetCustomNo(tbCustNO.Text)))
            //{
            //    lbShowInfo.Text = "客户编号已存在！";
            //    lbShowInfo.ForeColor = Color.Red;
            //    tbCustNO.Focus();
            //    return;
            //}

            if (!string.IsNullOrEmpty(CustomHelper.GetCustomNo(tbMobile.Text)))
            {
                lbShowInfo.Text = "客户手机号已存在！";
                lbShowInfo.ForeColor = Color.Red;
                tbMobile.Focus();
                return;
            }

            ///保存信息 如果成功则打印
            try
            {
                string cstNO=CustomHelper.CustomTempSign(cbCustType.Text,tbCustName.Text, tbPosition.Text, tbCompany.Text, tbMobile.Text);
                if (!string.IsNullOrEmpty(cstNO))
                {
                    Print(cstNO);
                    cbCustType.SelectedIndex = 0;
                    tbCompany.Text = string.Empty;
                    tbCustName.Text = string.Empty;
                    tbMobile.Text = string.Empty;
                    tbPosition.Text = string.Empty;
                    lbShowInfo.Text = "签到成功！";
                }
                else
                {
                    lbShowInfo.ForeColor = Color.Red;
                    lbShowInfo.Text = "签到失败！";
                }
            }
            catch(Exception ex)
            {
                lbShowInfo.ForeColor = Color.Red;
                lbShowInfo.Text = "签到异常:" + ex.Message;
            }
        }

        public void Print(string Code)
        {
            objDocument = new PrintDocument();
            PrintController PrintStandard = new StandardPrintController();
            objDocument.PrintController = PrintStandard;  //隐藏打印框
            PaperSize RequiredPaperSize = new PaperSize("Custom", 230, 120);//宽度80mm
            objDocument.DefaultPageSettings.PaperSize = RequiredPaperSize;
            //objDocument.PrintPage += new PrintPageEventHandler(void);
            objDocument.PrintPage += (s, e) =>
            {
                int left = 0;
                int right = 999;
                try
                {
                    int Y = 0;
                    //e.Graphics.DrawLine(Pens.Black, left, 0,right,0);
                    string pageinfo = Code;
                    //e.Graphics.DrawString(pageinfo, new Font(new FontFamily("黑体"), 6), System.Drawing.Brushes.Black,5, 5);
                    Image image = GenerateBarCodeBitmap(pageinfo);
                    e.Graphics.DrawImage(image, 3, 10, 180, 70);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("打印异常：" + ex.Message);
                }
            };
            //PrintDialog pd = new PrintDialog();
            //pd.Document = objDocument;

            objDocument.Print(); //打印
        }

        /// <summary>
        /// 生成条形码
        /// </summary>
        /// <param name="content">内容</param>
        /// <returns></returns>
        public static Image GenerateBarCodeBitmap(string content)
        {
            using (var barcode = new Barcode()
            {
                IncludeLabel = true,
                Alignment = AlignmentPositions.CENTER,
                Width = 265,
                Height = 90,
                RotateFlipType = RotateFlipType.RotateNoneFlipNone,
                BackColor = Color.White,
                ForeColor = Color.Black,
            })
            {
                return barcode.Encode(TYPE.CODE128B, content);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbCustType.SelectedIndex = 0;
        }
    }
}

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

namespace GetSouvenirs
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

            if (string.IsNullOrEmpty(tbCustNO.Text.Trim()))
            {
                lbShowInfo.Text = "请输入客户编号！";
                lbShowInfo.ForeColor = Color.Red;
                tbCustNO.Focus();
                return;
            }

            ///保存信息 如果成功则打印
            try
            {
                string CustName = string.Empty;
                if (CustomHelper.GetSouvenirs(tbCustNO.Text, out CustName))
                {
                    tbCustNO.Text = string.Empty;
                    lbShowInfo.Text =CustName+ ",领取成功！";
                }
                else
                {
                    lbShowInfo.ForeColor = Color.Red;
                    lbShowInfo.Text = "领取失败，请稍后重试！";
                }
            }
            catch(Exception ex)
            {
                lbShowInfo.ForeColor = Color.Red;
                lbShowInfo.Text = "领取异常:" + ex.Message;
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

        private void tbCustNO_TextChanged(object sender, EventArgs e)
        {
            if (tbCustNO.Text.Length == 5)
            {
                btSign.PerformClick();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tbCustNO.Focus();
        }
    }
}

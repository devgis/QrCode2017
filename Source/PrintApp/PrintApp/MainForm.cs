using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;
using BarcodeLib;
using PrintApp.Common;

namespace PrintApp
{
    public partial class MainForm : Form
    {
        public static Bitmap backimage=PrintApp.Properties.Resources._2;
        PrintDocument objDocument = null;
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string sql = "select * from t_custominfo";
            //DataTable dt = SQLServerHelper.GetDataTable(sql);
            //MessageBox.Show(dt.Rows.Count.ToString());
            //return;

            //objDocument = new PrintDocument();
            //PaperSize RequiredPaperSize = new PaperSize("Custom", 230, 120);//宽度80mm
            //objDocument.DefaultPageSettings.PaperSize = RequiredPaperSize;
            //objDocument.PrintPage += new PrintPageEventHandler(MyPrintDocument_PrintPage);

            //PrintDialog pd = new PrintDialog();
            //pd.Document = objDocument;

            //objDocument.Print(); //打印

            ////if (pd.ShowDialog() == DialogResult.OK) //如果确认，将会覆盖所有的打印参数设置
            ////{
            ////    //objDocument.Print(); //打印
            ////    ////页面设置对话框（可以不使用，其实PrintDialog对话框已提供页面设置）
            ////    //PageSetupDialog psd = new PageSetupDialog();
            ////    //psd.Document = objDocument;
            ////    //if (DialogResult.OK == psd.ShowDialog())
            ////    //{

            ////    //打印预览
            ////    //PrintPreviewDialog ppd = new PrintPreviewDialog();
            ////    //ppd.Document = objDocument;
            ////    //if (DialogResult.OK == ppd.ShowDialog())
            ////    //{
            ////    //    objDocument.Print(); //打印
            ////    //}

            ////    objDocument.Print(); //打印

            ////    //}
            ////}
        }

        public void Print(string Code)
        {
            objDocument = new PrintDocument();
            PrintController PrintStandard = new StandardPrintController();   
            objDocument.PrintController=PrintStandard;  //隐藏打印框
            PaperSize RequiredPaperSize = new PaperSize("Custom", 230, 120);//宽度80mm
            objDocument.DefaultPageSettings.PaperSize = RequiredPaperSize;
            //objDocument.PrintPage += new PrintPageEventHandler(void);
            objDocument.PrintPage += (s, e) => {
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

                    WriteLog("打印异常：" + ex.Message);
                }
            };
            //PrintDialog pd = new PrintDialog();
            //pd.Document = objDocument;

            objDocument.Print(); //打印
        }

        //private void MyPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        //{
        //    int left = 0;
        //    int right = 999;
        //    try
        //    {
        //        Font _Font = new Font(new FontFamily("黑体"), 6);
        //        int Y = 0;
        //        //e.Graphics.DrawLine(Pens.Black, left, 0,right,0);
        //        string pageinfo = tbText.Text;
        //        //e.Graphics.DrawString(pageinfo, new Font(new FontFamily("黑体"), 6), System.Drawing.Brushes.Black,5, 5);
        //        Image image = GenerateBarCodeBitmap(pageinfo);
        //        e.Graphics.DrawImage(image,3, 10,180, 70);
        //    }
        //    catch (Exception ex)
        //    {

        //        WriteLog("打印异常：" + ex.Message);
        //    }
        //}

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

        private void WriteLog(string s)
        {
            MessageBox.Show(s);
        }

        private void tbText_TextChanged(object sender, EventArgs e)
        {
            //string sql = string.Format("select * from t_custominfo where CUSTNO='{0}' or MOBILE='{0}'",tbText.Text);
            //DataTable dt = SQLServerHelper.GetDataTable(sql);
            //if (dt != null && dt.Rows.Count > 0)
            //{
            //    MessageBox.Show(dt.Rows[0]["CUSTNO"].ToString());
            //}
            //else
            //{
 
            //}
            
        }

        private void btSign_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (CustomHelper.CustomSign(tbText.Text))
            //    {
            //        MessageBox.Show("成功！");
            //    }
            //    else
            //    {
            //        MessageBox.Show("失败！");
            //    }
            //}
            //catch(Exception ex)
            //{
            //     MessageBox.Show("失败:"+ex.Message);
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //if (CustomHelper.CanPrint(tbText.Text))
                //{
                //    MessageBox.Show("开始打印！");
                //}
                //else
                //{
                //    MessageBox.Show("打印失败！");
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("失败:" + ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //MobileSign mobileSign = new MobileSign();
            //mobileSign.Dock = DockStyle.Fill;
            //this.Controls.Clear();
            //this.Controls.Add(mobileSign);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FirstPage firstPage = new FirstPage();
            firstPage.MainFormWindow = this;
            firstPage.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(firstPage);

        }

    }
}

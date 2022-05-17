using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThoughtWorks.QRCode.Codec;
using System.Drawing;
using System.IO;
using System.Text;
using SignWeb.Common.Entities;
using SignWeb.Common;

namespace SignWeb
{
    /// <summary>
    /// register 的摘要说明
    /// </summary>
    public class register : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string custno = context.Request.QueryString["custno"];
            if (!string.IsNullOrEmpty(custno))
            {
                HttpResponse Response = context.Response;
                Bitmap bmp = getQrImage(custno);
                System.IO.MemoryStream MemStream = new System.IO.MemoryStream();
                bmp.Save(MemStream, System.Drawing.Imaging.ImageFormat.Png);
                bmp.Dispose();

                Response.Clear();
                Response.ContentType = "image/PNG";
                MemStream.WriteTo(Response.OutputStream);
                MemStream.Close(); 
            }
            else
            {
                context.Response.ContentType = "text/plain";
                try
                {
                    CustomInfo custom = new CustomInfo();
                    custom.Name = context.Request.Form["name"];
                    custom.Mobile = context.Request.Form["mobile"];
                    try
                    {
                        string cno = string.Empty;
                        if (CustomHelper.ExistMobile(custom.Mobile, out cno))
                        {
                            string info = HttpUtility.UrlEncode(LanChange("当前手机号已签到，请长按直接保存上方二维码"), Encoding.UTF8);
                            context.Response.Redirect(string.Format("page.html?custno={0}&info={1}", cno, info), false);
                        }
                        else
                        {
                            custom.Position = context.Request.Form["position"];
                            custom.Company = context.Request.Form["company"];
                            custom.Email = context.Request.Form["email"];
                            custom.CompanyAddress = context.Request.Form["companyadd"];
                            custom.Inviter = context.Request.Form["inviter"];
                            string cstcode = CustomHelper.AddCustom2(custom);
                            if (!string.IsNullOrEmpty(cstcode))
                            {
                                string info = HttpUtility.UrlEncode(LanChange("注册成功，请长按直接保存上方二维码"), Encoding.UTF8);
                                context.Response.Redirect(string.Format("page.html?custno={0}&info={1}", cstcode, info),false);
                            }
                            else
                            {
                                context.Response.Redirect(string.Format("page.html?info={0}", HttpUtility.UrlEncode(LanChange("注册失败，请稍后再试！"))), false);
                            }
                        }
                    }
                    catch(Exception ex)
                    { }
                    
                    
                }
                catch(Exception ex)
                {
                    context.Response.Redirect(string.Format("page.html?info={0}", HttpUtility.UrlEncode(LanChange("注册时发生错误：" + ex.Message))), false);
                }
            }
        }

        private string LanChange(string str)
        {
            Encoding utf8;
            Encoding gb2312;
            utf8 = Encoding.GetEncoding("UTF-8");
            gb2312 = Encoding.GetEncoding("GB2312");
            byte[] gb = gb2312.GetBytes(str);
            gb = Encoding.Convert(gb2312, utf8, gb);
            return utf8.GetString(gb);
        }  

        public Bitmap getQrImage(string CustNO)
        {
            QRCodeEncoder QRencode = null; //二维码生成 
            //生成二维码，并保存到 object QRImage 当中
            Bitmap QRImage = null;
            GenerateQRCodeBitmap(out QRImage, QRencode, CustNO, Encoding.UTF8);

            int logosize =50;

            Bitmap QRImg = QRImage as Bitmap; //取出数据，并保存到QRImage 当中

            Bitmap ResizeQRImg;
            //当生成的二维码大于图片窗口时， 重新修改二维码的尺寸以适应窗口大小
            //if (QRImg.Width > 500)
            //{
            //    ResizeQRImg = new Bitmap(QRImg, 500, 500);
            //}
            //else
            //{
            //    //当二维码的尺寸小于窗口，以居中显示
            //    ResizeQRImg = new Bitmap(QRImg);
            //}

            ResizeQRImg = new Bitmap(QRImg.Width + 10, QRImg.Height + 10);
            
            //给二维码加上5个像素的宽度
            Graphics g = Graphics.FromImage(ResizeQRImg);//创建一个画布           
            g.DrawImage(QRImg, new Point(5,5));//将logo图片绘制到二维码图片上  
            
            //ResizeQRImg = new Bitmap(QRImg, QRImg.Width + 6, QRImg.Height + 6);
            logoImage = CustomHelper.getLogoImage();
            if (logoImage == null)
            {
                
            }
            else
            {
                //绘制LOGO
                Bitmap bLogo = logoImage as Bitmap; //获取logo图片对象 
                //bLogo = new Bitmap(bLogo, 30, 30); //改变图片的大小这里我们设置为30   
                bLogo = new Bitmap(bLogo, logosize, logosize);
                int Y = ResizeQRImg.Height;
                int X = ResizeQRImg.Width;
                //坐标点是 （x/2 - logosize/2,y/2 - logosize/2)
                //Point point = new Point(X / 2 - 15, Y / 2 - 15);//logo图片绘制到二维码上，这里将简单计算一下logo所在的坐标 
                Point point = new Point(X / 2 - logosize / 2, Y / 2 - logosize / 2);
                g = Graphics.FromImage(ResizeQRImg);//创建一个画布           
                g.DrawImage(bLogo, point);//将logo图片绘制到二维码图片上    
            }
            return ResizeQRImg;
        }

        private void GenerateQRCodeBitmap(out Bitmap img, QRCodeEncoder qrEncode, string encodeStr, Encoding encode)
        {

            try
            {
                //判断是否已经输入了要生成二维码的内容 
                if (string.IsNullOrEmpty(encodeStr) == true)
                {
                    throw new Exception("请输入要生成二维码的内容");
                }

                qrEncode = new QRCodeEncoder();
                qrEncode.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE; //选择压缩的方式
                qrEncode.QRCodeScale = 4;
                qrEncode.QRCodeVersion =10;   //选择QR版本
                qrEncode.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;  //选择修正率
                img = qrEncode.Encode(encodeStr, encode); //生成二维码，并保存到img 类当中
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Bitmap logoImage = null;
        
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
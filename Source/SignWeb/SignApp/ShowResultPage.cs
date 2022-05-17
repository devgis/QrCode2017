using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace SignApp
{
    public partial class ShowResultPage : MyWindow
    {
        int itype = -1;
        string[] arrayString = null;
        //public ShowResultPage(string[] arr)
        //{
        //    InitializeComponent();
        //    arrayString = arr;
        //}

        /// <summary>
        /// 0 签到失败 1 签到成功 2 打印成功 3 打印失败
        /// </summary>
        /// <param name="iType"></param>
        public ShowResultPage(int iType)
        {
            InitializeComponent();
            itype = iType;
        }

        private void LoadImage(int iType)
        {
            switch (iType)
            {
                case 0:
                    this.BackgroundImage = SignApp.Properties.Resources._5;
                    break;
                case 1:
                    this.BackgroundImage = SignApp.Properties.Resources._3;
                    break;
            }
        }

        private void btFIrst_Click(object sender, EventArgs e)
        {
            PartSign firstPage = new PartSign();
            firstPage.Dock = DockStyle.Fill;
            firstPage.MainFormWindow = this.MainFormWindow;
            this.MainFormWindow.Controls.Clear();
            this.MainFormWindow.Controls.Add(firstPage);
        }

        private void ShowResultPage_Load(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(o =>
            {
                int time=30000;
                while (time >= 0)
                {
                    lbInfo.Invoke((EventHandler)(delegate
                    {
                        lbInfo.Text = string.Format("{0}秒后自动返回首页",time/1000);
                    }));
                    time -= 1000;
                    Thread.Sleep(1000);
                }
                //Thread.Sleep(30000);
                btFIrst.Invoke((EventHandler)(delegate
                {
                    btFIrst.PerformClick();
                }));
                
            });
            LoadImage(itype);
            //if (arrayString != null)
            //{
            //    try
            //    {
            //        label1.Text = arrayString[0];
            //    }
            //    catch
            //    {
            //        label1.Text = string.Empty;
            //    }
            //    try
            //    {
            //        label2.Text = arrayString[1];
            //    }
            //    catch
            //    {
            //        label2.Text = string.Empty;
            //    }
            //    try
            //    {
            //        label3.Text = arrayString[2];
            //    }
            //    catch
            //    {
            //        label3.Text = string.Empty;
            //    }
            //}
        }
    }
}

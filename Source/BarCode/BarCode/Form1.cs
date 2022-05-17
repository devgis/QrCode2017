using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarcodeLib;

namespace BarCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btGeneral_Click(object sender, EventArgs e)
        {
            Image image = GenerateBarCodeBitmap(textBox1.Text);
            pictureBox1.Image = image;
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
                Width = 250,
                Height = 100,
                RotateFlipType = RotateFlipType.RotateNoneFlipNone,
                BackColor = Color.White,
                ForeColor = Color.Black,
            })
            {
                return barcode.Encode(TYPE.CODE128B, content);
            }
        }
    }
}

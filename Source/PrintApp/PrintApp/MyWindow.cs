using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PrintApp
{
    public class MyWindow : UserControl
    {
        public MainForm MainFormWindow = null;

        protected override void OnLoad(EventArgs e)
        {
            this.GetType().GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this,
                true, null);
            base.OnLoad(e);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MyWindow
            // 
            this.DoubleBuffered = true;
            this.Name = "MyWindow";
            this.ResumeLayout(false);

        }
    }
}

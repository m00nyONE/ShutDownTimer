using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ShutdownTimer
{
    public partial class Brightness : Form
    {
        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, uint dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowLong(IntPtr hWnd, int nIndex);

        public Brightness()
        {

            InitializeComponent();
            
            TopMost = true;                        
            Visible = true;

            uint initialStyle = GetWindowLong(this.Handle, -20);
            SetWindowLong(this.Handle, -20, initialStyle | 0x80000 | 0x20);

        }

        private void Brightness_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }
    }
}



using System;
using System.Drawing;
using System.Windows.Forms;
using System.Management;
using System.Threading;

namespace ShutdownTimer
{
    public partial class MainWindow : Form
    {
        
     
        Brightness BrightnessWindow = new Brightness();
      
        
        public MainWindow()
        {
            InitializeComponent();
            ModusText = "Herunterfahren ";
            inum.Text = "in";
            
            trackBarBrightness.Visible = false;
            BrightnessWindow.Hide();
            BrightnessWindow.Opacity = 0.00;
        }

        string flags = "1", time, oldtime, ModusText = "Herunterfahren ", Modus = "in: ";
        int ModusInt = 0, SetTime = 0, CurrentTime = 0;
        string h= "h ", min = "min ", s= "s ";
        string stundenS = "", minutenS = "", sekundenS = "";


        private void trackBarBrightness_Scroll(object sender, EventArgs e)
        {
            BrightnessWindow.Opacity = trackBarBrightness.Value * 0.01;
            int BrightnessTotal = 100 - trackBarBrightness.Value;


            if (trackBarBrightness.Value == 0)
            {
                BrightnessTotalLabel.Hide();
                BrightnessWindow.Hide();
            }
            else
            {
                BrightnessWindow.Show();
                BrightnessTotalLabel.Show();
                BrightnessTotalLabel.Text = "Helligkeit: " + BrightnessTotal + "%";
            }
        }

        int stunden, minuten, sekunden;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                for (int i = 132;i <= 187; i+=3)
                {
                    this.Size = new Size(388, i);
                    Thread.Sleep(1);
                    trackBarBrightness.Visible = true;
               }
            }

            if (checkBox1.Checked == false)
            {
                for (int i = 187; i >= 132; i-=3)
                {
                    this.Size = new Size(388, i);
                    Thread.Sleep(1);
                    trackBarBrightness.Visible = false;
                }
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (ModusInt == 0)
            {
                time = (Convert.ToString((Convert.ToInt32(hour.Text)) * 60 * 60 + (Convert.ToInt32(minute.Text)) * 60));
                timer1.Start();
            }
            else
            {
                DateTime TimeNow = DateTime.Now;
                SetTime     = ((Convert.ToInt32(hour.Text)) * 3600 + (Convert.ToInt32(minute.Text)) * 60);
                CurrentTime = Convert.ToInt32(TimeNow.Hour) * 3600 + Convert.ToInt32(TimeNow.Minute) * 60 + Convert.ToInt32(TimeNow.Second);
                if (SetTime > CurrentTime)
                    time = Convert.ToString(SetTime - CurrentTime);
                else
                    time = Convert.ToString(86400 + SetTime - CurrentTime);

                timer1.Start();
            }
        }

        private void Abbrechen_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Text = "Timer gestoppt";
        }

        private void inum_SelectedIndexChanged(object sender, EventArgs e)    
        {
            switch (inum.SelectedIndex)
            {
                case 0: {  ModusInt = 0; } break;
                case 1: {  ModusInt = 1; } break;
                default: { Modus = "in: "; ModusInt = 0; } break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            oldtime = time;
            time = (Convert.ToInt32(time) - 1).ToString();
            
            int calctime = Convert.ToInt32(time);
            stunden = calctime / 3600;
            calctime -= stunden * 3600;
            minuten = calctime / 60;
            calctime -= minuten * 60;
            sekunden = calctime;

            stundenS = Convert.ToString(stunden);
            minutenS = Convert.ToString(minuten);
            sekundenS = Convert.ToString(sekunden);

            if (stunden == 0)
            {
                h = "";
                stundenS = "";
            }
            else h = "h ";
            if (minuten == 0)
            {
                min = "";
                minutenS = "";
            }
            else min = "min ";

            this.Text = ModusText + Modus + stundenS + h + minutenS + min + sekundenS + s;

            if (time == "0")
            {
                timer1.Stop();
                Shutdown();
            }     
        }

        private void mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (mode.SelectedIndex)
            {
                case 0: { flags = "1"; ModusText = "Herunterfahren "; } break;
                case 1: { flags = "2"; ModusText = "Neustart "; } break;
                case 2: { flags = "0"; ModusText = "Sperren "; } break;
                default: { flags = "1"; ModusText = "Herunterfahren "; } break;
            }
        }

        public void Shutdown()
        {
            ManagementBaseObject shutdown = null;
            ManagementClass win32 = new ManagementClass("Win32_OperatingSystem");
            win32.Get();
            win32.Scope.Options.EnablePrivileges = true;
            ManagementBaseObject shutdownparam = win32.GetMethodParameters("Win32Shutdown");
            shutdownparam["Flags"] = flags;
            shutdownparam["Reserved"] = "0";
            foreach (ManagementObject mObj in win32.GetInstances())
            {
                shutdown = mObj.InvokeMethod("Win32Shutdown", shutdownparam, null);
            }
        }
    }


}
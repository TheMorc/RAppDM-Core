using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
namespace RAppDM
{
    public partial class SplshScrn : Form
    {
        AppManager am = new AppManager();
        Stopwatch swatch = new Stopwatch();
        public SplshScrn()
        {
            InitializeComponent();
        }

        private void SplshScrn_Load(object sender, EventArgs e)
        {
            swatch.Start();
            verTXT.Text = RAppDM_internal.GetShortVersion();
            if (!Directory.Exists("cache"))
            {
                Directory.CreateDirectory("cache");
            }
            if (!Directory.Exists("cache\\repos"))
            {
                Directory.CreateDirectory("cache\\repos");
            }
            if (!Directory.Exists("cache\\downloads"))
            {
                Directory.CreateDirectory("cache\\downloads");
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            if (Properties.Settings.Default.DownloadWhenStarting)
            {
                statusTXT.Text = "Downloading repos!";
                timer3.Start();
            }
            else
            {
                statusTXT.Text = "Skipping downloading repos!";
                timer4.Start();
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            am.WindowState = FormWindowState.Normal;
            swatch.Stop();
            Properties.Settings.Default.bootTime = swatch.ElapsedMilliseconds;
            Close();
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            RAppDMFunctions.FetchRepos(statusPBAR, statusTXT, false);
            timer4.Start();

        }

        private void Timer4_Tick(object sender, EventArgs e)
        {
            timer4.Stop();
            statusPBAR.Style = ProgressBarStyle.Blocks;
            statusPBAR.Value = 32;
            statusTXT.Text = "Preparing app manager!";
            timer5.Start();
        }

        private void Timer5_Tick(object sender, EventArgs e)
        {
            timer5.Stop();

            RAppDMFunctions.SyncItems();
            am.WindowState = FormWindowState.Minimized;
            am.Show();
            timer6.Start();
        }

        private void Timer6_Tick(object sender, EventArgs e)
        {
            timer6.Stop();
            statusTXT.Text = "RAppDM is READY!";
            timer2.Start();
        }
    }
}

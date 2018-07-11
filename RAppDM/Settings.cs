using System;
using System.Windows.Forms;

namespace RAppDM
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            RAppDMFunctions.FetchRepos(precentagebar, downloadpercentage);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            repoList.Items.Add(repoURL.Text);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Repos.Clear();
            for (int i = 0; i < repoList.Items.Count; i++)
            {
                repoList.SelectedIndex = i;
                Properties.Settings.Default.Repos.Add(repoList.SelectedItem.ToString());
            }
            Properties.Settings.Default.Save();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            object name = repoList.SelectedItem;
            repoList.Items.Remove(name);
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            foreach (string strng in Properties.Settings.Default.Repos)
            {
                repoList.Items.Add(strng);
            }
            enableDebugMode.Checked = Properties.Settings.Default.DebugMode;
            askCloseRC.Checked = Properties.Settings.Default.AskRepCreat;
            downloadStartRepos.Checked = Properties.Settings.Default.DownloadWhenStarting;
            bTime.Text = $"Boot Time: {Properties.Settings.Default.bootTime}ms";
            versionLBL.Text = $"RAppDM Build:{RAppDM_internal.version}";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            RepoCreator RCrep = new RepoCreator();
            RCrep.Show();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DebugMode = enableDebugMode.Checked;
            Properties.Settings.Default.Save();

        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AskRepCreat = askCloseRC.Checked;
            Properties.Settings.Default.Save();
        }


        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DownloadWhenStarting = downloadStartRepos.Checked;
            Properties.Settings.Default.Save();
        }
    }
}

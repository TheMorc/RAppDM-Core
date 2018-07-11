using System;
using System.Windows.Forms;

namespace RAppDM
{
    public partial class AppManager : Form
    {
        public AppManager()
        {
            InitializeComponent();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        public void SColl_Listbox(System.Collections.Specialized.StringCollection In, ListBox to)
        {
            foreach (object oof in In)
            {
                to.Items.Add(oof);
            }
        }

        private void AppManager_Load(object sender, EventArgs e)
        {
            Text = $"Apps [RAppDM {RAppDM_internal.GetShortVersion()}]";
            if (Properties.Settings.Default.DebugMode)
            {
                iconurls.Visible = true;
                downloadurls.Visible = true;
                silentargs.Visible = true;
                descs.Visible = true;
                tempApps.Visible = true;
                tempCategories.Visible = true;
                tempIndexes.Visible = true;
                versions.Visible = true;
                categories.Visible = true;
                apps.Visible = true;
                sizes.Visible = true;
            }
            apps.Items.Clear();
            SColl_Listbox(Properties.Settings.Default.Category, tempCategories);
            SColl_Listbox(Properties.Settings.Default.Description, descs);
            SColl_Listbox(Properties.Settings.Default.Icon, iconurls);
            SColl_Listbox(Properties.Settings.Default.Name, tempApps);
            SColl_Listbox(Properties.Settings.Default.URL, downloadurls);
            SColl_Listbox(Properties.Settings.Default.SilentModeArgument, silentargs);
            SColl_Listbox(Properties.Settings.Default.Version, versions);
            SColl_Listbox(Properties.Settings.Default.Size, sizes);

            //Startup app importing
            foreach (TreeNode category in categoriesAndApps.Nodes[0].Nodes)
            {
                category.Nodes.Clear();
                for (int i = 0; i < tempCategories.Items.Count; i++)
                {
                    if (category.Text == tempCategories.Items[i].ToString())
                    {
                        category.Nodes.Add(tempApps.Items[i].ToString());
                    }

                }
            }


        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (apps.SelectedIndex == -1)
            {
                //fuck the system
                //its dumb we know
            }
            else
            {
                foreach (int item in tempIndexes.Items)
                {
                    if (tempApps.Items[item].ToString() == apps.SelectedItem.ToString())
                    {
                        SelectIndex(item);
                    }
                }
                foreach (string img in Properties.Settings.Default.Icon)
                {
                    if (iconurls.SelectedItem.ToString() == img)
                    {
                        appIcon.LoadAsync(img);
                    }
                }
            }
        }

        private void SelectIndex(int item)
        {
            iconurls.SelectedIndex = item;
            downloadurls.SelectedIndex = item;
            descs.SelectedIndex = item;
            silentargs.SelectedIndex = item;
            versions.SelectedIndex = item;
            sizes.SelectedIndex = item;
        }

        private void AppManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            RAppDMFunctions.Download(downloadurls.SelectedItem.ToString(), silentargs.SelectedItem.ToString(), categoriesAndApps.SelectedNode.Text.ToString());
        }

        private void PictureBox1_LoadCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            nameLBL.Text = categoriesAndApps.SelectedNode.Text.ToString();
            descLBL.Text = descs.SelectedItem.ToString();
            versionLBL.Text = versions.SelectedItem.ToString() + sizes.SelectedItem.ToString();
            appIcon.UseWaitCursor = false;
            installBTN.Visible = true;
            installBTN.Enabled = true;
            uninstallBTN.Visible = false;
            uninstallBTN.Enabled = false;
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(e.Node.Parent);
            foreach (TreeNode category in categoriesAndApps.Nodes[0].Nodes)
            {
                if (e.Node.Text == "Installed")
                {
                    //bump
                    System.Diagnostics.Debug.WriteLine(e.Node.Text);
                }
                else if (e.Node.Parent == null)
                {
                    //uhh wait
                    //using `return;` to don˙t flood the RAppDM.  
                    System.Diagnostics.Debug.WriteLine($"Houston we have a problem, maybe! Name: {e.Node.Text}");
                    //Is this even a joke?
                    return;
                }
                else if (e.Node.Parent.Text == category.Text)
                {
                    //this looks like it will work.

                    System.Diagnostics.Debug.WriteLine($"App: \"{e.Node.Text}\" | Category: \"{e.Node.Parent.Text}\"");
                    tempIndexes.Items.Clear();
                    nameLBL.Text = "";
                    descLBL.Text = "";
                    versionLBL.Text = "";
                    installBTN.Enabled = false;
                    uninstallBTN.Visible = false;
                    uninstallBTN.Enabled = false;
                    appIcon.Image = null;
                    appIcon.UseWaitCursor = true;
                    for (int i = 0; i < tempCategories.Items.Count; i++)
                    {
                        if (category.Text == tempCategories.Items[i].ToString())
                        {
                            tempApps.SelectedIndex = i;
                            tempIndexes.Items.Add(i);
                        }

                    }
                    foreach (int item in tempIndexes.Items)
                    {
                        if (tempApps.Items[item].ToString() == e.Node.Text)
                        {
                            SelectIndex(item);
                        }
                    }
                    foreach (string img in Properties.Settings.Default.Icon)
                    {
                        if (iconurls.SelectedItem.ToString() == img)
                        {
                            appIcon.LoadAsync(img);
                        }
                    }
                }


            }
        }
    }
}

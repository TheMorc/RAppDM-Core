using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;

namespace RAppDM
{
    public partial class RepoCreator : Form
    {
        public RepoCreator()
        {
            InitializeComponent();
        }

        private void RepoCreator_Load(object sender, EventArgs e)
        {

        }
        //listbox index mover
        //opportunity to make code smaller
        // + if you are reading this, this is meant to be like some kind of easter egg, but in code :grin: 
        public void LBIMover(ListBox to)
        {
            iconLSTBX.SelectedIndex = to.SelectedIndex;
            catLSTBX.SelectedIndex = to.SelectedIndex;
            slntargLSTBX.SelectedIndex = to.SelectedIndex;
            descLSTBX.SelectedIndex = to.SelectedIndex;
            linkLSTBX.SelectedIndex = to.SelectedIndex;
            verLSTBX.SelectedIndex = to.SelectedIndex;
            nameLSTBX.SelectedIndex = to.SelectedIndex;
            sizeLSTBX.SelectedIndex = to.SelectedIndex;
        }

        //another opportunity to simplify it
        private void LBIRemove()
        {
            var temp1 = iconLSTBX.SelectedItem;
            var temp2 = nameLSTBX.SelectedItem;
            var temp3 = linkLSTBX.SelectedItem;
            var temp4 = slntargLSTBX.SelectedItem;
            var temp5 = catLSTBX.SelectedItem;
            var temp6 = descLSTBX.SelectedItem;
            var temp7 = verLSTBX.SelectedItem;
            var temp8 = sizeLSTBX.SelectedItem;
            iconLSTBX.Items.Remove(temp1);
            nameLSTBX.Items.Remove(temp2);
            linkLSTBX.Items.Remove(temp3);
            slntargLSTBX.Items.Remove(temp4);
            catLSTBX.Items.Remove(temp5);
            descLSTBX.Items.Remove(temp6);
            verLSTBX.Items.Remove(temp7);
            sizeLSTBX.Items.Remove(temp8);
        }


        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LBIMover(nameLSTBX);
        }

        private void ListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            LBIMover(iconLSTBX);
        }

        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LBIMover(linkLSTBX);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            LBIRemove();
            changes.Text = "You have unsaved changes in repo!";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            nameLSTBX.Items.Add(nameTXTBX.Text);
            linkLSTBX.Items.Add(linkTXTBX.Text);
            iconLSTBX.Items.Add(iconTXTBX.Text);
            catLSTBX.Items.Add(catTXTBX.Text);
            slntargLSTBX.Items.Add(silentTXTBX.Text);
            descLSTBX.Items.Add(descTXTBX.Text);
            verLSTBX.Items.Add(verTXTBX.Text);
            sizeLSTBX.Items.Add(sizeSize.Value + sizeUnit.SelectedItem.ToString());
            changes.Text = "You have unsaved changes in repo!";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            List<RepoItem> rit = new List<RepoItem>();
            for (int i = 0; i < nameLSTBX.Items.Count; i++)
            {
                nameLSTBX.SelectedIndex = i;
                linkLSTBX.SelectedIndex = i;
                iconLSTBX.SelectedIndex = i;
                catLSTBX.SelectedIndex = i;
                slntargLSTBX.SelectedIndex = i;
                descLSTBX.SelectedIndex = i;
                verLSTBX.SelectedIndex = i;
                sizeLSTBX.SelectedIndex = i;
                RepoItem ritem = new RepoItem
                {
                    Name = nameLSTBX.SelectedItem.ToString(),
                    URL = linkLSTBX.SelectedItem.ToString(),
                    IconURL = iconLSTBX.SelectedItem.ToString(),
                    Description = descLSTBX.SelectedItem.ToString(),
                    SilentArgument = slntargLSTBX.SelectedItem.ToString(),
                    Category = catLSTBX.SelectedItem.ToString(),
                    Version = verLSTBX.SelectedItem.ToString(),
                    Size = sizeLSTBX.SelectedItem.ToString()
                };
                rit.Add(ritem);
                changes.Text = "";

            }
            var jsonOut = JsonConvert.SerializeObject(rit, Formatting.Indented);
            using (var StrmWrt = new StreamWriter("repo.json", false))
            {
                StrmWrt.WriteLine(jsonOut);
                StrmWrt.Close();
                MessageBox.Show("Json exported!", "RAppDM Repo Creator", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ImprepoBTN_Click(object sender, EventArgs e)
        {
            if (repoImport.ShowDialog() == DialogResult.OK)
            {
                nameLSTBX.Items.Clear();
                linkLSTBX.Items.Clear();
                iconLSTBX.Items.Clear();
                descLSTBX.Items.Clear();
                slntargLSTBX.Items.Clear();
                catLSTBX.Items.Clear();
                verLSTBX.Items.Clear();
                sizeLSTBX.Items.Clear();
                using (StreamReader sred = new StreamReader(repoImport.OpenFile()))
                {
                    List<RepoItem> repoitems = JsonConvert.DeserializeObject<List<RepoItem>>(sred.ReadToEnd());
                    foreach (var item in repoitems)
                    {
                        nameLSTBX.Items.Add(item.Name);
                        linkLSTBX.Items.Add(item.URL);
                        iconLSTBX.Items.Add(item.IconURL);
                        descLSTBX.Items.Add(item.Description);
                        slntargLSTBX.Items.Add(item.SilentArgument);
                        catLSTBX.Items.Add(item.Category);
                        verLSTBX.Items.Add(item.Version);
                        sizeLSTBX.Items.Add(item.Size);
                    }
                }
            }

        }

        private void DescLSTBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            LBIMover(descLSTBX);
        }

        private void SlntargLSTBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            LBIMover(slntargLSTBX);
        }

        private void CatLSTBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            LBIMover(catLSTBX);
        }

        private void RepoCreator_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Properties.Settings.Default.AskRepCreat)
                if (MessageBox.Show("Do you want to exit?", "RAppDM Repo Creator", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    e.Cancel = true;

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                sizeSize.Value = Int16.Parse(sizeLSTBX.SelectedItem.ToString().Remove(sizeLSTBX.SelectedItem.ToString().Length - 2, 2));
            }
            catch (Exception)
            {
                sizeSize.Value = 0;
            }
            try
            {
                sizeUnit.Text = sizeLSTBX.SelectedItem.ToString().Remove(0, sizeLSTBX.SelectedItem.ToString().Length - 2);
            }
            catch (Exception)
            {
                sizeUnit.Text = "MB";
            }
            nameTXTBX.Text = nameLSTBX.SelectedItem.ToString();
            iconTXTBX.Text = iconLSTBX.SelectedItem.ToString();
            catTXTBX.Text = catLSTBX.SelectedItem.ToString();
            silentTXTBX.Text = slntargLSTBX.SelectedItem.ToString();
            descTXTBX.Text = descLSTBX.SelectedItem.ToString();
            linkTXTBX.Text = linkLSTBX.SelectedItem.ToString();
            verTXTBX.Text = verLSTBX.SelectedItem.ToString();
            LBIRemove();
            changes.Text = "You have unsaved changes in repo!";
        }

        private void VerLSTBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            LBIMover(verLSTBX);
        }

        private void sizeLSTBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            LBIMover(sizeLSTBX);
        }
    }
}

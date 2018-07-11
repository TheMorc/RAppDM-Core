using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System;

namespace RAppDM
{
    public class RAppDMFunctions
    {

        static WebClient webClient = new WebClient();
        public static void FetchRepos(ProgressBar pbar, Label status, Boolean ShortPercentageText = true)
        {
            //function which downloads repos..
            //made 15:11, 18 Dec 2017 
            //29 december, fuck webclient for downloading repos
            DirectoryInfo di = new DirectoryInfo("cache\\repos");
            string download = status.Text;
            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            for (int i = 0; i < Properties.Settings.Default.Repos.Count; i++)
            {

                webClient.DownloadProgressChanged += (s, e) =>
                {
                    pbar.Value = e.ProgressPercentage;
                    if (ShortPercentageText)
                    {
                        status.Text = $"{e.ProgressPercentage}%";
                    }
                    else
                    {
                        status.Text = $"{download} - {e.ProgressPercentage}%";
                    }
                };
                webClient.DownloadDataCompleted += (s, e) =>
                {
                    File.WriteAllBytes($"cache\\repos\\repo_{i}.json", e.Result);
                };

                webClient.DownloadDataAsync(new Uri(Properties.Settings.Default.Repos[i]));


                //HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create();
                //using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                //{
                //    var responseStream = response.GetResponseStream();

                //}
            }
        }


        public static void SyncItems()
        {
            //function which adds items from repos..
            //made 15:18, 18 Dec 2017 
            foreach (string repo in Directory.GetFiles("cache\\repos"))
            {
                using (var sr = new StreamReader(repo))
                {
                    List<RepoItem> repoitems = JsonConvert.DeserializeObject<List<RepoItem>>(sr.ReadToEnd());
                    Properties.Settings.Default.Category.Clear();
                    Properties.Settings.Default.Description.Clear();
                    Properties.Settings.Default.Icon.Clear();
                    Properties.Settings.Default.Name.Clear();
                    Properties.Settings.Default.SilentModeArgument.Clear();
                    Properties.Settings.Default.URL.Clear();
                    Properties.Settings.Default.Version.Clear();
                    Properties.Settings.Default.Size.Clear();
                    foreach (RepoItem item in repoitems)
                    {
                        if (item.Name == null)
                            Properties.Settings.Default.Name.Add("");
                        else
                            Properties.Settings.Default.Name.Add(item.Name);

                        if (item.URL == null)
                            Properties.Settings.Default.URL.Add("");
                        else
                            Properties.Settings.Default.URL.Add(item.URL);

                        if (item.IconURL == null)
                            Properties.Settings.Default.Icon.Add("");
                        else
                            Properties.Settings.Default.Icon.Add(item.IconURL);

                        if (item.Description == null)
                            Properties.Settings.Default.Description.Add("");
                        else
                            Properties.Settings.Default.Description.Add(item.Description);

                        if (item.SilentArgument == null)
                            Properties.Settings.Default.SilentModeArgument.Add("");
                        else
                            Properties.Settings.Default.SilentModeArgument.Add(item.SilentArgument);

                        if (item.Category == null)
                            Properties.Settings.Default.Category.Add("");
                        else
                            Properties.Settings.Default.Category.Add(item.Category);

                        if (item.Version == null)
                            Properties.Settings.Default.Version.Add("");
                        else
                            Properties.Settings.Default.Version.Add(item.Version);

                        if (item.Size == null)
                            Properties.Settings.Default.Size.Add("");
                        else
                            Properties.Settings.Default.Size.Add(item.Size);


                    }
                    Properties.Settings.Default.Save();
                    sr.Close();
                    sr.Dispose();
                }

            }
        }

        internal static void Download(string url = "", string argument = "", string appName = "")
        {
            Downloads dl = new Downloads
            {
                NAME = appName,
                ARG = argument,
                URL = url
            };
            dl.Show();
        }
    }
}

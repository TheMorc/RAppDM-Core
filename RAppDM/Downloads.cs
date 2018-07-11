using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace RAppDM
{
    public partial class Downloads : Form
    {
        public string URL { get; internal set; }
        public string NAME { get; internal set; }
        public string ARG { get; internal set; }

        WebClient webClient = new WebClient();
        public Downloads()
        {
            InitializeComponent();
        }

        private void Downloads_FormClosing(object sender, FormClosingEventArgs e)
        {
            webClient.CancelAsync();
        }

        private void Downloads_Load(object sender, EventArgs eArg)
        {

            //HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(URL);
            //using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            //{
            //    //
            //    var fn = response.Headers["Content-Disposition"].Split(new string[] { "=" }, StringSplitOptions.None)[1];
            //    Debug.WriteLine(response.ResponseUri.AbsoluteUri + fn);
            //    string basePath = @"cache\\downloads\\";
            //    var responseStream = response.GetResponseStream();
            //    using (var fileStream = File.Create(Path.Combine(basePath, "test.mxx")))
            //    {
            //        byte[] buffer = new byte[8 * 1024];
            //        int len;
            //        //long length = responseStream.Length;
            //        while ((len = responseStream.Read(buffer, 0, buffer.Length)) > 0)
            //        {
            //            fileStream.Write(buffer, 0, len);
            //        }
            //    }
            //}

            webClient.DownloadDataCompleted += (s, e) =>
            {
                string content_disposition = "";
                //File.WriteAllBytes($"cache\\repos\\repo_{i}.json", e.Result);
                try
                {
                    HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(URL);
                    using (HttpWebResponse res = (HttpWebResponse)req.GetResponse())
                    {
                        content_disposition = res.Headers.ToString();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                MessageBox.Show($"{System.IO.Path.GetFileName(URL)}\n{System.IO.Path.GetFileName(URL).EndsWith(".exe")}\n{content_disposition}");
            };

            webClient.DownloadProgressChanged += (s, e) =>
            {
                progressBar1.Value = e.ProgressPercentage;
                label1.Text = $"{e.ProgressPercentage}%";
                label2.Text = NAME;
            };

            webClient.DownloadDataAsync(new Uri(URL));


            webClient.DownloadFileCompleted += (s, e) =>
            {
                if (!e.Cancelled)
                {
                    Process process = new Process();
                    var startInfo = new ProcessStartInfo
                    {
                        FileName = $"cache\\downloads\\{System.IO.Path.GetFileName(URL)}",
                        Arguments = ARG,
                        UseShellExecute = false
                    };
                    process.StartInfo = startInfo;
                    process.EnableRaisingEvents = true;
                    process.Start();
                    process.Exited += delegate
                   {
                       MessageBox.Show($"{NAME} was downloaded and installed sucessfully");
                   };
                }
            };
            if (!System.IO.Path.GetFileName(URL).EndsWith(".exe"))
            {
                Debug.WriteLine("saatana");
            }
            else
            {

                //webClient.DownloadFileAsync(new Uri(URL), $"cache\\downloads\\{System.IO.Path.GetFileName(URL)}");
            }
        }
    }
}

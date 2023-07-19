using FFMpegCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;
using Xabe.FFmpeg.Downloader;

namespace YouTube_Video_Downloader
{
    public partial class Form1 : Form
    {
        private YouTube youtube = YouTube.Default;
        public HashSet<string> videoId = new HashSet<string>();
        private long totalbytes = 0;
        private long collctedbytes = 0;
        private string selectedVideoQuality = "";
        private string selectedAudioQuality = "";
        private static string re = @"list=([A-z0-9-]+(&|$))";
        private static Regex listreg = new Regex(re);
        private static string watchLink = "https://www.youtube.com/watch?v=";
        private int playlist;
        private string link;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            GrbVideoDetails.Visible = false;
            progressBar1.Visible = false;
        }



        private void txtUrl_TextChanged(object sender, EventArgs e)
        {
            if (!bgWorkerGetVideo.IsBusy)
                bgWorkerGetVideo.RunWorkerAsync();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            GrbVideoDetails.Visible = true;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                    Save_Path.Text = folderDialog.SelectedPath + "\\";
                else
                    Save_Path.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }
        }
        private void GetVideoData(string link, bool playlist = false)
        {
            var videoData = youtube.GetAllVideos(link);
            var resolution = videoData.Where(r => r.AdaptiveKind == AdaptiveKind.Video && r.Format == VideoFormat.Mp4).
                             Select(r => r.Resolution);
            var bitRate = videoData.Where(r => r.AdaptiveKind == AdaptiveKind.Audio).Select(r => r.AudioBitrate);
            foreach (var item in resolution)
            {
                if (!cmbQuality.Items.Contains(item))
                    cmbQuality.Invoke((MethodInvoker)(() => cmbQuality.Items.Add(item)));
            }
            foreach (var item in bitRate)
            {
                if (!cmbAudioQuality.Items.Contains(item))
                    cmbAudioQuality.Invoke((MethodInvoker)(() => cmbAudioQuality.Items.Add(item)));
            }

            if (cmbQuality.Items.Count > 0)
            {
                cmbQuality.Invoke((MethodInvoker)(() => cmbQuality.Sorted = true));
                cmbQuality.Invoke((MethodInvoker)(() => cmbQuality.SelectedIndex = 0));
                cmbAudioQuality.Invoke((MethodInvoker)(() => cmbAudioQuality.Sorted = true));
                cmbAudioQuality.Invoke((MethodInvoker)(() => cmbAudioQuality.SelectedIndex = 0));
                Txt_Title.Invoke((MethodInvoker)(() => Txt_Title.Text = videoData.ToList()[0].Title));
            }
            if (playlist)
                Status.Text = videoId.Count + "Videos";
            else
                Status.Text = "Single Video";
        }

        private void Save_Path_TextChanged(object sender, EventArgs e)
        {

        }
        private void EmptyUrl()
        {
            cmbQuality.Invoke((MethodInvoker)(() => cmbQuality.Items.Clear()));
            cmbAudioQuality.Invoke((MethodInvoker)(() => cmbAudioQuality.Items.Clear()));
            Txt_Title.Invoke((MethodInvoker)(() => Txt_Title.Text = ""));
            selectedVideoQuality = "";
            selectedAudioQuality = "";
        }

        private void bgWorkerGetVideo_DoWork(object sender, DoWorkEventArgs e)
        {
            videoId.Clear();
            Status.Text = "Processing link...";
            if (Txt_url.Text == "")
            {
                EmptyUrl();
                Status.Text = "Empty or Invalid Link";
            }
            else
            {
                try
                {
                    Match m = listreg.Match(Txt_url.Text);
                    if (m.Success)
                    {
                        string listId = m.Groups[1].Value;
                        using (var client = new WebClient())
                        {
                            var responseString = client.DownloadString(Txt_url.Text);
                            string re2 = "\"videoId\":\"([A-z0-9-]+)\",\"playlistId\":\"" + listId + "\"";
                            Regex listOfVideos = new Regex(re);
                            foreach (Match ma in listOfVideos.Matches(responseString))
                            {
                                videoId.Add(ma.Groups[1].Value);
                            }
                            if (videoId.Count > 0)
                                GetVideoData(watchLink + videoId.ElementAt(0), true);
                        }
                    }
                    else
                        GetVideoData(Txt_url.Text);
                }
                catch
                {
                    EmptyUrl();
                    Status.Text = "Invalid Link";
                }
            }
        }
        private string ByteConverter(long b)
        {
            string final;
            //to kb 
            float c = (float)b;
            c /= 1024;
            final = c.ToString("0.00") + " KB";
            if (c >= (float)1)
            {//to mb
                c /= 1024;
                final = c.ToString("0.00") + " MB";
            }
            else if (c >= (float)1)
            {
                //to gb
                c /= 1024;
                final = c.ToString("0.00") + " GB";
            }
            return final;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            if (backgroundWorker1.IsBusy != true)
                backgroundWorker1.RunWorkerAsync();
        }
        private void FileDelete(string pa)
        {
            if (File.Exists(pa))
                File.Delete(pa);
        }

        async void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            totalbytes = 0;
            collctedbytes = 0;
            string audiomp4 = "Audio.mp4";
            string Audiomp3 = "Audio.mp3";
            string VideoFile = "Video.mp4";
            Status.Text = "Checking tools";
            async Task SourceDownloader(string name, YouTubeVideo vid)
            {
                var client = new HttpClient();
                long? totalByte = 0;
                using (Stream output = File.OpenWrite(name))
                {
                    using (var request = new HttpRequestMessage(HttpMethod.Head, vid.Uri))
                    {
                        totalByte = client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).Result.Content.Headers.ContentLength;
                    }
                    totalbytes += (long)totalByte;
                    using (var input = await client.GetStreamAsync(vid.Uri))
                    {
                        byte[] buffer = new byte[16 * 1024];
                        int read;
                        int totalRead = 0;

                        while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            output.Write(buffer, 0, read);
                            totalRead += read;
                            collctedbytes += read;
                            long x = collctedbytes * 100 / totalbytes;
                            DataProgress.Text = ByteConverter(collctedbytes) + "/" + ByteConverter(totalbytes);
                            progressBar1.Invoke((MethodInvoker)(() => progressBar1.Value = (int)x));
                        }
                    }
                }
                client.Dispose();
            }
            await FFmpegDownloader.GetLatestVersion(FFmpegVersion.Full);

             async Task<Task> DownloadWork(string link, int playlist = -1) { return Task.CompletedTask; }
            {

                if (playlist < 0)
                    Status.Text = "Downloading...";
                else
                    Status.Text = (playlist + 1).ToString() + "/" + videoId.Count.ToString();
                var video = youtube.GetAllVideos(link);
                var Targetaudio = video.Where(r => r.AdaptiveKind == AdaptiveKind.Audio &&
                r.AudioBitrate.ToString() == selectedAudioQuality).Select(r => r);

                var TargetVideo = video.Where(r => r.AdaptiveKind == AdaptiveKind.Video &&
                r.Format == VideoFormat.Mp4 && r.Resolution.ToString() == selectedVideoQuality).Select(r => r);

                Txt_Title.Invoke((MethodInvoker)(() => Txt_Title.Text = video.ToList()[0].Title));
                Task au = SourceDownloader(audiomp4, Targetaudio.ToList()[0]);
                if (AudioOnly_Checkbx.Checked != true)
                {
                    Task vide = SourceDownloader(VideoFile, TargetVideo.ToList()[0]);
                    await au;
                    FFMpeg.ExtractAudio(audiomp4, Audiomp3);
                    File.Delete(audiomp4);
                    await vide;
                    FFMpeg.ReplaceAudio(VideoFile, Audiomp3, Save_Path.Text + TargetVideo.ToList()[0].FullName);
                    FileDelete(VideoFile);
                    FileDelete(Audiomp3);
                }
                else
                {
                    await au;
                    FFMpeg.ExtractAudio(audiomp4, Save_Path.Text + TargetVideo.ToList()[0].Title + "mp3");
                    FileDelete(audiomp4);
                }
                if (playlist < 0)
                    Status.Text = "Completed";
                else
                    Status.Text = "Done (" + (playlist + 1).ToString() + "/" + videoId.Count.ToString() + ")";
                DataProgress.Text = "";
            }
            if (videoId.Count > 0)
            {
                for (int i = 0; i < videoId.Count; i++)
                {
                    await DownloadWork(watchLink + videoId.ElementAt(i), i);
                }
            }
            else
            {
                await DownloadWork(Txt_url.Text);
            }
        }

        private void cmbQuality_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedVideoQuality = cmbQuality.SelectedItem.ToString();
        }

        private void cmbAudioQuality_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAudioQuality = cmbAudioQuality.SelectedItem.ToString();
        }

        private void txtUrl_Enter(object sender, EventArgs e)
        {
            if (Txt_url.Text == "Enter video link")
            {
                Txt_url.Text = "";
                Txt_url.ForeColor = SystemColors.WindowText;
            }

        }

        private void Txt_url_Leave(object sender, EventArgs e)
        {
            if( Txt_url.Text.Length == 0)
            {
                Txt_url.Text = "Enter video link";
                Txt_url.ForeColor = SystemColors.GrayText;
            }

        }

        private void Txt_Title_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }


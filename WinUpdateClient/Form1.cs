using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.IO.Compression;
using System.IO;
using IWshRuntimeLibrary;

namespace WinUpdateClient
{
    public partial class download_window : Form
    {
        public download_window()
        {
            InitializeComponent();
        }
        static void ExtractDownloadedZIP()
        {
            string zipPath = @"C:\AdrianDevProjects\Newest.zip";
            string extractPath = @"C:\AdrianDevProjects\AdrianDevHub";

            if (Directory.Exists(@"C:\AdrianDevProjects\AdrianDevHub"))
            {
                Directory.Delete(@"C:\AdrianDevprojects\AdrianDevHub", true);
            }
            System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, extractPath);
        }


    private void CreateShortcut()
    {
        object shDesktop = (object)"Desktop";
        WshShell shell = new WshShell();
        string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\AdrianDevHub.lnk";
        IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
        shortcut.Description = "AdrianDevHub starten";
        shortcut.Hotkey = "Ctrl+Shift+A";
        shortcut.TargetPath = @"C:\AdrianDevProjects\AdrianDevHub\AdrianDevHub.exe";
        shortcut.Save();
    }


    private void download_window_Load(object sender, EventArgs e)
        {
            startDownload();
        }
        private void startDownload()
        {
            Thread thread = new Thread(() => {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                client.DownloadFileAsync(new Uri("https://adriandevprojects.com/DevHub/newest.zip"), @"C:\AdrianDevProjects\Newest.zip");
            });
            thread.Start();
        }
        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate {
                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = bytesIn / totalBytes * 100;
                download_label.Text = "Downloaded " + e.BytesReceived + "KB of " + e.TotalBytesToReceive + "KB";
                download_progress.Value = int.Parse(Math.Truncate(percentage).ToString());
            });
        }
        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate {
                download_label.Text = "Completed";
            });
            ExtractDownloadedZIP();
            System.IO.File.Delete(@"C:\AdrianDevProjects\Newest.zip");
            CreateShortcut();
        }
    }
}

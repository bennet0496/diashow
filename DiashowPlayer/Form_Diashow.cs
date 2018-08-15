using MediaToolkit;
using MediaToolkit.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace DiashowPlayer
{
    public partial class Form_Diashow : Form
    {
        private Media currentmedia = new Media("", new RepeationSetting() { Interval = 1 }, MediaType.STILLIMAGE);

        private Control videoElement;

        public Media CurrentMedia { get => currentmedia; }

        public Form_Diashow(bool preferVLC = false)
        {
            InitializeComponent();
            if (preferVLC)
            {
                this.Load += new System.EventHandler(this.Form_Diashow_Load_VLC);
            }
            else
            {
                this.Load += new System.EventHandler(this.Form_Diashow_Load_WMP);
            }
        }

        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        delegate void StringArgReturningVoidDelegate(String text);

        delegate void ImageArgReturningVoidDelegate(Image image);

        delegate void BooleanArgReturningVoidDelegate(Boolean boolean);
        private void SetImage(Image image)
        {
            // InvokeRequired required compares the thread ID of the  
            // calling thread to the thread ID of the creating thread.  
            // If these threads are different, it returns true.  
            if (this.pictureBox1.InvokeRequired)
            {
                ImageArgReturningVoidDelegate d = new ImageArgReturningVoidDelegate(SetImage);
                this.Invoke(d, new object[] { image });
            }
            else
            {
                this.pictureBox1.Image = image;
            }
        }

        internal void play(Media mediaToPlay)
        {
            currentmedia = mediaToPlay;
            switch (mediaToPlay.Type)
            {
                case MediaType.STILLIMAGE:
                    hideVideoElememt();
                    SetImageLocation(mediaToPlay.Filename);
                    break;
                case MediaType.VIDEO:
                    showVideoElement();
                    playVideo(mediaToPlay.Filename);
                    break;
            }
        }

        private void playVideo(string filename)
        {
            if (videoElement.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(playVideo);
                Invoke(d, new object[] { filename });
            }
            else
            {
                if (videoElement.GetType().FullName.StartsWith("AxWMPLib.AxWindowsMediaPlayer"))
                {
                    videoElement.GetType().GetProperty("uiMode").SetValue(videoElement, "none");
                    videoElement.GetType().GetProperty("URL").SetValue(videoElement, filename);
                }
                else if (videoElement.GetType().FullName.StartsWith("Vlc.DotNet.Forms.VlcControl"))
                {
                    videoElement.GetType().GetMethod("SetMedia", new Type[] { typeof(FileInfo), typeof(string[]) }).Invoke(videoElement, new object[] { new FileInfo(filename), new string[] { "" } });
                    videoElement.GetType().GetMethod("Play", new Type[] { }).Invoke(videoElement, new object[] { });
                }
            }
        }

        private void showVideoElement()
        {
            SetVisibility(true);
        }
        private void SetVisibility(Boolean visible)
        {
            if (videoElement.InvokeRequired || pictureBox1.InvokeRequired)
            {
                BooleanArgReturningVoidDelegate d = new BooleanArgReturningVoidDelegate(SetVisibility);
                Invoke(d, new object[] { visible });
            }
            else
            {
                videoElement.Visible = visible;
                pictureBox1.Visible = !visible;
            }
        }
        private void SetImageLocation(string filename)
        {
            if (pictureBox1.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SetImageLocation);
                Invoke(d, new object[] { filename });
            }
            else
            {
                pictureBox1.ImageLocation = filename;
            }
        }

        private void hideVideoElememt()
        {
            SetVisibility(false);
        }

        private void loadVLC()
        {
            DirectoryInfo vlcDir;
            try
            {
                RegistryKey vlcreg = Registry.LocalMachine.OpenSubKey("SOFTWARE").OpenSubKey("VideoLAN").OpenSubKey("VLC");
                vlcDir = new DirectoryInfo(vlcreg.GetValue("InstallDir") as string);
            }
            catch
            {
                vlcDir = new DirectoryInfo(@"C:\Program Files (x86)\VideoLAN\VLC");
            }
            videoElement = new Vlc.DotNet.Forms.VlcControl();
            videoElement.Name = "videoElement";
            videoElement.GetType().GetProperty("VlcLibDirectory").SetValue(videoElement, vlcDir);
            try
            {
                videoElement.GetType().GetMethod("EndInit", new Type[] { }).Invoke(videoElement, new object[] { });
            }
            catch (DirectoryNotFoundException)
            {
                var dialog = new FolderBrowserDialog();
                dialog.RootFolder = Environment.SpecialFolder.MyComputer;
                dialog.Description = "Select VLC Media Player install directory";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    videoElement.GetType().GetProperty("VlcLibDirectory").SetValue(videoElement, new DirectoryInfo(dialog.SelectedPath));
                    videoElement.GetType().GetMethod("EndInit", new Type[] { }).Invoke(videoElement, new object[] { });
                }
                else
                {
                    throw;
                }
            }
        }

        private void loadWMP()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form_Diashow));
            var wmp = Assembly.LoadFrom(@"AxInterop.WMPLib.dll");
            videoElement = wmp.CreateInstance("AxWMPLib.AxWindowsMediaPlayer") as Control;
            videoElement.GetType().GetMethod("BeginInit", new Type[] { }).Invoke(videoElement, new object[] { });
            videoElement.Name = "videoElement";
            videoElement.GetType().GetProperty("OcxState").SetValue(videoElement, ((AxHost.State)(resources.GetObject("videoElement.OcxState"))));
        }

        private void Form_Diashow_Load_WMP(object sender, EventArgs e)
        {   
            try
            {
                loadWMP();
            }
            catch (Exception er)
            {
                DialogResult r = MessageBox.Show("Failed to load Windows Media Player. Maybe due to a N version of Windows and a missing Media Feature Pack. Do wan't to fallback to VLC Media Player playback?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (r == DialogResult.Yes)
                {
                    try
                    {
                        loadVLC();
                    }
                    catch (Exception er1)
                    {
                        MessageBox.Show("VLC Media Player failed to load also. Have you installed VLC Media Player?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Close();
                    }
                }
                else
                {
                    Close();
                }
            }
            videoElement.Dock = DockStyle.Fill;
            videoElement.Enabled = true;
            videoElement.Location = new Point(0, 0);
            videoElement.Size = new Size(800, 450);
            videoElement.TabIndex = 2;
            videoElement.GetType().GetMethod("EndInit", new Type[] { }).Invoke(videoElement, new object[] { });
            Controls.Add(videoElement);
        }

        private void Form_Diashow_Load_VLC(object sender, EventArgs e)
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form_Diashow));
            try
            {
                loadVLC();
            }
            catch (Exception er)
            {
                DialogResult r = MessageBox.Show("Failed to load VLC Media Player. Have you installed VLC Media Player? Do wan't to fallback to Windows Media Player playback?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (r == DialogResult.Yes)
                {
                    try
                    {
                        loadWMP();
                    }
                    catch (Exception er1)
                    {
                        MessageBox.Show("Windows Media Player failed to load also. Maybe due to a N version of Windows and a missing Media Feature Pack.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Close();
                    }
                }
                else
                {
                    Close();
                }
            }
            videoElement.Dock = DockStyle.Fill;
            videoElement.Enabled = true;
            videoElement.Location = new Point(0, 0);
            videoElement.Size = new Size(800, 450);
            videoElement.TabIndex = 2;
            Controls.Add(videoElement);
        }

        private void Form_Diashow_Shown(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}

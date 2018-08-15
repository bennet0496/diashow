using DiashowPlayer;
using MediaToolkit;
using MediaToolkit.Model;
using MediaToolkit.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diashow
{
    public partial class Form_Dialog_AddItem : Form
    {
        private DataGridView dGV_items;
        private string[] files;

        public Form_Dialog_AddItem()
        {
            InitializeComponent();
        }

        internal static DialogResult ShowModal(DataGridView dgv)
        {
            var instance = new Form_Dialog_AddItem
            {
                dGV_items = dgv
            };

            return instance.ShowDialog();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            var tooltip = new ToolTip();
            tooltip.ToolTipIcon = ToolTipIcon.Info;
            tooltip.Show("This setting determines how many times more often this item will be displayed in the slide show.", b_wighthelp);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This setting determines how many times more often this item will be displayed in the slide show.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <returns>The resized image.</returns>
        internal static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighSpeed;
                graphics.InterpolationMode = InterpolationMode.Low;
                graphics.SmoothingMode = SmoothingMode.HighSpeed;
                graphics.PixelOffsetMode = PixelOffsetMode.HighSpeed;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Marquee;

            var worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += (worksender, args) =>
            {
                BackgroundWorker myself = worksender as BackgroundWorker;
                myself.ReportProgress(0);
                string[] files = args.Argument as string[];
                List<string> skipped = new List<string>();

                int counter = 0;
                foreach (string file in files)
                {
                    var row = new DataGridViewRow();
                    var imagecell = new DataGridViewImageCell();
                    var filenamecell = new DataGridViewTextBoxCell();
                    var typecell = new DataGridViewTextBoxCell();
                    var repetioncell = new DataGridViewTextBoxCell();
                    int interval;
                    try
                    {
                        if ((new string[] { ".avi", ".mp4", ".m4v", ".mkv", ".webm", ".mov", ".wmv" }).Contains(Path.GetExtension(file).ToLower())){
                            using (var engine = new Engine())
                            {
                                string thumbnailPath = Path.GetDirectoryName(file) + @"\" + Path.GetFileNameWithoutExtension(file) + ".jpg";
                                var inputFile = new MediaFile
                                {
                                    Filename = file
                                };
                                var outputFile = new MediaFile { Filename = thumbnailPath };
                                engine.GetMetadata(inputFile);
                                //if(!(new string[] { "hvc", "hevc", "h265", "h264", "avc1", "mpeg2video", "mjpeg", "vp9" }).Contains(inputFile.Metadata.VideoData.Format.Split(' ')[0].ToLower()))
                                //{
                                //    skipped.Add(Path.GetFileName(file) + ": Unsupported Codec (" + inputFile.Metadata.VideoData.Format + ")");
                                //    continue;
                                //}
                                var options = new ConversionOptions { Seek = TimeSpan.FromSeconds(inputFile.Metadata.Duration.TotalSeconds / 2) };
                                engine.GetThumbnail(inputFile, outputFile, options);
                                imagecell.Value = ResizeImage(Image.FromFile(thumbnailPath), 100, 100);
                                typecell.Value = "Video " + inputFile.Metadata.VideoData.Format;
                                interval = Convert.ToInt32(inputFile.Metadata.Duration.TotalMilliseconds);
                            }
                        } else {
                            var fullImage = Image.FromFile(file);
                            imagecell.Value = ResizeImage(fullImage, 100, 100);
                            fullImage.Dispose();
                            typecell.Value = "Image " + Image.FromFile(file).RawFormat.ToString();
                            interval = Decimal.ToInt32(nUD_interval.Value);
                        }
                    }
                    catch
                    {
                        skipped.Add(Path.GetFileName(file) + ": Error while reading File");
                        continue;
                    }
                    filenamecell.Value = file;
                    
                    repetioncell.Value = new RepeationSetting()
                    {
                        Interval = interval,
                        Weight = Decimal.ToInt32(nUD_weight.Value)
                    };
                    repetioncell.ValueType = typeof(RepeationSetting);

                    row.Cells.AddRange(new DataGridViewCell[] { imagecell, filenamecell, typecell, repetioncell });

                    dGV_items.BeginInvoke((Action)(() => { dGV_items.Rows.Add(row); }));

                    if(counter % 10 == 0)
                    {
                        GC.Collect();
                    }
                    myself.ReportProgress(Convert.ToInt32(Math.Floor(((double)++counter / (double)files.Length) * 100.0)));
                }
                if (skipped.Count > 0)
                {
                    MessageBox.Show("Some File are Skipped:\n\n " + skipped.Aggregate((sentance, next) => sentance + "\n " + next), "Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                myself.ReportProgress(100);
            };
            worker.ProgressChanged += (progresssender, args) =>
            {
                if(args.ProgressPercentage == 0)
                {
                    progressBar1.Value = 0;
                    progressBar1.Style = ProgressBarStyle.Marquee;
                }
                else
                {
                    progressBar1.Style = ProgressBarStyle.Continuous;
                    progressBar1.Value = args.ProgressPercentage;
                }
            };
            worker.RunWorkerCompleted += (s, a) =>
            {
                Close();
                DialogResult = DialogResult.OK;
            };

            worker.RunWorkerAsync(files);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (openFileDialog.FileNames.Count() > 1)
            {
                tB_Files.Text = Path.GetDirectoryName(openFileDialog.FileNames[0]) + @"\{" + 
                    openFileDialog.SafeFileNames.Aggregate((workingSentence, next) => workingSentence + "," + next) + "}";
            } else
            {
                tB_Files.Text = openFileDialog.FileNames[0];
            }
            files = openFileDialog.FileNames;
        }
    }
}

using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ImagePairer
{
    public partial class MainMenu : Form
    {
        int width = 32;
        bool shouldCancel = false;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            Task.Run(() => RunTask());
        }

        private void RunTask()
        {
            double averageMs = 0;
            double totalMs = 0;
            int totalTimes = 0;

            List<string> images = Directory.GetFiles("input").ToList();
            List<string> newOrder = new List<string> { images[0] };

            List<Bitmap> scaledBitmaps = new List<Bitmap>();
            for (int i = 0; i < images.Count; i++)
            {
                Console.WriteLine("[" + (i + 1).ToString() + "/" + images.Count.ToString() + "] RESIZING: \"" + images[i] + "\" -> " + width + "x" + width);
                scaledBitmaps.Add(RescaleBitmap(new Bitmap(images[i]), width));
            }

            Console.WriteLine("\n");

            int totalOperations = CalculateArithmeticSummation(images.Count - 1);

            while (images.Count > 0)
            {
                Bitmap initialBitmap = scaledBitmaps[0];

                int closestIndex = 0;
                double lowestValue = double.MaxValue;

                int progressPrefixLength = 0;

                for (int i = 1; i < images.Count; i++)
                {
                    DateTime startTime = DateTime.Now;

                    string progressPrefix = "[" + (i + 1).ToString() + "/" + images.Count.ToString() + "] ";
                    progressPrefixLength = progressPrefix.Length;
                    //Console.WriteLine(progressPrefix + "Processing: \"" + images[i] + "\"");

                    Bitmap compareBitmap = scaledBitmaps[i];

                    double imageValue = 0;

                    for (int x = 0; x < width; x++)
                    {
                        for (int y = 0; y < width; y++)
                        {
                            Color initalBitmapColor = initialBitmap.GetPixel(x, y);
                            Color compareBitmapColor = compareBitmap.GetPixel(x, y);

                            double colorDistance = Math.Sqrt(
                                    Math.Pow(initalBitmapColor.R - compareBitmapColor.R, 2) +
                                    Math.Pow(initalBitmapColor.G - compareBitmapColor.G, 2) +
                                    Math.Pow(initalBitmapColor.B - compareBitmapColor.B, 2)
                                );

                            imageValue += colorDistance;
                        }
                    }

                    totalTimes++;

                    if (imageValue < lowestValue || imageValue == 0)
                    {
                        lowestValue = imageValue;
                        closestIndex = i;

                        Console.WriteLine(progressPrefix/*new string(' ', progressPrefixLength)*/ + "Found lower value: " + lowestValue);
                    }

                    DateTime endTime = DateTime.Now;

                    TimeSpan elapsedTime = endTime - startTime;

                    totalMs += elapsedTime.TotalMilliseconds;

                    totalOperations--;
                }

                averageMs = totalMs / totalTimes;

                double msLeft = totalOperations * averageMs;

                Invoke((MethodInvoker)delegate
                {
                    ProgressLabel.Text = totalOperations.ToString() + " " + ((int)(msLeft / 1000 / 60)).ToString() + " " + ((int)((msLeft / 1000) % 60)).ToString(); ;
                });

                string space = new string(' ', progressPrefixLength);
                Console.WriteLine("\n" + space + "MATCHED: \"" + images[0] + "\"\n" + space + "WITH: \"" + images[closestIndex] + "\"\n");

                newOrder.Add(images[closestIndex]);

                scaledBitmaps.RemoveAt(0);
                images.RemoveAt(0);

                if (images.Count == 1)
                {
                    newOrder.Add(images[0]);
                    break;
                }

                string temp = images[0];
                var temp2 = scaledBitmaps[0];

                images[0] = images[closestIndex - 1];
                scaledBitmaps[0] = scaledBitmaps[closestIndex - 1];

                images[closestIndex - 1] = temp;
                scaledBitmaps[closestIndex - 1] = temp2;

                if (shouldCancel)
                {
                    shouldCancel = false;
                    break;
                }
            }

            for (int i = 0; i < newOrder.Count; i++)
            {
                string copyPath = "output\\" + i.ToString()/* + "_" + Path.GetFileName(newOrder[i]);*/ + ".png";
                File.Copy(newOrder[i], copyPath);
                Console.WriteLine("[" + (i + 1).ToString() + "/" + newOrder.Count.ToString() + "] COPYING: \"" + newOrder[i] + "\" -> \"" + copyPath + "\"");
            }

            foreach (var bitmap in scaledBitmaps)
            {
                bitmap.Dispose();
            }
        }

        private int CalculateArithmeticSummation(int limit)
        {
            int result = 0;

            for (int i = 1; i <= limit; i++)
            {
                result += i;
            }

            return result;
        }

        private Bitmap RescaleBitmap(Bitmap bitmap, int scale)
        {
            Bitmap rescaledBitmap = new Bitmap(scale, scale);

            using (Graphics g = Graphics.FromImage(rescaledBitmap))
            {
                g.InterpolationMode = InterpolationMode.NearestNeighbor;
                g.DrawImage(bitmap, 0, 0, scale, scale);
            }

            bitmap.Dispose();

            return rescaledBitmap;
        }

        private void GenerateRandomImages_Click(object sender, EventArgs e)
        {
            const int count = 20000;
            Random rand = new Random();
            for (int i = 0; i < count; i++)
            {
                Bitmap bitmap = new Bitmap(width, width);

                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < width; y++)
                    {
                        Color color = Color.FromArgb(255, rand.Next(256), rand.Next(256), rand.Next(256));
                        bitmap.SetPixel(x, y, color);
                    }
                }

                bitmap.Save("input\\" + i.ToString() + ".png");
            }
        }


        List<Bitmap> bitmaps = new List<Bitmap>();
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadPreviewBitmaps("output");
        }

        private void ScrollTrackbar_Scroll(object sender, EventArgs e)
        {
            ViewerPictureBox.Image = bitmaps[ScrollTrackbar.Value];
            label1.Text = ScrollTrackbar.Value.ToString();
        }

        private void ViewerPictureBox_Paint(object sender, PaintEventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;

            if (pictureBox.Image != null)
            {
                e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
                e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                e.Graphics.DrawImage(pictureBox.Image, pictureBox.ClientRectangle);
            }
        }

        private void Refresh2Button_Click(object sender, EventArgs e)
        {
            LoadPreviewBitmaps("input");
        }

        private void LoadPreviewBitmaps(string path)
        {
            if (bitmaps.Count > 0)
            {
                foreach (var bitmap in bitmaps)
                {
                    bitmap.Dispose();
                }
                bitmaps.Clear();
            }

            string[] fileNames = Directory.GetFiles(path);

            var sortedFileNames = fileNames.OrderBy(fileName => int.Parse(Path.GetFileNameWithoutExtension(fileName)));

            int index = 1;
            foreach (string bitmap in sortedFileNames)
            {
                bitmaps.Add(RescaleBitmap(new Bitmap(bitmap), width));
                Console.WriteLine("[" + index.ToString() + "/" + sortedFileNames.Count().ToString() + "] RESIZING: \"" + bitmap + "\" -> " + width + "x" + width);
                index++;
            }

            ScrollTrackbar.Maximum = bitmaps.Count - 1;
        }

        private void TerminateButton_Click(object sender, EventArgs e)
        {
            shouldCancel = true;
        }
    }
}
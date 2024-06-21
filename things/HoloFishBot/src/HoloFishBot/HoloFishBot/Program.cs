using System;
using System.IO;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;

namespace HoloFishBot
{
    public partial class Program : Form
    {
        private Point topLeftBound, bottomRightBound;
        private int colorThreshold = 180;

        private bool shouldTick = false;
        private bool hasStarted = false;

        private const uint VK_W = 0x0057; // W
        private const uint VK_S = 0x0053; // S
        private const uint VK_A = 0x0041; // A
        private const uint VK_D = 0x0044; // D
        private const uint VK_RETURN = 0x0D; // RETURN/ENTER

        private const uint KEYEVENTF_EXTENDEDKEY = 0x0001;
        private const uint KEYEVENTF_KEYUP = 0x0002;

        Color[] colors =
        {
            Color.FromArgb(225, 50, 50), // UP
            Color.FromArgb(52, 144, 244), // DOWN
            Color.FromArgb(245, 197, 67), // LEFT
            Color.FromArgb(45, 235, 43), // RIGHT
            Color.FromArgb(174, 49, 209), // CENTER

            Color.FromArgb(75, 186, 246) // MENU
        };

        private readonly System.Timers.Timer threadedSecondTickTimer = new System.Timers.Timer();

        // keyboard press emulation
        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);

        // key press detection
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(uint vKey);

        public Program()
        {
            InitializeComponent();
        }

        private void Program_Load(object sender, EventArgs e)
        {
            topLeftBound.X = 1134;
            topLeftBound.Y = 714;

            bottomRightBound.X = 1223;
            bottomRightBound.Y = 800;

            if (File.Exists("holofishbot.cfg"))
            {
                string[] rawBounds = File.ReadAllText("holofishbot.cfg").Split(' ');
                int[] bounds = new int[rawBounds.Length];

                for (int i = 0; i < rawBounds.Length; i++)
                {
                    int.TryParse(rawBounds[i], out bounds[i]);
                }

                topLeftBound.X = bounds[0];
                topLeftBound.Y = bounds[1];

                bottomRightBound.X = bounds[2];
                bottomRightBound.Y = bounds[3];

                colorThreshold = bounds[4];
            }

            string configLabel = $"P1: ({topLeftBound.X}, {topLeftBound.Y})\nP2: ({bottomRightBound.X}, {bottomRightBound.Y})\nCT: {colorThreshold}";
            ConfigLabel.Text = configLabel;

            TopMost = true;

            threadedSecondTickTimer.Elapsed += new ElapsedEventHandler(ThreadedSecondTick);
            threadedSecondTickTimer.Interval = 1000;
            threadedSecondTickTimer.Enabled = false;
        }

        private void Program_FormClosing(object sender, FormClosingEventArgs e)
        {
            StringBuilder config = new StringBuilder();

            config.Append(topLeftBound.X).Append(' ');
            config.Append(topLeftBound.Y).Append(' ');
            config.Append(bottomRightBound.X).Append(' ');
            config.Append(bottomRightBound.Y).Append(' ');
            config.Append(colorThreshold);

            File.WriteAllText("holofishbot.cfg", config.ToString());
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            shouldTick = true;

            if (!hasStarted)
            {
                Task.Run(() => ThreadedTick());
            }

            hasStarted = true;
            threadedSecondTickTimer.Enabled = true;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            shouldTick = false;
            hasStarted = false;
            threadedSecondTickTimer.Enabled = false;
        }

        bool canKeyPress = true;
        string lastKey = "n/a";

        int elapsedTime = 0;
        string elapsedTimeString = "00:00:00";

        int keysPressed = 0;
        int fishCaught = 0;

        private void ThreadedTick()
        {
            while (shouldTick)
            {
                Rectangle bounds = Screen.GetBounds(Point.Empty);
                using (Bitmap bitmap = new Bitmap(bottomRightBound.X - topLeftBound.X, bottomRightBound.Y - topLeftBound.Y))
                {
                    using (Graphics g = Graphics.FromImage(bitmap))
                    {
                        Size size = new Size(bottomRightBound.X - topLeftBound.X + 1, bottomRightBound.Y - topLeftBound.Y + 1);
                        g.CopyFromScreen(topLeftBound, new Point(0, 0), size);
                    }

                    Bitmap bitmapClone = new Bitmap(bitmap);

                    try
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            BoundsPictureBox.Image?.Dispose();
                            BoundsPictureBox.Image = bitmapClone;
                        });
                    }
                    catch { }

                    int closestIndex = 0;
                    int maxColorMatch = int.MinValue;
                    for (int i = 0; i < colors.Length; i++)
                    {
                        int colorMatch = CountColors(bitmap, colors[i]);
                        if (colorMatch > maxColorMatch)
                        {
                            maxColorMatch = colorMatch;
                            closestIndex = i;
                        }
                    }

                    bitmap.Dispose();

                    // 180 is the amount of color matched pixels to be seen before it clicks
                    if (maxColorMatch > colorThreshold && canKeyPress)
                    {
                        switch (closestIndex)
                        {
                            case 0:
                                Task.Run(() => SimulateKeyPress(VK_W));

                                lastKey = "W";

                                break;
                            case 1:
                                Task.Run(() => SimulateKeyPress(VK_S));

                                lastKey = "S";

                                break;
                            case 2:
                                Task.Run(() => SimulateKeyPress(VK_A));

                                lastKey = "A";

                                break;
                            case 3:
                                Task.Run(() => SimulateKeyPress(VK_D));

                                lastKey = "D";

                                break;
                            case 4:
                                Task.Run(() => SimulateKeyPress(VK_RETURN));

                                lastKey = "Enter";

                                break;
                            case 5:
                                Task.Run(() => SimulateKeyPress(VK_RETURN));
                                Thread.Sleep(200);
                                Task.Run(() => SimulateKeyPress(VK_RETURN));

                                lastKey = "Enter";
                                fishCaught++;

                                break;
                        }

                        canKeyPress = false;

                        Console.WriteLine(lastKey);
                    }

                    if (maxColorMatch < 20)
                    {
                        canKeyPress = true;
                    }

                    try
                    {
                        Invoke((MethodInvoker)delegate
                    {
                        // K = KEY
                        // CM = Color Match
                        DebugLabel.Text = $"K: {lastKey} | KC: {keysPressed} | CM: {maxColorMatch}\nT: {elapsedTimeString} | FC: {fishCaught}";
                    });
                    }
                    catch { }
                }
            }
        }

        private void ThreadedSecondTick(object source, ElapsedEventArgs e)
        {
            elapsedTimeString = FormatSeconds(elapsedTime);

            elapsedTime++;
        }

        private string FormatSeconds(int totalSeconds)
        {
            int hours = totalSeconds / 3600;
            int minutes = (totalSeconds % 3600) / 60;
            int seconds = totalSeconds % 60;

            return $"{hours:D2}:{minutes:D2}:{seconds:D2}";
        }

        private int CountColors(Bitmap bitmap, Color color)
        {
            int count = 0;

            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color currentColor = bitmap.GetPixel(x, y);

                    double distance = Math.Sqrt(
                        Math.Pow(color.R - currentColor.R, 2) +
                        Math.Pow(color.G - currentColor.G, 2) +
                        Math.Pow(color.B - currentColor.B, 2)
                    );

                    if (distance < 2)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        private void SelectBoundsButton_Click(object sender, EventArgs e)
        {
            // 0x01 = leftmouse
            // 0x1B = esc
            while (!DetectKey(0x01))
            {

            }
            topLeftBound = Cursor.Position;
            Console.WriteLine(topLeftBound);

            while (DetectKey(0x01))
            {

            }

            while (!DetectKey(0x01))
            {

            }
            bottomRightBound = Cursor.Position;
            Console.WriteLine(bottomRightBound);
        }

        // 0x01 = leftmouse
        // 0x1B = esc
        private bool DetectKey(uint key)
        {
            short keyState = GetAsyncKeyState(key);
            bool keyPressed = ((keyState >> 15) & 0x0001) == 0x0001;

            if (keyPressed)
                return true;

            return false;
        }

        private void SimulateKeyPress(uint key)
        {
            keysPressed++;

            keybd_event((byte)key, 0, KEYEVENTF_EXTENDEDKEY, 0);
            Thread.Sleep(100);
            keybd_event((byte)key, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
        }
    }
}
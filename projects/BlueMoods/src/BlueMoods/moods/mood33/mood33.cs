using System;
using System.Media;
using System.Windows.Forms;
using System.Windows.Threading;

namespace BlueMoods.moods.mood33
{
    public partial class mood33 : Form
    {
        public mood33()
        {
            InitializeComponent();
        }

        private void mood33_Load(object sender, EventArgs e)
        {
            System.Reflection.Assembly a0 = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream s0 = a0.GetManifestResourceStream("BlueMoods.moods.mood33.mood33.wav");
            SoundPlayer player0 = new SoundPlayer(s0);
            player0.Play();

            var timer = new DispatcherTimer();
            timer.Tick += delegate

            {
                this.Close();
            };

            timer.Interval = TimeSpan.FromMilliseconds(10000);
            timer.Start();
        }
    }
}
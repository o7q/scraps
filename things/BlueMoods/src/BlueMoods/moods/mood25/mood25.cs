﻿using System;
using System.Media;
using System.Windows.Forms;
using System.Windows.Threading;

namespace BlueMoods.moods.mood25
{
    public partial class mood25 : Form
    {
        public mood25()
        {
            InitializeComponent();
        }

        private void mood25_Load(object sender, EventArgs e)
        {
            System.Reflection.Assembly a0 = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream s0 = a0.GetManifestResourceStream("BlueMoods.moods.mood25.mood25.wav");
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
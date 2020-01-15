using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace StopWatch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer dispatcherTimer;
        private int mm, ss;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            mm = int.Parse(TimeMinute.Text);
            ss = int.Parse(TimeSecond.Text);
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Tick += timer_tick;
            dispatcherTimer.Start();

        }

        public void timer_tick(object sender, EventArgs e)
        {
            if (mm >= 0)
            {
                if (ss == 0)
                {
                    ss = 60;
                    mm--;
                }

                if (mm == 0 && ss == 1)
                {
                    SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\mike5171\source\repos\H2\StopWatch\StopWatch\alarm.wav");
                    player.Play();
                    dispatcherTimer.Stop();
                }
                ss--;
                TimeMinute.Text = mm.ToString();
                TimeSecond.Text = ss.ToString();
            }
            else
            {
                dispatcherTimer.Stop();
            }
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            if (dispatcherTimer.IsEnabled)
            {
                dispatcherTimer.Stop();
            }
        }
    }
}

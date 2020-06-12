using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using System.Windows.Threading;

namespace StudyHelper
{
    public partial class MainWindow : Window
    {
        DispatcherTimer dt = new DispatcherTimer();

        DispatcherTimer dt1 = new DispatcherTimer();

        DateTime dateTime = new DateTime();

        DateTime dateTimer = new DateTime(2020, 10, 10, 0, 0, 0);

        public List<string> objList = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dt1.Interval = TimeSpan.FromSeconds(1);
            dt1.Tick += dt1_Ticker;
            dt1.Start();
            dt.Interval = TimeSpan.FromSeconds(1);
            dt.Tick += dtTicker;
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            dt.Start();
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            this.dt.Stop();
        }

        private void Finish_Click(object sender, RoutedEventArgs e)
        {
            dateTimer = new DateTime(2020, 10, 10, 0, 0, 0);
            this.dt.Stop();
        }

        private void AddObjectives_Click(object sender, RoutedEventArgs e)
        {
            Window win2 = new Window2();
            win2.Show();
        }

        private void dt1_Ticker(object sender, EventArgs e)
        {
            dateTime = DateTime.Now;
            this.Time.Text = $"{dateTime.Hour} : {dateTime.Minute} : {dateTime.Second}";
        }

        private void dtTicker(object sender, EventArgs e)
        {
            dateTimer = dateTimer.AddSeconds(1);
            this.Timer.Text = $"{dateTimer.TimeOfDay}";
        }
    }
}

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
        public bool isPause = false;

        public bool isStarted = false;

        public MainWindow()
        {
            InitializeComponent();

            //  DispatcherTimer timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            //   {
            //       this.Time.Text = DateTime.Now.Hour.ToString() + " : " + DateTime.Now.Minute.ToString();
            //   }, this.Dispatcher);
            
        }
        //bugged
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            if (!isPause)
            {
                this.isPause = false;

                DateTime date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, 0, 0);

                DispatcherTimer timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
                {

                    date = date.AddSeconds(1);
                    this.Timer.Text = date.Minute + " : " + date.Second.ToString();


                }, this.Dispatcher);
                
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }
    }
}

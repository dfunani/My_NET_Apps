using System;
using System.Windows;
using System.Threading;
using System.Windows.Threading;

namespace StopWatch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string date { get { return (string)GetValue(dateProp); } set{ SetValue(dateProp, value); } }
        public static DependencyProperty dateProp = DependencyProperty.Register("date", typeof(string), typeof(MainWindow));
        public string time { get { return (string)GetValue(timeProp); } set { SetValue(timeProp, value); } }
        public static DependencyProperty timeProp = DependencyProperty.Register("time", typeof(string), typeof(MainWindow));

        public string day { get { return (string)GetValue(dayProp); } set { SetValue(dayProp, value); } }
        public static DependencyProperty dayProp = DependencyProperty.Register("day", typeof(string), typeof(MainWindow));

        public string sec { get { return (string)GetValue(secProp); } set { SetValue(secProp, value); } }
        public static DependencyProperty secProp = DependencyProperty.Register("sec", typeof(string), typeof(MainWindow));
        DispatcherTimer timer = null;
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(SetTimer);
            timer.Interval = new TimeSpan(1000);
            timer.Start();
        }

        private void SetTimer(Object sender, EventArgs e)
        {
            date = DateTime.Now.ToString("dd MMMM yyyy");
            time = DateTime.Now.ToString("HH:mm");
            day = DateTime.Now.ToString("dddd");
            sec = DateTime.Now.ToString("ss");
        }

        private void Ellipse_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}

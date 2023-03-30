using RaCee.Components;
using System;
using System.Threading;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace RaCee
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DispatcherTimer TimeKeeper;
        public int i = 0;
        
        public MainWindow()
        {
            InitializeComponent();
            /*TimeKeeper = new DispatcherTimer();
            TimeKeeper.Tick += new EventHandler(Transition);
            TimeKeeper.Interval = new TimeSpan(1000);
            TimeKeeper.Start();*/
            Transition(null, null);
        }

        private void Transition(Object? sender, EventArgs? obj)
        {
            Strip strip = new Strip();
            border.Children.Add(strip);
            MessageBox.Show(strip.Margin.Top.ToString());
        }

        
       
    }
}

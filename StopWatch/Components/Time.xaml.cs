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

namespace StopWatch.Components
{
    
    public partial class Time : UserControl
    {
        public string clock { get { return (string)GetValue(ClockProp); } set { SetValue(ClockProp, value); } }
        public static readonly DependencyProperty ClockProp = DependencyProperty.Register("clock", typeof(string), typeof(Time));

        public string secs { get { return (string)GetValue(secsProp); } set { SetValue(secsProp, value); } }
        public static readonly DependencyProperty secsProp = DependencyProperty.Register("secs", typeof(string), typeof(Time));
        public Time()
        {
            InitializeComponent();
        }
    }
}

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
    public partial class Display : UserControl
    {
        public string text { get { return (string)GetValue(textprop); } set { SetValue(textprop, value); } }
        public static readonly DependencyProperty textprop = DependencyProperty.Register("text", typeof(string), typeof(Display));
        public Display()
        {
            InitializeComponent();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
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

namespace RaCee.Components
{
    /// <summary>
    /// Interaction logic for Strip.xaml
    /// </summary>
    public partial class Strip : UserControl
    {
        public Strip()
        {
            InitializeComponent();
            Transition();
        }

        private void Transition()
        {
            Thickness i = this.Margin;
            MessageBox.Show(this.Margin.ToString());
            while (this.Margin.Top < 500)
            {
                this.Margin = new Thickness(0, i.Top, 0, 0);
                i.Top += 5;
            }
            /*this.Visibility = Visibility.Collapsed;*/
        }
    }
}

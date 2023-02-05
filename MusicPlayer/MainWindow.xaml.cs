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

namespace MusicPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Dictionary<String, List<String>> strings = new Dictionary<String, List<String>>() {
            { "Library", new List<String>(){ "Home", "Playlists", "Artists", "Album", "Songs" }},
           { "Discover", new List<String>(){"Store", "Radio", "For You"} }
        };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MediaElement_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Ellipse_MouseDown_Close(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Ellipse_MouseDown_Minimize(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Hello World");
        }
    }
}

using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace MyPainter
{
    
    public partial class MainWindow : Window
    {
        public System.Windows.Media.Brush COLOR = System.Windows.Media.Brushes.Black;
        public int dotWidth = 5;
        public bool isPainting = false;
        public bool isErasing = false;

        public string ColorActive
        {
            get { return (string)GetValue(ColorActiveProp); } set { SetValue(ColorActiveProp, value); }
        }
        private static readonly DependencyProperty ColorActiveProp = DependencyProperty.Register(
            "ColorActive", typeof(string), typeof(MainWindow));

        public string NotColorActive
        {
            get { return (string)GetValue(NotColorActiveProp); }
            set { SetValue(NotColorActiveProp, value); }
        }
        private static readonly DependencyProperty NotColorActiveProp = DependencyProperty.Register(
            "NotColorActive", typeof(string), typeof(MainWindow));

        public string FontActive
        {
            get { return (string)GetValue(FontActiveProp); }
            set { SetValue(FontActiveProp, value); }
        }
        private static readonly DependencyProperty FontActiveProp = DependencyProperty.Register(
            "FontActive", typeof(string), typeof(MainWindow));

        public string NotFontActive
        {
            get { return (string)GetValue(NotFontActiveProp); }
            set { SetValue(NotFontActiveProp, value); }
        }
        private static readonly DependencyProperty NotFontActiveProp = DependencyProperty.Register(
            "NotFontActive", typeof(string), typeof(MainWindow));

        public string EraseActive
        {
            get { return (string)GetValue(EraseActiveProp); }
            set { SetValue(EraseActiveProp, value); }
        }
        private static readonly DependencyProperty EraseActiveProp = DependencyProperty.Register(
            "EraseActive", typeof(string), typeof(MainWindow));

        public MainWindow()
        {
            InitializeComponent();
            ColorActive = "Collapsed"; 
            FontActive = "Collapsed"; 
            NotColorActive = "Visible";
            NotFontActive = "Visible";
        }

        private void canvas_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if(isPainting)
                paintDot(COLOR, (System.Windows.Point)e.GetPosition(canvas));
        }

        private void paintDot(System.Windows.Media.Brush color, System.Windows.Point position)
        {
            Ellipse dot= new Ellipse();
            dot.Fill = color;
            dot.Width = dotWidth;
            dot.Height = dotWidth;
            Canvas.SetTop(dot, position.Y);
            Canvas.SetLeft(dot, position.X);
            canvas.Children.Add(dot);
        }

        private void Ellipse_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ColorActive = "Visible";
            NotColorActive = "Collapsed";
            FontActive = "Collapsed";
            NotFontActive = "Hidden";
        }

        private void Ellipse_MouseDown_X(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            FontActive = "Visible";
            NotFontActive = "Collapsed";
            ColorActive = "Collapsed";
            NotColorActive = "Hidden";
        }


        private void Ellipse_MouseDown_1(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            NotColorActive = "Visible";
            ColorActive = "Collapsed";
            NotFontActive = "Visible";
            FontActive = "Collapsed";
            COLOR = System.Windows.Media.Brushes.Red;
        }

        private void Ellipse_MouseDown_2(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            NotColorActive = "Visible";
            ColorActive = "Collapsed";
            NotFontActive = "Visible";
            FontActive = "Collapsed";
            COLOR = System.Windows.Media.Brushes.Green;
        }

        private void Ellipse_MouseDown_3(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            NotColorActive = "Visible";
            ColorActive = "Collapsed";
            NotFontActive = "Visible";
            FontActive = "Collapsed";
            COLOR = System.Windows.Media.Brushes.Blue;
        }

        private void Ellipse_MouseDown_4(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            NotColorActive = "Visible";
            ColorActive = "Collapsed";
            NotFontActive = "Visible";
            FontActive = "Collapsed";
            COLOR = System.Windows.Media.Brushes.Black;
        }

        private void Ellipse_MouseDown_5(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            NotColorActive = "Visible";
            ColorActive = "Collapsed";
            NotFontActive = "Visible";
            FontActive = "Collapsed";
            dotWidth = 5 * 4
                ;
        }

        private void Ellipse_MouseDown_6(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            NotColorActive = "Visible";
            ColorActive = "Collapsed";
            NotFontActive = "Visible";
            FontActive = "Collapsed";
            dotWidth = 5 * 3;
        }

        private void Ellipse_MouseDown_7(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            NotColorActive = "Visible";
            ColorActive = "Collapsed";
            NotFontActive = "Visible";
            FontActive = "Collapsed";
            dotWidth = 5 * 2;
        }

        private void Ellipse_MouseDown_8(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            NotColorActive = "Visible";
            ColorActive = "Collapsed";
            NotFontActive = "Visible";
            FontActive = "Collapsed";
            dotWidth = 5;
        }

        private void canvas_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            isPainting = true;

        }

        private void canvas_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            isPainting = true;
            COLOR = System.Windows.Media.Brushes.White;
            
        }

        private void canvas_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            isPainting = false;
        }
    }
}

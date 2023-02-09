using System.Windows;
using System.Windows.Controls;

namespace MusicPlayer.UserControls
{
    public partial class Following : UserControl
    {
        public Following()
        {
            InitializeComponent();
        }


        public string Title
        {
            get { return (string)GetValue(TitleProp); }
            set { SetValue(TitleProp, value); }
        }
        public static readonly DependencyProperty TitleProp = DependencyProperty.Register(
            "Title", typeof(string), typeof(Following));

        public string Date
        {
            get { return (string)GetValue(DateProp); }
            set { SetValue(DateProp, value); }
        }
        public static readonly DependencyProperty DateProp = DependencyProperty.Register(
            "Date", typeof(string), typeof(Following));

        public bool IsActive
        {
            get { return (bool)GetValue(IsActiveProp); }
            set { SetValue(IsActiveProp, value); }
        }
        public static readonly DependencyProperty IsActiveProp = DependencyProperty.Register(
            "IsActive", typeof(bool), typeof(Following));


        public string Image
        {
            get { return (string)GetValue(ImageProp); }
            set { SetValue(ImageProp, value); }
        }
        public static readonly DependencyProperty ImageProp = DependencyProperty.Register(
            "Image", typeof(string), typeof(Following));
    }
}

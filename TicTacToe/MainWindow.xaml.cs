using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Player[] board = new Player[] { Player.blank,Player.blank,Player.blank,Player.blank,Player.blank,Player.blank,Player.blank,Player.blank,Player.blank };
        private bool isP1 = true; 
        private bool isGameOver = false;
        private string winner = "";
        public MainWindow()
        {
            InitializeComponent();
            StartGame();
        }

        public void StartGame()
        {
            Container.Children.Cast<Button>().ToList().ForEach(b => { b.Content = ""; b.Background = Brushes.Black; b.Foreground = Brushes.White; });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (button.Content.ToString() != "" || Is_GameOver())
                return;
            if (isP1)
                button.Foreground = Brushes.Red;
            else
                button.Foreground = Brushes.Blue;
            
            button.Content = isP1 ? "X" : "0";
            int column = Grid.GetColumn(button);
            int row = Grid.GetRow(button);
            int index = column + (row * 3);
            board[index] = isP1 ? Player.p1 : Player.p2;
            
            if (Is_GameOver() && winner == "")
                MessageBox.Show("Game Over");
            else if (Is_GameOver() && winner != "")
                MessageBox.Show($"Winner is {winner}");
            if (Is_GameOver())
            {
                System.Diagnostics.Process.Start(System.Diagnostics.Process.GetCurrentProcess().ProcessName);
                App.Current.Shutdown();
            }

            isP1 ^= true;
        }

        private bool Is_GameOver()
        {
            if(!Check_Winner())
                return Container.Children.Cast<Button>().ToList().All(button => button.Content.ToString() != "");
            else
                return true;
        }

        private bool Check_Winner()
        {
            if (board[0] != Player.blank && (board[0] & board[1] & board[2]) == board[0])
            {
                Button_1.Background = Brushes.Green;
                Button_2.Background = Brushes.Green;
                Button_3.Background = Brushes.Green;
                winner = board[0].ToString();
                return true;
            }
            if (board[3] != Player.blank && (board[3] & board[4] & board[5]) == board[3])
            {
                Button_4.Background = Brushes.Green;
                Button_5.Background = Brushes.Green;
                Button_6.Background = Brushes.Green;
                winner = board[3].ToString();
                return true;
            }
            if (board[6] != Player.blank && (board[6] & board[7] & board[8]) == board[6])
            {
                Button_7.Background = Brushes.Green;
                Button_8.Background = Brushes.Green;
                Button_9.Background = Brushes.Green;
                winner = board[6].ToString();
                return true;
            }

            if (board[0] != Player.blank && (board[0] & board[3] & board[6]) == board[0])
            {
                Button_1.Background = Brushes.Green;
                Button_4.Background = Brushes.Green;
                Button_7.Background = Brushes.Green;
                winner = board[0].ToString();
                return true;
            }
            if (board[1] != Player.blank && (board[1] & board[4] & board[7]) == board[1])
            {
                Button_2.Background = Brushes.Green;
                Button_5.Background = Brushes.Green;
                Button_8.Background = Brushes.Green;
                winner = board[1].ToString();
                return true;
            }
            if (board[2] != Player.blank && (board[2] & board[5] & board[8]) == board[2])
            {
                Button_3.Background = Brushes.Green;
                Button_6.Background = Brushes.Green;
                Button_9.Background = Brushes.Green;
                winner = board[2].ToString();
                return true;
            }
            if (board[0] != Player.blank && (board[0] & board[4] & board[8]) == board[0])
            {
                Button_1.Background = Brushes.Green;
                Button_5.Background = Brushes.Green;
                Button_9.Background = Brushes.Green;
                winner = board[0].ToString();
                return true;
            }
            if (board[2] != Player.blank && (board[2] & board[4] & board[6]) == board[2])
            {
                Button_3.Background = Brushes.Green;
                Button_5.Background = Brushes.Green;
                Button_7.Background = Brushes.Green;
                winner = board[2].ToString();
                return true;
            }
            return false;
        }
    }
}

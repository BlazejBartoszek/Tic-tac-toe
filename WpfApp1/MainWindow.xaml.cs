using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool IsPlayer1Turn { get; set; } = true;
        public int Counter { get; set; } = 0;
        public MainWindow()
        {
            InitializeComponent();
            NewGame();
        }

        public void NewGame()
        {
            Counter = 0;
            Button_0_0.Content = string.Empty;
            Button_1_0.Content = string.Empty;
            Button_2_0.Content = string.Empty;
            Button_0_1.Content = string.Empty;
            Button_1_1.Content = string.Empty;
            Button_2_1.Content = string.Empty;
            Button_0_2.Content = string.Empty;
            Button_1_2.Content = string.Empty;
            Button_2_2.Content = string.Empty;

            Button_0_0.Background = Brushes.White;
            Button_1_0.Background = Brushes.White;
            Button_2_0.Background = Brushes.White;
            Button_0_1.Background = Brushes.White;
            Button_1_1.Background = Brushes.White;
            Button_2_1.Background = Brushes.White;
            Button_0_2.Background = Brushes.White;
            Button_1_2.Background = Brushes.White;
            Button_2_2.Background = Brushes.White;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            Counter++;

            if (Counter > 9)
            {
                NewGame();
                return;
            }
            IsPlayer1Turn ^= true;
            button.Content = IsPlayer1Turn ? "X":"O";

            bool CheckIfPlayerWon()
            {
                if(Button_0_0.Content.ToString() != string.Empty && Button_0_0.Content == Button_0_1.Content && Button_0_1.Content == Button_0_2.Content)
                {
                    ChangeBackgroungColor(Button_0_0);
                    ChangeBackgroungColor(Button_0_1);
                    ChangeBackgroungColor(Button_0_2);                    
                    return true;
                }
                if(Button_1_0.Content.ToString() != string.Empty && Button_1_0.Content == Button_1_1.Content && Button_1_1.Content == Button_1_2.Content)
                {
                    ChangeBackgroungColor(Button_1_0);
                    ChangeBackgroungColor(Button_1_1);
                    ChangeBackgroungColor(Button_1_2);                    
                    return true;
                }
                if (Button_2_0.Content.ToString() != string.Empty && Button_2_0.Content == Button_2_1.Content && Button_2_1.Content == Button_2_2.Content)
                {
                    ChangeBackgroungColor(Button_2_0);
                    ChangeBackgroungColor(Button_2_1);
                    ChangeBackgroungColor(Button_2_2);
                    
                    return true;
                }
                if (Button_0_0.Content.ToString() != string.Empty && Button_0_0.Content == Button_1_0.Content && Button_1_0.Content == Button_2_0.Content)
                {
                    ChangeBackgroungColor(Button_0_0);
                    ChangeBackgroungColor(Button_1_0);
                    ChangeBackgroungColor(Button_2_0);
                    
                    return true;
                }
                if (Button_0_1.Content.ToString() != string.Empty && Button_0_1.Content == Button_1_1.Content && Button_1_1.Content == Button_2_1.Content)
                {
                    ChangeBackgroungColor(Button_0_1);
                    ChangeBackgroungColor(Button_1_1);
                    ChangeBackgroungColor(Button_2_1);
                    
                    return true;
                }
                if (Button_0_2.Content.ToString() != string.Empty && Button_0_2.Content == Button_1_2.Content && Button_1_2.Content == Button_2_2.Content)
                {
                    ChangeBackgroungColor(Button_0_2);
                    ChangeBackgroungColor(Button_1_2);
                    ChangeBackgroungColor(Button_2_2);
                    return true;
                }
                if (Button_0_0.Content.ToString() != string.Empty && Button_0_0.Content == Button_1_1.Content && Button_1_1.Content == Button_2_2.Content)
                {
                    ChangeBackgroungColor(Button_0_0);
                    ChangeBackgroungColor(Button_1_1);
                    ChangeBackgroungColor(Button_2_2);
                    return true;
                }
                if (Button_0_2.Content.ToString() != string.Empty && Button_0_2.Content == Button_1_1.Content && Button_1_1.Content == Button_2_0.Content)
                {
                    ChangeBackgroungColor(Button_0_2);
                    ChangeBackgroungColor(Button_1_1);
                    ChangeBackgroungColor(Button_2_0);
                    return true;
                }

               return false; 

            }

            if(CheckIfPlayerWon())
            {
                Counter = 9;
            }
            
        }
        public void ChangeBackgroungColor(Button button)
        {
            button.Background = Brushes.Orange;
        }
    }
}

using System.Windows;
using System.Windows.Controls;

namespace ChiffreSecret
{
    public partial class MainWindow : Window
    {
        int NumberOfAttempts;
        int NumberToFind;
        Random Random = new Random();
        public MainWindow()
        {
            InitializeComponent();
            PrepareButtons();
            // Va voir le menu!
        }
        void OnMenuNewGameClick(object sender, EventArgs e)
        {
        }
        private void PrepareButtons()
        {
            for (int i = 0; i < 21; i++)
            {
                Button btn = new Button();
                btn.Width = 50;
                btn.Height = 50;
                btn.Click += onBtnNumberClick;
                btn.Margin = new Thickness(37 * i, 0, 0, 0);
                btn.HorizontalAlignment = HorizontalAlignment.Left;
                btn.Content = i.ToString();
                GridButtons.Children.Add(btn);
            }
            NumberToFind = Random.Next(0, 21);
        }
        void onBtnNumberClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {

            }
        }
    }
}
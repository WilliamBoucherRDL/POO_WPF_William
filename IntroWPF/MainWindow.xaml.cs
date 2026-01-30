using System.Windows;

namespace IntroWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool onOff;

        public MainWindow()
        {
            InitializeComponent();

            tbIntro.Text = "Salut le monde!";
            tbIntro.FontSize = 120;

            // Ensuite ajouter un bouton pour changer le texte (de type toggle)
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tbIntro.Text = onOff ? "true" : "false";
            //if (onOff)
            //{
            //    onOff = false;
            //    tbIntro.Text = "on";
            //}
            //else
            //{
            //    onOff = true;
            //    tbIntro.Text = "off";
            //}
            onOff = !onOff;
            // resultat = predicat ? option 1 si cest vrai: si cest faux
            // resultat = predicat ? option 1 on : off
        }
    }
}
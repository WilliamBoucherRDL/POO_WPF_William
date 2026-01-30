using System.Windows;
using System.Windows.Controls;

namespace ListeDeNoms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int nombreNom = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        void OnEdtNomKeyDown(object sender, EventArgs e)
        {
            // Comment on ajoute un évènement en xaml?
        }

        void OnBtnAddNameClick(object sender, EventArgs e)
        {
            AddName(edtName.Text);
        }

        // Avoir un message box qui montre le nom
        void AddName(string name)
        {
            if (nombreNom == 10)
            {
                MessageBox.Show("maximum de nom");
            }
            else
            {
                MessageBox.Show(name);
                var tbNom = new TextBlock();
                tbNom.Text = name;
                tbNom.Margin = new Thickness(10, 10 * nombreNom, 10, 10);
                nombreNom++;
                gridNoms.Children.Add(tbNom);
            }

        }

        private void OnBtnAddNameClick(object sender, RoutedEventArgs e)
        {
            AddName(edtName.Text);
        }
    }
}
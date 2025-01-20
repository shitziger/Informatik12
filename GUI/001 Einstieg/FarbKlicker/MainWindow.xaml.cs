using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FarbKlicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void blauButton_Click(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.Blue;
        }

        private void rotButton_Click(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.Red;
        }

        private void gruenButton_Click(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.Green;
        }

        private void gelbButton_Click(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.Yellow;
        }

        private void grussButton_Click(object sender, RoutedEventArgs e)
        {
            // Grußtext einlesen und ausgeben
            string gruss = grussTextBox.Text;
            MessageBox.Show(gruss, "Grußkarte", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                                // ^ Einträge ab hier optional    
            
            // Grußtext löschen
            grussTextBox.Text = "";
        }
    }
}
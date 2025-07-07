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

namespace Verschluesseln
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

        private int LetterToNumber(char letter)
        {
            return char.ToUpper(letter) - 'A' + 1;
        }
        private char NumberToLetter(int number)
        {
            return (char)('A' + number - 1);
        }

        private void tbEingabe_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!this.IsLoaded)
                return;

            Start();

        }
        private void slVersatz_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (!this.IsLoaded)
                return;

            slValue.Content = NumberToLetter((int)slVersatz.Value);

            Start();

        }
        private void cbTyp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!this.IsLoaded)
                return;

            Start();
        }
        private void Start()
        {
            if (cbTyp.SelectedIndex == 0)
                Verschluesseln((int)slVersatz.Value - 1);
            else
                Entschluesseln((int)slVersatz.Value - 1);
        }

        private void Verschluesseln(int versatz)
        {
            tbAusgabe.Text = "";

            foreach (char c in tbEingabe.Text)
            {
                if (c == ' ')
                {
                    tbAusgabe.Text += " ";
                    continue;
                }

                int number = LetterToNumber(c);
                number += versatz;
                tbAusgabe.Text += NumberToLetter(number > 26 ? number - 26 : number);
            }
        }
        private void Entschluesseln(int versatz)
        {
            tbAusgabe.Text = "";

            foreach (char c in tbEingabe.Text)
            {
                if (c == ' ')
                {
                    tbAusgabe.Text += " ";
                    continue;
                }

                int number = LetterToNumber(c);
                number -= versatz;
                tbAusgabe.Text += NumberToLetter(number < 1 ? number + 26 : number);
            }
        }
    }
}
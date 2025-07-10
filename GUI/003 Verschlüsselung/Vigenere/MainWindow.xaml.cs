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
        private void tbCodeWort_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!this.IsLoaded)
                return;

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
            string codewort = tbCodeWort.Text;

            if (cbTyp.SelectedIndex == 0)
                Verschluesseln(codewort);
            else
                Entschluesseln(codewort);
        }

        private void Verschluesseln(string codewort)
        {
            tbAusgabe.Text = "";

            if (codewort == "")
            {
                tbAusgabe.Text = tbEingabe.Text;
                return;
            }

            for (int i = 0; i < tbEingabe.Text.Length; ++i)
            {
                char c = tbEingabe.Text[i];
                if (c == ' ' || c == ',' || c == '!' || c == '?' || c == '.')
                {
                    tbAusgabe.Text += c;
                    continue;
                }

                char code = codewort[i % codewort.Length];
                int versatz = LetterToNumber(code) - 1;

                int zahl = LetterToNumber(c) + versatz;
                c = NumberToLetter(zahl > 26 ? zahl - 26 : zahl);

                tbAusgabe.Text += c;

            }
        }
        private void Entschluesseln(string codewort)
        {
            tbAusgabe.Text = "";

            if (codewort == "")
            {
                tbAusgabe.Text = tbEingabe.Text;
                return;
            }

            for (int i = 0; i < tbEingabe.Text.Length; ++i)
            {
                char c = tbEingabe.Text[i];
                if (c == ' ' || c == ',' || c == '!' || c == '?' || c == '.')
                {
                    tbAusgabe.Text += c;
                    continue;
                }

                char code = codewort[i % codewort.Length];
                int versatz = LetterToNumber(code) - 1;

                int zahl = LetterToNumber(c) - versatz;
                c = NumberToLetter(zahl < 1 ? zahl + 26 : zahl);

                tbAusgabe.Text += c;

            }
        }

        
    }
}
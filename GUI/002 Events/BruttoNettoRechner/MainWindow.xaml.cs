using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

namespace BruttoNettoRechner
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Brutto einlesen
            string eingabe = tbBrutto.Text;
            double bruttoeinkommen = double.Parse(eingabe);

            // Lohnsteuer und Soli berechnen
            double lohnsteuer = BerechneLohnsteuer(bruttoeinkommen);
            lbSteuer.Content = lohnsteuer.ToString("0.00");
            double soli = BerechneSoli(lohnsteuer);
            lbSoli.Content = soli > 0.005 ? soli.ToString("0.00") : "-";
            // Wenn Soli > 0,5 cent dann anzeigen, sonst Strich

            // Sozialversicherungen
            double krankenversicherung = BerechneKrankenversicherung(bruttoeinkommen);
            lbKV.Content = krankenversicherung.ToString("0.00");
            double zusatzKV = BerechneZusatzKV(bruttoeinkommen);
            lbZB.Content = zusatzKV.ToString("0.00");
            double pflegeversicherung = BerechnePflegeversicherung(bruttoeinkommen);
            lbPV.Content = pflegeversicherung.ToString("0.00");
            double rentenversicherung = BerechneRentenversicherung(bruttoeinkommen);
            lbRV.Content = rentenversicherung.ToString("0.00");
            double arbeitslosenversicherung = BerechneArbeitslosenversicherung(bruttoeinkommen);
            lbAV.Content = krankenversicherung.ToString("0.00");

            // Kirchensteuer
            double kirchensteuer = cbKirche.IsChecked == true ? BerechneKirchensteuer(lohnsteuer) : 0;
            lbKirche.Content = cbKirche.IsChecked == true ? kirchensteuer.ToString("0.00") : "-";

            // Abzüge gesamt & Nettoeinkommen:
            double abzuege = lohnsteuer + soli + krankenversicherung + zusatzKV + pflegeversicherung + rentenversicherung + arbeitslosenversicherung + kirchensteuer;
            lbAbgaben.Content = abzuege.ToString("0.00");

            double abgabenlast = abzuege / bruttoeinkommen * 100;
            lbLast.Content = $"{abgabenlast.ToString("0.0")} %";

            double nettoeinkommen = bruttoeinkommen - abzuege;
            lbNetto.Content = nettoeinkommen.ToString("0.00");

            // Zusatzaufgabe: Farben anpassen
            double medianeinkommen = 45800;
            if (bruttoeinkommen < 0.9 * medianeinkommen)
                tbBrutto.Background = Brushes.Red;
            else if (bruttoeinkommen > 1.1 * medianeinkommen)
                tbBrutto.Background = Brushes.LightGreen;
            else
                tbBrutto.Background = Brushes.Orange;

        }
        private double BerechneLohnsteuer(double bruttoeinkommen)
        {
            if (bruttoeinkommen <= 12096)
                return 0;
            else if (bruttoeinkommen <= 17443)
                return (0.14 + (bruttoeinkommen - 12096) * 0.000009323) * (bruttoeinkommen - 12096);
            else if (bruttoeinkommen <= 68480)
                return (0.2397 + (bruttoeinkommen - 17443) * 0.0000017664) * (bruttoeinkommen - 17443) + 1015.13;
            else if (bruttoeinkommen <= 277825)
                return 0.42 * bruttoeinkommen - 10911.92;
            else
                return 0.45 * bruttoeinkommen - 19246.67;
        }
        private double BerechneSoli(double lohnsteuer)
        {
            if (lohnsteuer <= 19950)
                return 0;
            else
                return 0.055 * lohnsteuer;
        }
        private double BerechneKrankenversicherung(double bruttoeinkommen)
        {
            return 0.073 * bruttoeinkommen;
        }
        private double BerechneZusatzKV(double bruttoeinkommen)
        {
            return 0.0085 * bruttoeinkommen;
        }
        private double BerechnePflegeversicherung(double bruttoeinkommen)
        {
            return 0.034 * bruttoeinkommen;
        }
        private double BerechneRentenversicherung(double bruttoeinkommen)
        {
            return 0.093 * bruttoeinkommen;
        }
        private double BerechneArbeitslosenversicherung(double bruttoeinkommen)
        {
            return 0.073 * bruttoeinkommen;
        }
        private double BerechneKirchensteuer(double lohnsteuer)
        {
            return 0.09 * lohnsteuer;
        }
    }
}

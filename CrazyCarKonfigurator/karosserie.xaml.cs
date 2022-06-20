using System;
using System.Collections.Generic;
using System.IO;
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
using Klassenbibliothek;
using CrazyCarKonfigurator;
namespace CrazyCarKonfigurator
{
    /// <summary>
    /// Interaktionslogik für Karosserie.xaml
    /// </summary>
    public partial class karosserie : Page
    {

        public string Bezeichnung { get; internal set; }
        public float Preis { get; internal set; }
        public int Gewicht { get; internal set; }
        List<karosserie> Karosserie = new List<karosserie>();

        public karosserie()
        {
            InitializeComponent();
        }
        string[] A = new string[100];
        private void Page_Loaded(object sender, RoutedEventArgs e)

        {

            MainWindow.myMainWindow.Listauswahl(); //updates side list
            MainWindow.myMainWindow.Aktuelle_Auswahl_Liste.Visibility = Visibility.Visible; // Shows the side list


            for (int i = 0; i < CSV_Input.karosserieListe.Count; i++)
            {
                A[i] = CSV_Input.karosserieListe[i].Bezeichnung + "\n" + "Preis:" + CSV_Input.karosserieListe[i].Preis.ToString() + " €" + "\t" + "Gewicht: " +
                 CSV_Input.karosserieListe[i].Gewicht.ToString() + " g" + "\t" + "Laenge: " + CSV_Input.karosserieListe[0].Laenge + " mm"
                 + "\n" + "Breite: " + CSV_Input.karosserieListe[0].Breite + " mm" + "\t" + "Radstand: " + CSV_Input.karosserieListe[0].Radstand + " mm";
                Karosserie.Add(new karosserie { Bezeichnung = A[i], Preis = CSV_Input.karosserieListe[i].Preis, Gewicht = CSV_Input.karosserieListe[i].Gewicht });
            }

            dataGrid.ItemsSource = Karosserie; // Forwards the summary data to the DataGrid



        }
        private void button_click(object sender, RoutedEventArgs e)
        {
            int i = dataGrid.Items.IndexOf(dataGrid.CurrentItem);
            CSV_Input.summary.Add(new Zusammenfassung { Bezeichnung = A[i], Preis = CSV_Input.karosserieListe[i].Preis, Gewicht = CSV_Input.karosserieListe[i].Gewicht });
            MainWindow.myMainWindow.Listauswahl();
        }

        private void Weiter_Button_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("reifen.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);
        }
    }
}

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
    /// Interaktionslogik für motor.xaml
    /// </summary>
    public partial class akku : Page
    {

        public string Bezeichnung { get; internal set; }
        public float Preis { get; internal set; }
        public int Gewicht { get; internal set; }
        List<akku> Akku = new List<akku>();

        public akku()
        {
            InitializeComponent();
        }
        static string[] A = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
        private void Page_Loaded(object sender, RoutedEventArgs e)

        {

            MainWindow.myMainWindow.Listauswahl(); //updates side list
            MainWindow.myMainWindow.Aktuelle_Auswahl_Liste.Visibility = Visibility.Visible; // Shows the side list


            for (int i = 0; i < CSV_Input.akkuListe.Count; i++)
            {
                A[i] = CSV_Input.akkuListe[i].Bezeichnung + "\n" + "Preis: " + CSV_Input.akkuListe[i].Preis.ToString() + " €" + "\t" + "Gewicht: " +
                CSV_Input.akkuListe[i].Gewicht.ToString() + " g" + "\t" + "Spannung: " + CSV_Input.akkuListe[i].Spannung + " V" + "\n"
                + "Kapazität: " + CSV_Input.akkuListe[i].capacity + " mAh" + "\t" + "Anzahl der Zellen: " + CSV_Input.akkuListe[i].anzahlzellen + "\t" +
                "Art: " + CSV_Input.akkuListe[i].art + "\t";
                Akku.Add(new akku { Bezeichnung = A[i], Preis = CSV_Input.akkuListe[i].Preis, Gewicht = CSV_Input.akkuListe[i].Gewicht });
            }

            dataGrid.ItemsSource = Akku; // Forwards the summary data to the DataGrid



        }
        private void button_click(object sender, RoutedEventArgs e)
        {
            int i = dataGrid.Items.IndexOf(dataGrid.CurrentItem);
            CSV_Input.summary.Add(new Zusammenfassung { Bezeichnung = A[i], Preis = CSV_Input.akkuListe[i].Preis, Gewicht = CSV_Input.akkuListe[i].Gewicht });
            MainWindow.myMainWindow.Listauswahl();
        }


        private void Weiter_Button_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("servo.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);
        }
    }
}

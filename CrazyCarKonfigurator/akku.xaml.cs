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
        string[] A = new string[100];
        private void Page_Loaded(object sender, RoutedEventArgs e)

        {

            MainWindow.myMainWindow.Listauswahl(); //updates side list
            MainWindow.myMainWindow.Aktuelle_Auswahl_Liste.Visibility = Visibility.Visible; // Shows the side list


            for (int i = 0; i < CSV_Input.akkuListe.Count; i++)
            {
                A[i] = CSV_Input.akkuListe[i].Bezeichnung + "\n" + "Preis: " + CSV_Input.akkuListe[i].Preis.ToString() + " €" + "\t" + "Gewicht: " +
                CSV_Input.akkuListe[i].Gewicht.ToString() + " g" + "\t" + "Spannung: " + CSV_Input.akkuListe[i].Spannung + " V" + "\n"
                + "Kapazität: " + CSV_Input.akkuListe[i].Kapazitaet + " mAh" + "\t" + "Anzahl der Zellen: " + CSV_Input.akkuListe[i].AnzahlZellen + "\t" +
                "Art: " + CSV_Input.akkuListe[i].Art + "\t";
                Akku.Add(new akku { Bezeichnung = A[i], Preis = CSV_Input.akkuListe[i].Preis, Gewicht = CSV_Input.akkuListe[i].Gewicht });
            }

            dataGrid.ItemsSource = Akku; // Forwards the summary data to the DataGrid



        }
        private void button_click(object sender, RoutedEventArgs e)
        {
            int index0 = dataGrid.Items.IndexOf(dataGrid.CurrentItem); // Index of chosen item from list
            int index = 0; // will show the index of the item if it's already in the list
            bool found = false;
            for (int i = 0; i < CSV_Input.summary.Count; i++)
            {
                if (CSV_Input.summary[i].Bezeichnung == A[index0]) // searches for the item and gives the index if it's found
                {
                    index = i;
                    found = true; break;
                }
            }
            if (found)  // increases the quantity if the item is already in the list, otherwise it adds it to the list
            {
                CSV_Input.summary[index].Quantity += 1;
            }
            else
            {
                CSV_Input.summary.Add(new Zusammenfassung { Bezeichnung = A[index0], Preis = CSV_Input.akkuListe[index0].Preis, Gewicht = CSV_Input.akkuListe[index0].Gewicht, Quantity = 1 });
            }

            MainWindow.myMainWindow.Listauswahl(); // updates the side list.
        }


        private void Weiter_Button_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("servo.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);
        }
    }
}

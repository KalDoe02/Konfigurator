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
        public akku()
        {
            InitializeComponent();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            MainWindow.myMainWindow.Listauswahl(); //updates side list
            MainWindow.myMainWindow.Aktuelle_Auswahl_Liste.Visibility = Visibility.Visible; // Shows the side list

            string[] A = { "A", "B", "C", "D" };
            for (int i = 0; i < 4; i++)
            {
                A[i] = CSV_Input.akkuListe[i].Bezeichnung + "\n" + "Preis: " + CSV_Input.akkuListe[i].Preis.ToString() + " €" + "\t" + "Gewicht: " +
                CSV_Input.akkuListe[i].Gewicht.ToString() + " g" + "\t" + "Spannung: " + CSV_Input.akkuListe[i].Spannung + " V" + "\n"
                + "Kapazität: " + CSV_Input.akkuListe[i].capacity + " mAh" + "\t" + "Anzahl der Zellen: " + CSV_Input.akkuListe[i].anzahlzellen + "\t" +
                "Art: " + CSV_Input.akkuListe[i].art + "\t";
            }
            Akku1_Daten_Textbox.Text = A[0];
            Akku2_Daten_Textbox.Text = A[1];
            Akku3_Daten_Textbox.Text = A[2];
            Akku4_Daten_Textbox.Text = A[3];
        }
        private void Akku1_Button_Click(object sender, RoutedEventArgs e)
        {
            CSV_Input.summary.Add(new Zusammenfassung { Bezeichnung = CSV_Input.akkuListe[0].Bezeichnung, Preis = CSV_Input.akkuListe[0].Preis, Gewicht = CSV_Input.akkuListe[0].Gewicht });
            MainWindow.myMainWindow.Listauswahl();
        }
        private void Akku2_Button_Click(object sender, RoutedEventArgs e)
        {
            CSV_Input.summary.Add(new Zusammenfassung { Bezeichnung = CSV_Input.akkuListe[1].Bezeichnung, Preis = CSV_Input.akkuListe[1].Preis, Gewicht = CSV_Input.akkuListe[1].Gewicht });
            MainWindow.myMainWindow.Listauswahl();

        }
        private void Akku3_Button_Click(object sender, RoutedEventArgs e)
        {
            CSV_Input.summary.Add(new Zusammenfassung { Bezeichnung = CSV_Input.akkuListe[2].Bezeichnung, Preis = CSV_Input.akkuListe[2].Preis, Gewicht = CSV_Input.akkuListe[2].Gewicht });
            MainWindow.myMainWindow.Listauswahl();

        }
        private void Akku4_Button_Click(object sender, RoutedEventArgs e)
        {
            CSV_Input.summary.Add(new Zusammenfassung { Bezeichnung = CSV_Input.akkuListe[3].Bezeichnung, Preis = CSV_Input.akkuListe[3].Preis, Gewicht = CSV_Input.akkuListe[3].Gewicht });
            MainWindow.myMainWindow.Listauswahl();

        }

        private void Weiter_Button_Click(object sender, RoutedEventArgs e)
        {
            // FrameWithinGrid.Navigate(new System.Uri("sensor.xaml", UriKind.RelativeOrAbsolute));
        }


    }
}

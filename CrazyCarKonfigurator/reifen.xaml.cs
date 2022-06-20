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
    public partial class reifen : Page
    {
        public reifen()
        {
            InitializeComponent();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            MainWindow.myMainWindow.Listauswahl(); //updates side list
            MainWindow.myMainWindow.Aktuelle_Auswahl_Liste.Visibility = Visibility.Visible; // Shows the side list
            //Testname = Controller1_Textbox.Text;
            string[] A = { "A", "B", "C", "D" };
            for (int i = 0; i < 4; i++)
            {
                A[i] = CSV_Input.reifenListe[i].Bezeichnung + "\n" + "Preis:" + CSV_Input.reifenListe[i].Preis.ToString() + " €" + "\t" + "Gewicht: " +
                CSV_Input.reifenListe[i].Gewicht.ToString() + " g" + "\t" + "Durchmesser: " + CSV_Input.reifenListe[1].Durchmesser + " mm"
                + "\n" + "Breite: " + CSV_Input.reifenListe[i].Breite + " mm" + "\t" + "Farbe: " + CSV_Input.reifenListe[i].Farbe;
            }
            Reifen1_Daten_Textbox.Text = A[0];
            Reifen2_Daten_Textbox.Text = A[1];
            Reifen3_Daten_Textbox.Text = A[2];
            Reifen4_Daten_Textbox.Text = A[3];

        }


        private void Reifen1_Button_Click(object sender, RoutedEventArgs e)
        {
            CSV_Input.summary.Add(new Zusammenfassung { Bezeichnung = CSV_Input.reifenListe[0].Bezeichnung, Preis = CSV_Input.reifenListe[0].Preis, Gewicht = CSV_Input.reifenListe[0].Gewicht });
            MainWindow.myMainWindow.Listauswahl();
        }
        private void Reifen2_Button_Click(object sender, RoutedEventArgs e)
        {
            CSV_Input.summary.Add(new Zusammenfassung { Bezeichnung = CSV_Input.reifenListe[1].Bezeichnung, Preis = CSV_Input.reifenListe[1].Preis, Gewicht = CSV_Input.reifenListe[1].Gewicht });
            MainWindow.myMainWindow.Listauswahl();

        }
        private void Reifen3_Button_Click(object sender, RoutedEventArgs e)
        {
            CSV_Input.summary.Add(new Zusammenfassung { Bezeichnung = CSV_Input.reifenListe[2].Bezeichnung, Preis = CSV_Input.reifenListe[2].Preis, Gewicht = CSV_Input.reifenListe[2].Gewicht });
            MainWindow.myMainWindow.Listauswahl();

        }
        private void Reifen4_Button_Click(object sender, RoutedEventArgs e)
        {
            CSV_Input.summary.Add(new Zusammenfassung { Bezeichnung = CSV_Input.reifenListe[3].Bezeichnung, Preis = CSV_Input.reifenListe[3].Preis, Gewicht = CSV_Input.reifenListe[3].Gewicht });
            MainWindow.myMainWindow.Listauswahl();

        }

        private void Weiter_Button_Click(object sender, RoutedEventArgs e)
        {
            // FrameWithinGrid.Navigate(new System.Uri("sensor.xaml", UriKind.RelativeOrAbsolute));
        }


    }
}

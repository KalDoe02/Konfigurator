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
    /// Interaktionslogik für sensor.xaml
    /// </summary>
    public partial class sensor : Page
    {
        public sensor()
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
                A[i] = CSV_Input.sensorListe[i].Bezeichnung + "\n" + "Preis: " + CSV_Input.sensorListe[i].Preis.ToString() + " €" + "\t" + "\t" + "Gewicht: " +
                CSV_Input.sensorListe[i].Gewicht.ToString() + " g" + "\t" + "Reichweite: " + CSV_Input.sensorListe[i].Reichweite +
                "\n" + "Sensorart: " + CSV_Input.sensorListe[i].Sensorart;
            }
            Sensor1_Daten_Textbox.Text = A[0];
            Sensor2_Daten_Textbox.Text = A[1];
            Sensor3_Daten_Textbox.Text = A[2];
            Sensor4_Daten_Textbox.Text = A[3];

        }
        private void Sensor1_Button_Click(object sender, RoutedEventArgs e)
        {
            CSV_Input.summary.Add(new Zusammenfassung { Bezeichnung = CSV_Input.sensorListe[0].Bezeichnung, Preis = CSV_Input.sensorListe[0].Preis, Gewicht = CSV_Input.sensorListe[0].Gewicht });
            MainWindow.myMainWindow.Listauswahl();
        }
        private void Sensor2_Button_Click(object sender, RoutedEventArgs e)
        {
            CSV_Input.summary.Add(new Zusammenfassung { Bezeichnung = CSV_Input.sensorListe[1].Bezeichnung, Preis = CSV_Input.sensorListe[1].Preis, Gewicht = CSV_Input.sensorListe[1].Gewicht });
            MainWindow.myMainWindow.Listauswahl();

        }
        private void Sensor3_Button_Click(object sender, RoutedEventArgs e)
        {
            CSV_Input.summary.Add(new Zusammenfassung { Bezeichnung = CSV_Input.sensorListe[2].Bezeichnung, Preis = CSV_Input.sensorListe[2].Preis, Gewicht = CSV_Input.sensorListe[2].Gewicht });
            MainWindow.myMainWindow.Listauswahl();

        }
        private void Sensor4_Button_Click(object sender, RoutedEventArgs e)
        {
            CSV_Input.summary.Add(new Zusammenfassung { Bezeichnung = CSV_Input.sensorListe[3].Bezeichnung, Preis = CSV_Input.sensorListe[3].Preis, Gewicht = CSV_Input.sensorListe[3].Gewicht });
            MainWindow.myMainWindow.Listauswahl();

        }

        private void Weiter_Button_Click(object sender, RoutedEventArgs e)
        {
            // FrameWithinGrid.Navigate(new System.Uri("sensor.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}

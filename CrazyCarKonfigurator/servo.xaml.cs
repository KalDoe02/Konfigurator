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
    /// Interaktionslogik für servo.xaml
    /// </summary>
    public partial class servo : Page
    {
        public servo()
        {
            InitializeComponent();
        }
        string[] A = { "A", "B", "C", "D" };

        private void Page_Loaded(object sender, RoutedEventArgs e)

        {
            MainWindow.myMainWindow.Listauswahl(); //updates side list
            MainWindow.myMainWindow.Aktuelle_Auswahl_Liste.Visibility = Visibility.Visible; // Shows the side list
            for (int i = 0; i < 4; i++)
            {
                A[i] = CSV_Input.servoListe[i].Bezeichnung + "\n" + "Preis: " + CSV_Input.servoListe[i].Preis.ToString() + " €" + "\t" + "Gewicht: " +
                CSV_Input.servoListe[i].Gewicht.ToString() + " g"+ "\t" + "Stellzeit: " + CSV_Input.servoListe[i].Stellzeit + " s" +
                "\n" + "Drehmoment: " + CSV_Input.servoListe[0].Drehmoment + " kg/cm";
            }
            Servo1_Daten_Textbox.Text = A[0];
            Servo2_Daten_Textbox.Text = A[1];
            Servo3_Daten_Textbox.Text = A[2];
            Servo4_Daten_Textbox.Text = A[3];
    

        }


        private void Servo1_Button_Click(object sender, RoutedEventArgs e)
        {
            CSV_Input.summary.Add(new Zusammenfassung { Bezeichnung = A[0], Preis = CSV_Input.servoListe[0].Preis, Gewicht = CSV_Input.servoListe[0].Gewicht });
            MainWindow.myMainWindow.Listauswahl();
        }
        private void Servo2_Button_Click(object sender, RoutedEventArgs e)
        {
            CSV_Input.summary.Add(new Zusammenfassung { Bezeichnung = A[1], Preis = CSV_Input.servoListe[1].Preis, Gewicht = CSV_Input.servoListe[1].Gewicht });
            MainWindow.myMainWindow.Listauswahl();

        }
        private void Servo3_Button_Click(object sender, RoutedEventArgs e)
        {
            CSV_Input.summary.Add(new Zusammenfassung { Bezeichnung = A[2], Preis = CSV_Input.servoListe[2].Preis, Gewicht = CSV_Input.servoListe[2].Gewicht });
            MainWindow.myMainWindow.Listauswahl();

        }
        private void Servo4_Button_Click(object sender, RoutedEventArgs e)
        {
            CSV_Input.summary.Add(new Zusammenfassung { Bezeichnung = A[3], Preis = CSV_Input.servoListe[3].Preis, Gewicht = CSV_Input.servoListe[3].Gewicht });
            MainWindow.myMainWindow.Listauswahl();

        }

        private void Weiter_Button_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("karosserie.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);
        }
    }
}

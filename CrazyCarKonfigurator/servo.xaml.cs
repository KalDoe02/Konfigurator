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
        private void Page_Loaded(object sender, RoutedEventArgs e)

        {
            string[] A = { "A", "B", "C", "D" };
            for (int i = 0; i < 4; i++)
            {
                A[i] = CSV_Input.servoListe[0].Bezeichnung + "\n" + "Preis: " + CSV_Input.servoListe[0].Preis.ToString() + " €" + "\t" + "Gewicht: " +
                CSV_Input.servoListe[0].Gewicht.ToString() + " g"+ "\t" + "Stellzeit: " + CSV_Input.servoListe[0].Stellzeit + " s" +
                "\n" + "Drehmoment: " + CSV_Input.servoListe[0].Drehmoment + " kg/cm";
            }
            Servo1_Daten_Textbox.Text = A[0];
            Servo2_Daten_Textbox.Text = A[1];
            Servo3_Daten_Textbox.Text = A[2];
            Servo4_Daten_Textbox.Text = A[3];
    

        }


        private void Servo1_Button_Click(object sender, RoutedEventArgs e)
        {
            CSV_Input.summary.Add(new Zusammenfassung { Bezeichnung = CSV_Input.servoListe[0].Bezeichnung, Preis = CSV_Input.servoListe[0].Preis, Gewicht = CSV_Input.servoListe[0].Gewicht });

        }
        private void Servo2_Button_Click(object sender, RoutedEventArgs e)
        {
            CSV_Input.summary.Add(new Zusammenfassung { Bezeichnung = CSV_Input.servoListe[1].Bezeichnung, Preis = CSV_Input.servoListe[1].Preis, Gewicht = CSV_Input.servoListe[1].Gewicht });


        }
        private void Servo3_Button_Click(object sender, RoutedEventArgs e)
        {
            CSV_Input.summary.Add(new Zusammenfassung { Bezeichnung = CSV_Input.servoListe[2].Bezeichnung, Preis = CSV_Input.servoListe[2].Preis, Gewicht = CSV_Input.servoListe[2].Gewicht });


        }
        private void Servo4_Button_Click(object sender, RoutedEventArgs e)
        {
            CSV_Input.summary.Add(new Zusammenfassung { Bezeichnung = CSV_Input.servoListe[3].Bezeichnung, Preis = CSV_Input.servoListe[3].Preis, Gewicht = CSV_Input.servoListe[3].Gewicht });


        }

        private void Weiter_Button_Click(object sender, RoutedEventArgs e)
        {
            // FrameWithinGrid.Navigate(new System.Uri("sensor.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}

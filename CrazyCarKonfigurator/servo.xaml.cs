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
            //Testname = Controller1_Textbox.Text;
            CSV_Input i = new CSV_Input();
            Servo1_Name_Textbox.Text = i.servoListe[0].Bezeichnung;
            Servo1_Daten_Textbox.Text = "Preis: " + i.servoListe[0].Preis.ToString() + " €" + "\t" + "Gewicht: " +
                                                        i.servoListe[0].Gewicht.ToString() + " g";
            Servo1_Daten_Textbox.Text += "\t" + "Stellzeit: " + i.servoListe[0].Stellzeit+ " s";
            Servo1_Daten_Textbox.Text += "\n";
            Servo1_Daten_Textbox.Text += "Drehmoment: " + i.servoListe[0].Drehmoment + " kg/cm";

        }


        private void Motor1_Button_Click(object sender, RoutedEventArgs e)
        {
            //var c 
        }

        private void Weiter_Button_Click(object sender, RoutedEventArgs e)
        {
            // FrameWithinGrid.Navigate(new System.Uri("sensor.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}

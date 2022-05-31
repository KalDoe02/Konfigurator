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
            //Testname = Controller1_Textbox.Text;
            CSV_Input i = new CSV_Input();
            Sensor1_Name_Textbox.Text = i.sensorListe[0].Bezeichnung;
            Sensor1_Daten_Textbox.Text = "Preis: " + i.sensorListe[0].Preis.ToString() + " €" + "\t" + "\t" + "Gewicht: " +
                                                         i.sensorListe[0].Gewicht.ToString() + " g";
            Sensor1_Daten_Textbox.Text += "\t" + "Reichweite: " + i.sensorListe[0].Reichweite;
            Sensor1_Daten_Textbox.Text += "\n";
            Sensor1_Daten_Textbox.Text += "Sensorart: " + i.sensorListe[0].Sensorart;


            //
            Sensor2_Name_Textbox.Text = i.sensorListe[1].Bezeichnung;
            Sensor2_Daten_Textbox.Text = "Preis: " + i.sensorListe[1].Preis.ToString() + " €" + "\t" + "\t" + "Gewicht: " +
                                                 i.sensorListe[1].Gewicht.ToString() + " g";

            Sensor2_Daten_Textbox.Text += "\t" + "Reichweite: " + i.sensorListe[1].Reichweite;
            Sensor2_Daten_Textbox.Text += "\n";
            Sensor2_Daten_Textbox.Text += "Sensorart: " + i.sensorListe[1].Sensorart;

            Sensor3_Name_Textbox.Text = i.sensorListe[2].Bezeichnung;
            Sensor3_Daten_Textbox.Text = "Preis: " + i.sensorListe[2].Preis.ToString() + " €" + "\t" + "\t" + "Gewicht: " +
                                     i.sensorListe[2].Gewicht.ToString() + " g";
            Sensor3_Daten_Textbox.Text += "\t" + "Reichweite: " + i.sensorListe[2].Reichweite;
            Sensor3_Daten_Textbox.Text += "\n";
            Sensor3_Daten_Textbox.Text += "Sensorart: " + i.sensorListe[2].Sensorart;


            Sensor4_Name_Textbox.Text = i.sensorListe[3].Bezeichnung;
            Sensor4_Daten_Textbox.Text = "Preis: " + i.sensorListe[3].Preis.ToString() + " €" + "\t" + "\t" + "Gewicht: " +
                                     i.sensorListe[3].Gewicht.ToString() + " g";
            Sensor4_Daten_Textbox.Text += "\t" + "Reichweite: " + i.sensorListe[3].Reichweite;
            Sensor4_Daten_Textbox.Text += "\n";
            Sensor4_Daten_Textbox.Text += "Sensorart: " + i.sensorListe[3].Sensorart;

        }
        private void Sensor1_Button_Click(object sender, RoutedEventArgs e)
        {
            //var c 
        }

        private void Weiter_Button_Click(object sender, RoutedEventArgs e)
        {
            // FrameWithinGrid.Navigate(new System.Uri("sensor.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}

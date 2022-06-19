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
            string[] A = { "A", "B", "C", "D" };
            for (int i = 0; i < 4; i++)
            {
                A[i] = CSV_Input.sensorListe[0].Bezeichnung + "\n" + "Preis: " + CSV_Input.sensorListe[0].Preis.ToString() + " €" + "\t" + "\t" + "Gewicht: " +
                CSV_Input.sensorListe[0].Gewicht.ToString() + " g" + "\t" + "Reichweite: " + CSV_Input.sensorListe[0].Reichweite +
                "\n" + "Sensorart: " + CSV_Input.sensorListe[0].Sensorart;
            }
            Sensor1_Daten_Textbox.Text = A[0];
            Sensor2_Daten_Textbox.Text = A[1];
            Sensor3_Daten_Textbox.Text = A[2];
            Sensor4_Daten_Textbox.Text = A[3];

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

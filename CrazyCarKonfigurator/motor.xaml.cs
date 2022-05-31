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
    public partial class motor : Page
    {
        public motor()
        {
            InitializeComponent();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //Testname = Controller1_Textbox.Text;
            CSV_Input i = new CSV_Input();
            Motor1_Name_Textbox.Text = i.motorListe[0].Bezeichnung;
            Motor1_Daten_Textbox.Text = "Preis: " + i.motorListe[0].Preis.ToString() + " €" + "\t" + "Gewicht: " +
                                                        i.motorListe[0].Gewicht.ToString() + " g";
            Motor1_Daten_Textbox.Text += "\t" + "Nenndrehzahl: " + i.motorListe[0].Nenndrehzahl+ " U/Min";
            Motor1_Daten_Textbox.Text += "\n";
            Motor1_Daten_Textbox.Text += "Stromaufnahme: " + i.motorListe[0].Stromaufnahme + " A";

            Motor2_Name_Textbox.Text = i.motorListe[1].Bezeichnung;
            Motor2_Daten_Textbox.Text = "Preis: " + i.motorListe[1].Preis.ToString() + " €" + "\t" + "Gewicht: " +
                                                        i.motorListe[0].Gewicht.ToString() + " g";
            Motor2_Daten_Textbox.Text += "\t" + "Nenndrehzahl: " + i.motorListe[1].Nenndrehzahl + " U/Min";
            Motor2_Daten_Textbox.Text += "\n";
            Motor2_Daten_Textbox.Text += "Stromaufnahme: " + i.motorListe[1].Stromaufnahme + " A";

            Motor3_Name_Textbox.Text = i.motorListe[2].Bezeichnung;
            Motor3_Daten_Textbox.Text = "Preis: " + i.motorListe[2].Preis.ToString() + " €" + "\t" + "Gewicht: " +
                                                        i.motorListe[2].Gewicht.ToString() + " g";
            Motor3_Daten_Textbox.Text += "\t" + "Nenndrehzahl: " + i.motorListe[2].Nenndrehzahl + " U/Min";
            Motor3_Daten_Textbox.Text += "\n";
            Motor3_Daten_Textbox.Text += "Stromaufnahme: " + i.motorListe[2].Stromaufnahme + " A";

            Motor4_Name_Textbox.Text = i.motorListe[3].Bezeichnung;
            Motor4_Daten_Textbox.Text = "Preis: " + i.motorListe[3].Preis.ToString() + " €" + "\t" + "Gewicht: " +
                                                        i.motorListe[3].Gewicht.ToString() + " g";
            Motor4_Daten_Textbox.Text += "\t" + "Nenndrehzahl: " + i.motorListe[3].Nenndrehzahl + " U/Min";
            Motor4_Daten_Textbox.Text += "\n";
            Motor4_Daten_Textbox.Text += "Stromaufnahme: " + i.motorListe[3].Stromaufnahme + " A";
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

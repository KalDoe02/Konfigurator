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
    /// Interaktionslogik für controller.xaml
    /// </summary>
    ///


    public partial class controller : Page
    {
        public controller()
        {
            InitializeComponent();
            //Controller1_Name_Textbox.Text = Controller[2];



        }


        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //Testname = Controller1_Textbox.Text;
            CSV_Input i = new CSV_Input();

            Controller1_Name_Textbox.Text = i.controllerListe[0].Bezeichnung;
            Controller1_Daten_Textbox.Text = "Preis: " + i.controllerListe[0].Preis.ToString() + " €" + "\t" + "\t" + "Gewicht: " +
                                             i.controllerListe[0].Gewicht.ToString() + " g";
            if (i.controllerListe[0].UART){
                Controller1_Daten_Textbox.Text += "\t" + "UART Schnittstelle ";
            }
            Controller1_Daten_Textbox.Text += "\n";

            Controller1_Daten_Textbox.Text += "Taktrate: " + i.controllerListe[0].Taktrate.ToString() + " Hz" + "\t" + "Pin Anzahl: " +
                                             i.controllerListe[0].PinAnzahl.ToString();
            if (i.controllerListe[0].I2C){
                Controller1_Daten_Textbox.Text += "\t" + "I2C Schnittstelle ";
            }


            Controller2_Name_Textbox.Text = i.controllerListe[1].Bezeichnung;
            Controller2_Daten_Textbox.Text = "Preis: " + i.controllerListe[1].Preis.ToString() + " €" + "\t" + "\t" + "Gewicht: " +
                                             i.controllerListe[1].Gewicht.ToString() + " g";
            if (i.controllerListe[1].UART)
            {
                Controller2_Daten_Textbox.Text += "\t" + "UART Schnittstelle ";
            }
            Controller2_Daten_Textbox.Text += "\n";

            Controller2_Daten_Textbox.Text += "Taktrate: " + i.controllerListe[1].Taktrate.ToString() + " Hz" + "\t" + "Pin Anzahl: " +
                                             i.controllerListe[1].PinAnzahl.ToString();
            if (i.controllerListe[1].I2C)
            {
                Controller2_Daten_Textbox.Text += "\t" + "I2C Schnittstelle ";
            }

            Controller3_Name_Textbox.Text = i.controllerListe[2].Bezeichnung;
            Controller3_Daten_Textbox.Text = "Preis: " + i.controllerListe[2].Preis.ToString() + " €" + "\t" + "\t" + "Gewicht: " +
                                             i.controllerListe[2].Gewicht.ToString() + " g";
            if (i.controllerListe[2].UART)
            {
                Controller3_Daten_Textbox.Text += "\t" + "UART Schnittstelle ";
            }
            Controller3_Daten_Textbox.Text += "\n";

            Controller3_Daten_Textbox.Text += "Taktrate: " + i.controllerListe[2].Taktrate.ToString() + " Hz" + "\t" + "Pin Anzahl: " +
                                             i.controllerListe[2].PinAnzahl.ToString();
            if (i.controllerListe[2].I2C)
            {
                Controller3_Daten_Textbox.Text += "\t" + "I2C Schnittstelle ";
            }

            Controller4_Name_Textbox.Text = i.controllerListe[3].Bezeichnung;
            Controller4_Daten_Textbox.Text = "Preis: " + i.controllerListe[3].Preis.ToString() + " €" + "\t" + "\t" + "Gewicht: " +
                                             i.controllerListe[3].Gewicht.ToString() + " g";
            if (i.controllerListe[3].UART)
            {
                Controller4_Daten_Textbox.Text += "\t" + "UART Schnittstelle ";
            }
            Controller4_Daten_Textbox.Text += "\n";

            Controller4_Daten_Textbox.Text += "Taktrate: " + i.controllerListe[3].Taktrate.ToString() + " Hz" + "\t" + "Pin Anzahl: " +
                                             i.controllerListe[3].PinAnzahl.ToString();
            if (i.controllerListe[3].I2C)
            {
                Controller4_Daten_Textbox.Text += "\t" + "I2C Schnittstelle ";
            }

        }

        private void Controller1_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Weiter_Button_Click(object sender, RoutedEventArgs e)
        {
           // FrameWithinGrid.Navigate(new System.Uri("sensor.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}

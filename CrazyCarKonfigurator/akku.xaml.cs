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
            //Testname = Controller1_Textbox.Text;
            CSV_Input i = new CSV_Input();
            Akku1_Name_Textbox.Text = i.akkuListe[0].Bezeichnung;
            Akku1_Daten_Textbox.Text = "Preis: " + i.akkuListe[0].Preis.ToString() + " €" + "\t" + "Gewicht: " +
                                                        i.akkuListe[0].Gewicht.ToString() + " g";
            Akku1_Daten_Textbox.Text += "\t" + "Spannung: " + i.akkuListe[0].Spannung + " V";
            Akku1_Daten_Textbox.Text += "\n";
            Akku1_Daten_Textbox.Text += "Kapazität: " + i.akkuListe[0].capacity + " mAh" + "\t";
            Akku1_Daten_Textbox.Text += "Anzahl der Zellen: " + i.akkuListe[0].anzahlzellen + "\t";
            Akku1_Daten_Textbox.Text += "Art: " + i.akkuListe[0].art + "\t";

            Akku2_Name_Textbox.Text = i.akkuListe[1].Bezeichnung;
            Akku2_Daten_Textbox.Text = "Preis: " + i.akkuListe[1].Preis.ToString() + " €" + "\t" + "Gewicht: " +
                                                        i.akkuListe[1].Gewicht.ToString() + " g";
            Akku2_Daten_Textbox.Text += "\t" + "Spannung: " + i.akkuListe[1].Spannung + " V";
            Akku2_Daten_Textbox.Text += "\n";
            Akku2_Daten_Textbox.Text += "Kapazität: " + i.akkuListe[1].capacity + " mAh" + "\t";
            Akku2_Daten_Textbox.Text += "Anzahl der Zellen: " + i.akkuListe[1].anzahlzellen + "\t";
            Akku2_Daten_Textbox.Text += "Art: " + i.akkuListe[1].art + "\t";

            Akku3_Name_Textbox.Text = i.akkuListe[2].Bezeichnung;
            Akku3_Daten_Textbox.Text = "Preis: " + i.akkuListe[2].Preis.ToString() + " €" + "\t" + "Gewicht: " +
                                                        i.akkuListe[2].Gewicht.ToString() + " g";
            Akku3_Daten_Textbox.Text += "\t" + "Spannung: " + i.akkuListe[2].Spannung + " V";
            Akku3_Daten_Textbox.Text += "\n";
            Akku3_Daten_Textbox.Text += "Kapazität: " + i.akkuListe[2].capacity + " mAh" + "\t";
            Akku3_Daten_Textbox.Text += "Anzahl der Zellen: " + i.akkuListe[2].anzahlzellen + "\t";
            Akku3_Daten_Textbox.Text += "Art: " + i.akkuListe[2].art + "\t";

            Akku4_Name_Textbox.Text = i.akkuListe[3].Bezeichnung;
            Akku4_Daten_Textbox.Text = "Preis: " + i.akkuListe[3].Preis.ToString() + " €" + "\t" + "Gewicht: " +
                                                        i.akkuListe[3].Gewicht.ToString() + " g";
            Akku4_Daten_Textbox.Text += "\t" + "Spannung: " + i.akkuListe[3].Spannung + " V";
            Akku4_Daten_Textbox.Text += "\n";
            Akku4_Daten_Textbox.Text += "Kapazität: " + i.akkuListe[3].capacity + " mAh" + "\t";
            Akku4_Daten_Textbox.Text += "Anzahl der Zellen: " + i.akkuListe[3].anzahlzellen + "\t";
            Akku4_Daten_Textbox.Text += "Art: " + i.akkuListe[3].art + "\t";




        }


        private void Akku1_Button_Click(object sender, RoutedEventArgs e)
        {
            //var c 
        }

        private void Weiter_Button_Click(object sender, RoutedEventArgs e)
        {
            // FrameWithinGrid.Navigate(new System.Uri("sensor.xaml", UriKind.RelativeOrAbsolute));
        }


    }
}

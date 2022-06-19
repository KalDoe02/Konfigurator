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
    /// Interaktionslogik für Karosserie.xaml
    /// </summary>
    public partial class karosserie : Page
    {
        public karosserie()
        {
            InitializeComponent();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //Testname = Controller1_Textbox.Text;
            string[] A = { "A", "B", "C", "D" };
            for (int i = 0; i < 4; i++)
            {
                A[i] = CSV_Input.karosserieListe[i].Bezeichnung + "\n" + "Preis:" + CSV_Input.karosserieListe[i].Preis.ToString() + " €" + "\t" + "Gewicht: " +
                CSV_Input.karosserieListe[i].Gewicht.ToString() + " g" + "\t" + "Laenge: " + CSV_Input.karosserieListe[0].Laenge + " mm"
                + "\n" + "Breite: " + CSV_Input.karosserieListe[0].Breite + " mm" +"\t" + "Radstand: " + CSV_Input.karosserieListe[0].Radstand + " mm";
            }
            Karosserie1_Daten_Textbox.Text = A[0];
            Karosserie2_Daten_Textbox.Text = A[1];
            Karosserie3_Daten_Textbox.Text = A[2];
            Karosserie4_Daten_Textbox.Text = A[3];



        }


        private void Karosserie1_Button_Click(object sender, RoutedEventArgs e)
        {
            CSV_Input.summary.Add(new Zusammenfassung { Bezeichnung = CSV_Input.karosserieListe[0].Bezeichnung, Preis = CSV_Input.karosserieListe[0].Preis, Gewicht = CSV_Input.karosserieListe[0].Gewicht });

        }
        private void Karosserie2_Button_Click(object sender, RoutedEventArgs e)
        {
            CSV_Input.summary.Add(new Zusammenfassung { Bezeichnung = CSV_Input.karosserieListe[1].Bezeichnung, Preis = CSV_Input.karosserieListe[1].Preis, Gewicht = CSV_Input.karosserieListe[1].Gewicht });


        }
        private void Karosserie3_Button_Click(object sender, RoutedEventArgs e)
        {
            CSV_Input.summary.Add(new Zusammenfassung { Bezeichnung = CSV_Input.karosserieListe[2].Bezeichnung, Preis = CSV_Input.karosserieListe[2].Preis, Gewicht = CSV_Input.karosserieListe[2].Gewicht });


        }
        private void Karosserie4_Button_Click(object sender, RoutedEventArgs e)
        {
            CSV_Input.summary.Add(new Zusammenfassung { Bezeichnung = CSV_Input.karosserieListe[3].Bezeichnung, Preis = CSV_Input.karosserieListe[3].Preis, Gewicht = CSV_Input.karosserieListe[3].Gewicht });


        }

        private void Weiter_Button_Click(object sender, RoutedEventArgs e)
        {
            // FrameWithinGrid.Navigate(new System.Uri("sensor.xaml", UriKind.RelativeOrAbsolute));
        }


    }
}

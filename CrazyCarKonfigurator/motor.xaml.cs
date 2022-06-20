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
        string[] A = { "A", "B", "C", "D" };

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            MainWindow.myMainWindow.Listauswahl(); //updates side list
            MainWindow.myMainWindow.Aktuelle_Auswahl_Liste.Visibility = Visibility.Visible; // Shows the side list

            //Testname = Controller1_Textbox.Text;
            for (int i = 0; i < 4; i++)
            {
                A[i]= CSV_Input.motorListe[i].Bezeichnung + "\n" + "Preis:" + CSV_Input.motorListe[i].Preis.ToString() + " €" + "\t" + "Gewicht: " +
                CSV_Input.motorListe[i].Gewicht.ToString() + " g"+ "\t" + "Nenndrehzahl: " + CSV_Input.motorListe[0].Nenndrehzahl + " U/Min"
                + "\n" + "Stromaufnahme: " + CSV_Input.motorListe[0].Stromaufnahme + " A";
            }
            Motor1_Daten_Textbox.Text = A[0];
            Motor2_Daten_Textbox.Text = A[1];
            Motor3_Daten_Textbox.Text = A[2];
            Motor4_Daten_Textbox.Text = A[3];



        }


        private void Motor1_Button_Click(object sender, RoutedEventArgs e)
        {
            CSV_Input.summary.Add(new Zusammenfassung { Bezeichnung = A[0], Preis = CSV_Input.motorListe[0].Preis, Gewicht = CSV_Input.motorListe[0].Gewicht });
            MainWindow.myMainWindow.Listauswahl();
        }
        private void Motor2_Button_Click(object sender, RoutedEventArgs e)
        {
            CSV_Input.summary.Add(new Zusammenfassung { Bezeichnung = A[1], Preis = CSV_Input.motorListe[1].Preis, Gewicht = CSV_Input.motorListe[1].Gewicht });
            MainWindow.myMainWindow.Listauswahl();

        }
        private void Motor3_Button_Click(object sender, RoutedEventArgs e)
        {
            CSV_Input.summary.Add(new Zusammenfassung { Bezeichnung = A[2], Preis = CSV_Input.motorListe[2].Preis, Gewicht = CSV_Input.motorListe[2].Gewicht });
            MainWindow.myMainWindow.Listauswahl();

        }
        private void Motor4_Button_Click(object sender, RoutedEventArgs e)
        {
            CSV_Input.summary.Add(new Zusammenfassung { Bezeichnung = A[3], Preis = CSV_Input.motorListe[3].Preis, Gewicht = CSV_Input.motorListe[3].Gewicht });
            MainWindow.myMainWindow.Listauswahl();

        }

        private void Weiter_Button_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("akku.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);
        }


    }
}

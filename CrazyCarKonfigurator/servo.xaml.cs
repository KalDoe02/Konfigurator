using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Data;
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
using System.Web;
using System.Windows.Controls.Primitives;
using Klassenbibliothek;
using CrazyCarKonfigurator;


namespace CrazyCarKonfigurator
{

    /// <summary>
    /// Interaktionslogik für servo.xaml
    /// </summary>
    public partial class servo : Page
    {
        public string Bezeichnung { get; internal set; }
        public float Preis { get; internal set; }
        public int Gewicht { get; internal set; }
        List<servo> Servo = new List<servo>();

        public servo()
        {
            InitializeComponent();
        }
        static string[] A = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
        private void Page_Loaded(object sender, RoutedEventArgs e)

        {

            MainWindow.myMainWindow.Listauswahl(); //updates side list
            MainWindow.myMainWindow.Aktuelle_Auswahl_Liste.Visibility = Visibility.Visible; // Shows the side list


            for (int i = 0; i < CSV_Input.servoListe.Count; i++)
            {
                A[i] = CSV_Input.servoListe[i].Bezeichnung + "\n" + "Preis: " + CSV_Input.servoListe[i].Preis.ToString() + " €" + "\t" + "Gewicht: " +
                CSV_Input.servoListe[i].Gewicht.ToString() + " g" + "\t" + "Stellzeit: " + CSV_Input.servoListe[i].Stellzeit + " s" +
                "\n" + "Drehmoment: " + CSV_Input.servoListe[0].Drehmoment + " kg/cm";
                Servo.Add(new servo { Bezeichnung = A[i], Preis = CSV_Input.servoListe[i].Preis, Gewicht = CSV_Input.servoListe[i].Gewicht });
            }

            dataGrid.ItemsSource = Servo; // Forwards the summary data to the DataGrid



        }
        private void button_click(object sender, RoutedEventArgs e)
        {
            int i = dataGrid.Items.IndexOf(dataGrid.CurrentItem);
            CSV_Input.summary.Add(new Zusammenfassung { Bezeichnung = A[i], Preis = CSV_Input.servoListe[i].Preis, Gewicht = CSV_Input.servoListe[i].Gewicht });
            MainWindow.myMainWindow.Listauswahl();
        }


        private void Weiter_Button_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("karosserie.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);
        }
    }
}

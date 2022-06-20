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

        public string Bezeichnung { get; internal set; }
        public float Preis { get; internal set; }
        public int Gewicht { get; internal set; }
        List<controller> Controller = new List<controller>();

        public controller()
        {
            InitializeComponent();
        }
        string[] A = new string[100];
        private void Page_Loaded(object sender, RoutedEventArgs e)

        {

            MainWindow.myMainWindow.Listauswahl(); //updates side list
            MainWindow.myMainWindow.Aktuelle_Auswahl_Liste.Visibility = Visibility.Visible; // Shows the side list


            for (int i = 0; i < CSV_Input.controllerListe.Count; i++)
            {
                A[i] = CSV_Input.controllerListe[i].Bezeichnung + "\n" + "Preis: " + CSV_Input.controllerListe[i].Preis.ToString() + " €" + "\t" + "Gewicht: "
                 + CSV_Input.controllerListe[i].Gewicht.ToString() + " g" + "\t" + "UART:  " + CSV_Input.controllerListe[i].UART + "\t" + "l2c:  " + CSV_Input.controllerListe[i].I2C;
                Controller.Add(new controller { Bezeichnung = A[i], Preis = CSV_Input.controllerListe[i].Preis, Gewicht = CSV_Input.controllerListe[i].Gewicht });
            }

            dataGrid.ItemsSource = Controller; // Forwards the summary data to the DataGrid



        }
        private void button_click(object sender, RoutedEventArgs e)
        {
            int i = dataGrid.Items.IndexOf(dataGrid.CurrentItem);
            CSV_Input.summary.Add(new Zusammenfassung { Bezeichnung = A[i], Preis = CSV_Input.controllerListe[i].Preis, Gewicht = CSV_Input.controllerListe[i].Gewicht });
            MainWindow.myMainWindow.Listauswahl();
        }

        private void Weiter_Button_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("sensor.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);
        }
    }
}

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
using System.Windows.Forms;
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
    public partial class zusammenfassung : Page
    {

        public zusammenfassung()
        {
            InitializeComponent();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)

        {
            dataGrid.ItemsSource = CSV_Input.summary; // Forwards the summary data to the DataGrid
            MainWindow.myMainWindow.Aktuelle_Auswahl_Liste.Visibility = Visibility.Collapsed;


        }


        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void button_click(object sender, RoutedEventArgs e)
        {
            MainWindow.myMainWindow.Listauswahl();
        }
        private void berechnen()
        {
            float preis = 0;
            float gewicht = 0;
            for (int i = 0; i < CSV_Input.summary.Count; i++) // Preis & Weight Calculation at Page Loaded
            {
                preis = CSV_Input.summary[i].Preis + preis;
                gewicht = CSV_Input.summary[i].Gewicht + gewicht;
            }
            Label1.Content = preis.ToString("0.00") + " €";
            Label2.Content = gewicht + " g";
        }
        private void button1_click(object sender, RoutedEventArgs e)
        {
            berechnen(); //recalculates when delete is pressed
        }
    }

}

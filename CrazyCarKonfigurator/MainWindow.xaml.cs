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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Bauteil> temp = new List<Bauteil>();
        private static int currentplace = 0;

        public static MainWindow myMainWindow; // Creatng a static instance of MainWindow
        public MainWindow()
        {
            InitializeComponent();
            myMainWindow = this;
            dataGrid.ItemsSource = MainWindow.temp; // Forwards the summary data to the DataGrid

        }
        private void btn(object sender, RoutedEventArgs e)
        {
            int index0 = dataGrid.Items.IndexOf(dataGrid.CurrentItem); // Index of chosen item from list
            int index = 0; // will show the index of the item if it's already in the list
            bool found = false;
            for (int i = 0; i < CSV_Input.summary.Count; i++)
            {
                if (CSV_Input.summary[i].Bezeichnung == temp[index0].Bezeichnung) // searches for the item and gives the index if it's found
                {
                    index = i;
                    found = true; break;
                }
            }
            if (found)  // increases the quantity if the item is already in the list, otherwise it adds it to the list
            {
                CSV_Input.summary[index].Quantity += 1;
            }
            else
            {
                CSV_Input.summary.Add(new Zusammenfassung { Bezeichnung = temp[index0].Bezeichnung, Preis = temp[index0].Preis, Gewicht = temp[index0].Gewicht, Quantity = 1 });
            }

            Listupdate(); // updates the side list.
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var tag = ((Button)sender).Tag; // Each button has it's own tag, this variable is to differentiate between buttons
            int index = Convert.ToInt32(tag);
            if (index != 8) // If any tab is clicked except of Zusammenfassung, the side list becomes visible and updated.
            {
                Listupdate();
                Aktuelle_Auswahl_Liste.Visibility = Visibility.Visible;
            }
            if (index == 9)      //If "weiter" button is clicked, jump to the next case.
            {
                index = currentplace + 1;
            }

            FrameWithinGrid.Content = null; //closes the opened page (in case you're jumping back from a page to MainWindow)
            temp.Clear(); //Clears the temporary list before cloning it to another list based on case.
            switch (index)
            {
                case 1: temp.AddRange(CSV_Input.controllerListe);break; //copies the controller list to a temporary list "temp" that is the source of the selection list.
                case 2: temp.AddRange(CSV_Input.sensorListe); break;
                case 3: temp.AddRange(CSV_Input.motorListe); break;
                case 4: temp.AddRange(CSV_Input.akkuListe); break;
                case 5: temp.AddRange(CSV_Input.servoListe); break;
                case 6: temp.AddRange(CSV_Input.karosserieListe); break;
                case 7: temp.AddRange(CSV_Input.reifenListe); break;
                case 8: FrameWithinGrid.Navigate(new System.Uri("zusammenfassung.xaml", UriKind.RelativeOrAbsolute)); Aktuelle_Auswahl_Liste.Visibility = Visibility.Collapsed; break; // opens summary page and hides side list
            }
            currentplace = index; //saves the current place in case "weiter" button was clicked next (so it jumps 1 place ahead)
            dataGrid.Items.Refresh(); //Refreshes the selection list
        }

        public void Listupdate()
        {
            string[] p = new string[100];

            for (int i = 0; i < CSV_Input.summary.Count; i++)
            {
                p[i] = CSV_Input.summary[i].Bezeichnung;

            }
            Aktuelle_Auswahl_Liste.ItemsSource = p;

        }
    }
}

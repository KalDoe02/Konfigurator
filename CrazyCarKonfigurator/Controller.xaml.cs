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



        }


        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //Testname = Controller1_Textbox.Text;
            string[] A = { "A", "B", "C", "D" };
            for (int i = 0; i < 4; i++)
            {
                A[i] = CSV_Input.controllerListe[i].Bezeichnung + "\n" + "Preis: " + CSV_Input.controllerListe[i].Preis.ToString() + " €" + "\t" + "Gewicht: " 
                + CSV_Input.controllerListe[i].Gewicht.ToString() + " g" + "\t" + "UART:  " + CSV_Input.controllerListe[i].UART + "\t" + "l2c:  " + CSV_Input.controllerListe[i].I2C;
            }
            Controller1_Daten_Textbox.Text = A[0];
            Controller2_Daten_Textbox.Text = A[1];
            Controller3_Daten_Textbox.Text = A[2];
            Controller4_Daten_Textbox.Text = A[3];

        }

        private void Controller1_Button_Click(object sender, RoutedEventArgs e)
        {
            //var c 
        }

        private void Weiter_Button_Click(object sender, RoutedEventArgs e)
        {
           // FrameWithinGrid.Navigate(new System.Uri("sensor.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}

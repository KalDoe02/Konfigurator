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

        private void Button_Click(object sender, RoutedEventArgs e)
        {


        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //Testname = Controller1_Textbox.Text;
            CSV_Input i = new CSV_Input();

            string name1 = i.controllerListe[0].Bezeichnung;
            float daten1 = i.controllerListe[1].Preis;

            Controller1_Daten_Textbox.Text = "Preis: " + daten1.ToString() + " €";
            Controller1_Name_Textbox.Text = name1;

            string name2 = i.controllerListe[1].Bezeichnung;
            Controller2_Name_Textbox.Text = name2;

            string name3 = i.controllerListe[2].Bezeichnung;
            Controller3_Name_Textbox.Text = name3;

            string name4 = i.controllerListe[3].Bezeichnung;
            Controller4_Name_Textbox.Text = name4;

            

        }
    }
}

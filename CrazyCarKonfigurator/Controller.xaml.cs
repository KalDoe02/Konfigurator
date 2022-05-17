using System;
using System.Collections.Generic;
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
        private string Testname = "STM 32";

        public controller()
        {
            InitializeComponent();
            //Controller1_Name_Textbox.Text = Controller[2];



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Testname = Controller1_Textbox.Text;
            CSV_Input i=new CSV_Input();
            List<Controller> l=i.getAll();
            //Controller1_Name_Textbox.Text =  ;
            
                //Testname;
    


        }
    }
}

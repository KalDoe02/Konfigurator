using System;
using System.Windows;
using System.Windows.Navigation;
using Klassenbibliothek;
using CrazyCarKonfigurator;

namespace CrazyCarKonfigurator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow myMainWindow; // Creatng a static instance of MainWindow
        public MainWindow()
        {
            InitializeComponent();
            myMainWindow = this;
            //  AddtoAuswahl();

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameWithinGrid.Navigate(new System.Uri("controller.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FrameWithinGrid.Navigate(new System.Uri("sensor.xaml", UriKind.RelativeOrAbsolute));
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FrameWithinGrid.Navigate(new System.Uri("motor.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            FrameWithinGrid.Navigate(new System.Uri("akku.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            FrameWithinGrid.Navigate(new System.Uri("servo.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            FrameWithinGrid.Navigate(new System.Uri("karosserie.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            FrameWithinGrid.Navigate(new System.Uri("reifen.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            FrameWithinGrid.Navigate(new System.Uri("zusammenfassung.xaml", UriKind.RelativeOrAbsolute));
        }

        public static string[] p = { "d", "dd", " ", "", "", "", "", "", "", "", "" };


        public void addtolist(string x, ref string[] p)
        {
            for (int i = 0; i < p.Length; i++)
             {
                if (string.IsNullOrEmpty(p[i]))
                 {
                     MainWindow.p[i] = x;
                     break;
                 }

            }
            Aktuelle_Auswahl_Liste.ItemsSource = p;

        }

    }
}

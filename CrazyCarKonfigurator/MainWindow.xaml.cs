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
        public MainWindow()
        {
            InitializeComponent();
            AddtoAuswahl();

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

        private void AddtoAuswahl()
        {
            string[] test = { "Test1", "Test2" };
            Aktuelle_Auswahl_Liste.ItemsSource = test;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//using CrazyCarKonfigurator;


namespace Klassenbibliothek
{

    public class CSV_Input
    {
        public List<Controller> controllerListe { get; set; } = GetControllers();

        public static List<Controller> GetControllers()
        {
            var list = new List<Controller>();

            // CSV Daten ín einzelne Zeilen einlesen
            //string[] csvLines = File.ReadAllLines(@"\Database\Database Controller.csv");
            string[] csvLines = File.ReadAllLines(@"C:\Users\Felix\Source\Repos\KalDoe02\Konfigurator\Klassenbibliothek\Database\Database Controller.csv");

            // Teile jede Reihe in Spalten
            for (int i = 1; i < csvLines.Length; i++)       // i mit 1 initialisieren, damit erste Zeile übersprungen wird Headerzeile
            {
                // Bezeichnung;Preis;Gewicht;Taktrate;PinAnzahl;UART;I2C
                // ATMEGA32;5,7;6;16.000.000,00;40;true;false

                string[] lineData = csvLines[i].Split(';');
                

                string Bezeichnung = lineData[0];
                float Preis = float.Parse(lineData[1]);
                int Gewicht = int.Parse(lineData[2]);
                double Taktrate = double.Parse(lineData[3]);
                int PinAnzahl = int.Parse(lineData[4]);
                bool UART = bool.Parse(lineData[5]);
                bool I2C = bool.Parse(lineData[6]);
                list.Add(new Controller
                {
                    Bezeichnung = Bezeichnung,
                    Preis = Preis,
                    Gewicht = Gewicht,
                    Taktrate = Taktrate,
                    PinAnzahl = PinAnzahl,
                    UART = UART,
                    I2C = I2C
                });
            }
            return list;
        }
    }
}

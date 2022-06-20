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
        public static List<Controller> controllerListe { get; set; } = GetControllers();
        public static List<Sensor> sensorListe { get; set; } = GetSensors();
        public static List<Motor> motorListe { get; set; } = GetMotors();
        public static List<Servo> servoListe { get; set; } = GetServos();
        public static List<Akku> akkuListe { get; set; } = GetAkkus();
        public static List<Reifen> reifenListe { get; set; } = GetReifen();
        public static List<Karosserie> karosserieListe { get; set; } = GetKarosserien();
        public static List<Zusammenfassung> summary { get; set; } = new List<Zusammenfassung>();





        public static List<Controller> GetControllers()
        {
            var list = new List<Controller>();

            // CSV Daten ín einzelne Zeilen einlesen
            //string[] csvLines = File.ReadAllLines(@"\Database\Database Controller.csv");
            string[] csvLines = File.ReadAllLines(@"..\..\..\..\Klassenbibliothek\Database\Database Controller.csv");


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
                string UART = lineData[5];
                string I2C = lineData[6];
                list.Add(new Controller
                {
                    Bezeichnung = Bezeichnung,
                    Preis = Preis,
                    Gewicht = Gewicht,
                    Taktrate = Taktrate,
                    PinAnzahl = PinAnzahl,
                    UART = UART,
                    I2C = I2C,
                });
            }
            return list;
        }
        public static List<Sensor> GetSensors()
        {
            var list = new List<Sensor>();

            // CSV Daten ín einzelne Zeilen einlesen
            //string[] csvLines = File.ReadAllLines(@"\Database\Database Controller.csv");
            string[] csvLines = File.ReadAllLines(@"..\..\..\..\Klassenbibliothek\Database\Database Sensoren.csv");


            // Teile jede Reihe in Spalten
            for (int i = 1; i < csvLines.Length; i++)       // i mit 1 initialisieren, damit erste Zeile übersprungen wird Headerzeile
            {


                string[] lineData = csvLines[i].Split(';');


                string Bezeichnung = lineData[0];
                float Preis = float.Parse(lineData[1]);
                int Gewicht = int.Parse(lineData[2]);
                int Reichweite = int.Parse(lineData[3]);
                string Sensorart = lineData[4];
                string Schnittstelle = lineData[5];
                list.Add(new Sensor
                {
                    Bezeichnung = Bezeichnung,
                    Preis = Preis,
                    Gewicht = Gewicht,
                    Reichweite = Reichweite,
                    Sensorart = Sensorart,
                });
            }
            return list;
        }
        public static List<Motor> GetMotors()
        {
            var list = new List<Motor>();

            // CSV Daten ín einzelne Zeilen einlesen

            string[] csvLines = File.ReadAllLines(@"..\..\..\..\Klassenbibliothek\Database\Database Motor.csv");


            // Teile jede Reihe in Spalten
            for (int i = 1; i < csvLines.Length; i++)       // i mit 1 initialisieren, damit erste Zeile übersprungen wird Headerzeile
            {


                string[] lineData = csvLines[i].Split(';');


                string Bezeichnung = lineData[0];
                float Preis = float.Parse(lineData[1]);
                int Gewicht = int.Parse(lineData[2]);
                double Nenndrehzahl = double.Parse(lineData[3]);
                float Stromaufnahme = float.Parse(lineData[4]);
                list.Add(new Motor
                {
                    Bezeichnung = Bezeichnung,
                    Preis = Preis,
                    Gewicht = Gewicht,
                    Nenndrehzahl = Nenndrehzahl,
                    Stromaufnahme = Stromaufnahme,
                });
            }
            return list;
        }
        public static List<Servo> GetServos()
        {
            var list = new List<Servo>();


            string[] csvLines = File.ReadAllLines(@"..\..\..\..\Klassenbibliothek\Database\Database Servo.csv");


            // Teile jede Reihe in Spalten
            for (int i = 1; i < csvLines.Length; i++)       // i mit 1 initialisieren, damit erste Zeile übersprungen wird Headerzeile
            {

                string[] lineData = csvLines[i].Split(';');


                string Bezeichnung = lineData[0];
                float Preis = float.Parse(lineData[1]);
                int Gewicht = int.Parse(lineData[2]);
                float Stellzeit = float.Parse(lineData[3]);
                float Drehmoment = float.Parse(lineData[4]);
                list.Add(new Servo
                {
                    Bezeichnung = Bezeichnung,
                    Preis = Preis,
                    Gewicht = Gewicht,
                    Stellzeit = Stellzeit,
                    Drehmoment = Drehmoment,
                }); ;
            }
            return list;
        }
        public static List<Akku> GetAkkus()
        {
            var list = new List<Akku>();

            // CSV Daten ín einzelne Zeilen einlesen
            string[] csvLines = File.ReadAllLines(@"..\..\..\..\Klassenbibliothek\Database\Database Akku.csv");


            // Teile jede Reihe in Spalten
            for (int i = 1; i < csvLines.Length; i++)  // i mit 1 initialisieren, damit erste Zeile übersprungen wird Headerzeile
            {


                string[] lineData = csvLines[i].Split(';');


                string Bezeichnung = lineData[0];
                float Preis = float.Parse(lineData[1]);
                int Gewicht = int.Parse(lineData[2]);
                float Spannung = float.Parse(lineData[3]);
                int capacity = int.Parse(lineData[4]);
                string art = lineData[5];
                int anzahlzellen = int.Parse(lineData[6]);
                list.Add(new Akku
                {
                    Bezeichnung = Bezeichnung,
                    Preis = Preis,
                    Gewicht = Gewicht,
                    Spannung = Spannung,
                    Kapazitaet = capacity,
                    Art = art,
                    AnzahlZellen = anzahlzellen,

                });
            }
            return list;
        }
        public static List<Reifen> GetReifen()
        {
            var list = new List<Reifen>();

            // CSV Daten ín einzelne Zeilen einlesen
            string[] csvLines = File.ReadAllLines(@"..\..\..\..\Klassenbibliothek\Database\Database Reifen.csv");


            // Teile jede Reihe in Spalten
            for (int i = 1; i < csvLines.Length; i++)  // i mit 1 initialisieren, damit erste Zeile übersprungen wird Headerzeile
            {

                string[] lineData = csvLines[i].Split(';');


                string Bezeichnung = lineData[0];
                float Preis = float.Parse(lineData[1]);
                int Gewicht = int.Parse(lineData[2]);
                int Durchmesser = int.Parse(lineData[3]);
                int Breite = int.Parse(lineData[4]);
                string Farbe = lineData[5];
                list.Add(new Reifen
                {
                    Bezeichnung = Bezeichnung,
                    Preis = Preis,
                    Gewicht = Gewicht,
                    Durchmesser = Durchmesser,
                    Breite = Breite,
                    Farbe = Farbe,
                });
            }
            return list;
        }
        public static List<Karosserie> GetKarosserien()
        {
            var list = new List<Karosserie>();

            // CSV Daten ín einzelne Zeilen einlesen
            string[] csvLines = File.ReadAllLines(@"..\..\..\..\Klassenbibliothek\Database\Database Karosserie.csv");


            // Teile jede Reihe in Spalten
            for (int i = 1; i < csvLines.Length; i++)  // i mit 1 initialisieren, damit erste Zeile übersprungen wird Headerzeile
            {

                string[] lineData = csvLines[i].Split(';');


                string Bezeichnung = lineData[0];
                float Preis = float.Parse(lineData[1]);
                int Gewicht = int.Parse(lineData[2]);
                int Laenge = int.Parse(lineData[3]);
                int Breite = int.Parse(lineData[4]);
                int Radstand = int.Parse(lineData[5]);
                list.Add(new Karosserie
                {
                    Bezeichnung = Bezeichnung,
                    Preis = Preis,
                    Gewicht = Gewicht,
                    Laenge = Laenge,
                    Breite = Breite,
                    Radstand = Radstand,
                });
            }
            return list;
        }
    }
}

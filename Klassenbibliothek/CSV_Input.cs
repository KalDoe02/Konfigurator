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
        public static List<Bauteil> controllerListe { get; set; } = GetControllers();
        public static List<Bauteil> sensorListe { get; set; } = GetSensors();
        public static List<Bauteil> motorListe { get; set; } = GetMotors();
        public static List<Bauteil> servoListe { get; set; } = GetServos();
        public static List<Bauteil> akkuListe { get; set; } = GetAkkus();
        public static List<Bauteil> reifenListe { get; set; } = GetReifen();
        public static List<Bauteil> karosserieListe { get; set; } = GetKarosserien();
        public static List<Zusammenfassung> summary { get; set; } = new List<Zusammenfassung>();





        public static List<Bauteil> GetControllers()
        {
            var list = new List<Bauteil>();

            // CSV Daten ín einzelne Zeilen einlesen
            //string[] csvLines = File.ReadAllLines(@"\Database\Database Controller.csv");
            string[] csvLines = File.ReadAllLines(@"..\..\..\..\Klassenbibliothek\Database\Database Controller.csv");

            string A;
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

                A = Bezeichnung + "\n" + "Preis: " + Preis.ToString() + " €" + "\t" + "Gewicht: "
                + Gewicht.ToString() + " g" + "\t" + "UART:  " + UART + "\t" + "l2c:  " + I2C;

                list.Add(new Bauteil
                {
                    Bezeichnung = A,
                    Preis = Preis,
                    Gewicht = Gewicht,
                    
                });
            }
            return list;
        }
        public static List<Bauteil> GetSensors()
        {
            var list = new List<Bauteil>();

            // CSV Daten ín einzelne Zeilen einlesen
            //string[] csvLines = File.ReadAllLines(@"\Database\Database Controller.csv");
            string[] csvLines = File.ReadAllLines(@"..\..\..\..\Klassenbibliothek\Database\Database Sensoren.csv");
            string A;

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
                A = Bezeichnung + "\n" + "Preis: " + Preis.ToString() + " €" + "\t" + "\t" + "Gewicht: " +
                Gewicht.ToString() + " g" + "\t" + "Reichweite: " + Reichweite +
                "\n" + "Sensorart: " + Sensorart;
                list.Add(new Bauteil
                {
                    Bezeichnung = A,
                    Preis = Preis,
                    Gewicht = Gewicht,
                });
            }
            return list;
        }
        public static List<Bauteil> GetMotors()
        {
            var list = new List<Bauteil>();

            // CSV Daten ín einzelne Zeilen einlesen

            string[] csvLines = File.ReadAllLines(@"..\..\..\..\Klassenbibliothek\Database\Database Motor.csv");
            string A;

            // Teile jede Reihe in Spalten
            for (int i = 1; i < csvLines.Length; i++)       // i mit 1 initialisieren, damit erste Zeile übersprungen wird Headerzeile
            {


                string[] lineData = csvLines[i].Split(';');


                string Bezeichnung = lineData[0];
                float Preis = float.Parse(lineData[1]);
                int Gewicht = int.Parse(lineData[2]);
                double Nenndrehzahl = double.Parse(lineData[3]);
                float Stromaufnahme = float.Parse(lineData[4]);
                A = Bezeichnung + "\n" + "Preis:" + Preis.ToString() + " €" + "\t" + "Gewicht: " +
                Gewicht.ToString() + " g" + "\t" + "Nenndrehzahl: " + Nenndrehzahl + " U/Min"
                + "\n" + "Stromaufnahme: " + Stromaufnahme + " A";
                list.Add(new Bauteil
                {
                    Bezeichnung = A,
                    Preis = Preis,
                    Gewicht = Gewicht,
                });
            }
            return list;
        }
        public static List<Bauteil> GetServos()
        {
            var list = new List<Bauteil>();

            string[] csvLines = File.ReadAllLines(@"..\..\..\..\Klassenbibliothek\Database\Database Servo.csv");
            string A;

            // Teile jede Reihe in Spalten
            for (int i = 1; i < csvLines.Length; i++)       // i mit 1 initialisieren, damit erste Zeile übersprungen wird Headerzeile
            {
                string[] lineData = csvLines[i].Split(';');


                string Bezeichnung = lineData[0];
                float Preis = float.Parse(lineData[1]);
                int Gewicht = int.Parse(lineData[2]);
                float Stellzeit = float.Parse(lineData[3]);
                float Drehmoment = float.Parse(lineData[4]);
                A = Bezeichnung + "\n" + "Preis: " + Preis.ToString() + " €" + "\t" + "Gewicht: " +
                Gewicht.ToString() + " g" + "\t" + "Stellzeit: " + Stellzeit + " s" +
                "\n" + "Drehmoment: " + Drehmoment + " kg/cm";

                list.Add(new Bauteil
                {
                    Bezeichnung = A,
                    Preis = Preis,
                    Gewicht = Gewicht,

                }); ;
            }
            return list;
        }
        public static List<Bauteil> GetAkkus()
        {
            var list = new List<Bauteil>();

            // CSV Daten ín einzelne Zeilen einlesen
            string[] csvLines = File.ReadAllLines(@"..\..\..\..\Klassenbibliothek\Database\Database Akku.csv");
            string A;


            // Teile jede Reihe in Spalten
            for (int i = 1; i < csvLines.Length; i++)  // i mit 1 initialisieren, damit erste Zeile übersprungen wird Headerzeile
            {


                string[] lineData = csvLines[i].Split(';');


                string Bezeichnung = lineData[0];
                float Preis = float.Parse(lineData[1]);
                int Gewicht = int.Parse(lineData[2]);
                float Spannung = float.Parse(lineData[3]);
                int Kapazitaet = int.Parse(lineData[4]);
                string Art = lineData[5];
                int AnzahlZellen = int.Parse(lineData[6]);
                A = Bezeichnung + "\n" + "Preis: " + Preis.ToString() + " €" + "\t" + "Gewicht: " +
                Gewicht.ToString() + " g" + "\t" + "Spannung: " + Spannung + " V" + "\n"
                + "Kapazität: " + Kapazitaet + " mAh" + "\t" + "Anzahl der Zellen: " + AnzahlZellen + "\t" +
                "Art: " + Art + "\t";
                list.Add(new Bauteil
                {
                    Bezeichnung = A,
                    Preis = Preis,
                    Gewicht = Gewicht,


                });
            }
            return list;
        }
        public static List<Bauteil> GetReifen()
        {
            var list = new List<Bauteil>();

            // CSV Daten ín einzelne Zeilen einlesen
            string[] csvLines = File.ReadAllLines(@"..\..\..\..\Klassenbibliothek\Database\Database Reifen.csv");
            string A;

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
                A = Bezeichnung + "\n" + "Preis:" + Preis.ToString() + " €" + "\t" + "Gewicht: " +
                 Gewicht.ToString() + " g" + "\t" + "Durchmesser: " + Durchmesser + " mm"
                 + "\n" + "Breite: " + Breite + " mm" + "\t" + "Farbe: " + Farbe;
                list.Add(new Bauteil
                {
                    Bezeichnung = A,
                    Preis = Preis,
                    Gewicht = Gewicht,

                });
            }
            return list;
        }
        public static List<Bauteil> GetKarosserien()
        {
            var list = new List<Bauteil>();

            // CSV Daten ín einzelne Zeilen einlesen
            string[] csvLines = File.ReadAllLines(@"..\..\..\..\Klassenbibliothek\Database\Database Karosserie.csv");
            string A;

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
                A = Bezeichnung + "\n" + "Preis:" + Preis.ToString() + " €" + "\t" + "Gewicht: " +
                 Gewicht.ToString() + " g" + "\t" + "Laenge: " + Laenge + " mm"
                 + "\n" + "Breite: " + Breite + " mm" + "\t" + "Radstand: " + Radstand + " mm";
                list.Add(new Bauteil
                {
                    Bezeichnung = A,
                    Preis = Preis,
                    Gewicht = Gewicht,

                });
            }
            return list;
        }
    }
}

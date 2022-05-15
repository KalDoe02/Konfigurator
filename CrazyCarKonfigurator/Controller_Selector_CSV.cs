using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CrazyCarKonfigurator
{
    internal class Controller_Selector_CSV
    {
        private List<Controller> controllers;

        public Controller_Selector_CSV()
        {
            controllers = new List<Controller>();

            string[] zeilen = File.ReadAllLines(@"\Database\Database Controller.csv");
            foreach (string zeile in zeilen )
            {
                string[] daten = zeile.Split(';');
                string Bezeichnung = daten[1];
                float Preis = float.Parse(daten[2]);
                int Gewicht = int.Parse(daten[3]);
                int Taktrate = int.Parse(daten[4]);
                int PinAnzahl = int.Parse(daten[5]);
                bool UART = bool.Parse(daten[6]);
                bool I2C = bool.Parse(daten[7]);

                controllers.Add(new Controller { Bezeichnung = Bezeichnung, Preis = Preis, Gewicht = Gewicht, Taktrate = Taktrate, PinAnzahl = PinAnzahl, UART = UART, I2C = I2C });
            }
        }

        public Controller[] getAll()
        {
            return controllers.ToArray();
        }


    }
}

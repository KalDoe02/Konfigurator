using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassenbibliothek
{
    public class Controller : Bauteil
    {
        public double Taktrate { get; set; }
        public int PinAnzahl { get; set; }
        public string UART { get; set; }
        public string I2C { get; set; }


    }
}

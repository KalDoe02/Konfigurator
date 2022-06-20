using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassenbibliothek
{
    public class Akku : Bauteil
    {
        public float Spannung { get; set; }
        public int Kapazitaet { get; set; }
        public string Art { get; set; }
        public int AnzahlZellen { get; set; }
    }
}

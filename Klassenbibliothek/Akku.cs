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
        public int capacity { get; set; }
        public string art { get; set; }
        public int anzahlzellen { get; set; }
    }
}

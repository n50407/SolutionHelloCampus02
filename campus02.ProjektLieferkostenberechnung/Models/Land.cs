using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace campus02.ProjektLieferkostenberechnung.Models
{
    internal class Land
    {
        public string Bezeichnung { get; set; }
        public double Kosten { get; set; }
        public string Flagge { get; set; }

        public override string ToString()
        {
            return Bezeichnung;
        }
    }
}

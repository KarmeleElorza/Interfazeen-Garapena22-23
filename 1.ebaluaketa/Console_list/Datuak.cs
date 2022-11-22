using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_list
{
    internal class Datuak
    {
        public string Izena { get; set; }
        public Datuak(string Izena)
        {
            this.Izena = Izena;
        }
        public static String DatuenZerrenda(List<Datuak> datuak)
        {
            String mezua = "";
            foreach (Datuak datua in datuak)
            {
                mezua += datua.Izena + " ";
            }
            return mezua;
        }
    }
}

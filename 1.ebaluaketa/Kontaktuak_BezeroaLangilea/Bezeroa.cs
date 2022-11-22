using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontaktuak_BezeroaLangilea
{
    internal class Bezeroa : Kontaktua
    {
        public string Kategoria { get; set; }
        public override string Gorde()
        {
            return "Bezeroa ondo gorde da.";
        }
    }
}

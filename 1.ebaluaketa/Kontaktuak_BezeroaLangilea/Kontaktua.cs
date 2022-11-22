using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Kontaktuak_BezeroaLangilea
{
    internal class Kontaktua
    {
        public string Nan { get; set; }
        public string Izena { get; set; }
        public string IzenOsoa { get { return this.Izena + " " + this.IzenOsoa; } }
    public string Abizena { get; set; }
        public virtual string Emaila {
            get => this.Emaila;
            set
            {
                if (!value.EndsWith("uni.eus")) //value.Substring(value.Length - 8) == "uni.eus"
                {
                    Exception ex = new Exception("Ez da zuzena. \"uni.eus\" helbidearekin bukatu beharko du.");
                    throw ex;
                }
                else
                {
                    this.Emaila = value;
                }
            }
        }
        public virtual string Gorde()
        {
            return "Kontaktua ondo gorde da.";
        }
    }
}

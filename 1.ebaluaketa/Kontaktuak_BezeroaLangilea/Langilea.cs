using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontaktuak_BezeroaLangilea
{
    internal class Langilea : Kontaktua
    {
        public float Soldata { get; set; }
        public string SegurtasunSoziala { get; set; }
        public override string Emaila { 
            get => base.Emaila;
            set 
            {
                if (!value.EndsWith("uni.eus")) //if(value.length > 8 && value.Substring(value.Length - 8) == "uni.eus")
                {
                    Exception ex = new Exception("Ez da zuzena. \"uni.eus\" helbidearekin bukatu beharko du.");
                    throw ex;
                }
                else
                {
                    base.Emaila = value;
                }
            }
        }
        public override string Gorde()
        {
            return "Langilea ondo gorde da.";
        }
    }
}

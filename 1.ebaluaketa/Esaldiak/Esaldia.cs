using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esaldiak
{
    internal class Esaldia
    {
        //propietateak
        public String esaldia { get; set; } = "";
        public String esaldiBatua { get; set; } = "";
        //public String esaldiBatua2;
        //public string EsaldiBatua2
        //{
        //    get { return esaldiBatua2; }
        //}
        //public void Batu()
        //{
        //    esaldiBatua2 += "" + esaldia;
        //}
        //eraikitzailea
        public Esaldia(){

        }
        //metodoak
        public void esaldiakBatu()
        {
            this.esaldiBatua = this.esaldia;
        }

    }
}

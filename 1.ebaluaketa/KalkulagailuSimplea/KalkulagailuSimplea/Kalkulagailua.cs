using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulagailuSimplea
{
    public class Kalkulagailua
    {
        //propietateak
        public float Zenb { get; set; }
        public float Zenb2 { get; set; }

        //eraikitzailea
        public Kalkulagailua(float zenbakia, float zenbakia2)
        {
            this.Zenb = zenbakia;
            this.Zenb2 = zenbakia2;
        }
        public Kalkulagailua()
        {
        }
        //metodoak
        public float Gehiketa()
        {
            return this.Zenb + this.Zenb2;
        }
        public float Kenketa()
        {
            return this.Zenb - this.Zenb2;
        }
        public float Zatiketa()
        {
            return this.Zenb / this.Zenb2;
        }
        public float Biderketa()
        {
            return this.Zenb * this.Zenb2;
        }
    }
}

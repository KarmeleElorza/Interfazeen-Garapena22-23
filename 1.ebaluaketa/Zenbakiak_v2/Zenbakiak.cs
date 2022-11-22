using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zenbakiak_v2
{
    internal class Zenbakiak
    {
        public float zenb { get; set; }
        public Zenbakiak()
        {

        }
        public static float eragiketa(List<Zenbakiak> zenb)
        {
            float emaitza = 0;
            emaitza = (zenb[0].zenb + (2 * zenb[1].zenb) + (3 * zenb[2].zenb) + (4 * zenb[3].zenb)) / 4;
            return emaitza;
        }
    }   
}

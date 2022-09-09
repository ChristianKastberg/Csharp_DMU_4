using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3_ObjektOrientering
{
    class Mekaniker : Person
    {
        public int TimeLøn { get; set; }

        public int BestodÅr { get; set; }

        public Mekaniker(String name, String adress, int timeLøn, int bestodÅr) : base(name,adress)
        {
            TimeLøn = timeLøn;
            BestodÅr = bestodÅr;

        }
        public override double BeregnUgeLøn()
        {
            return TimeLøn*TimerPrUge;
        }

    }
}

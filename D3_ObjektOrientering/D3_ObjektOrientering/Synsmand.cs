using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3_ObjektOrientering
{
    class Synsmand : Mekaniker
    {
        public int AntalSyn { get; set; }

        public Synsmand(String name, String adress, int timeLøn, int bestodÅr, int antalSyn) : base(name,adress,timeLøn,bestodÅr)
        {
            this.AntalSyn = antalSyn;
        }
        public override double BeregnUgeLøn()
        {
            return TimeLøn*TimerPrUge+(AntalSyn*300);
        }
    }
}

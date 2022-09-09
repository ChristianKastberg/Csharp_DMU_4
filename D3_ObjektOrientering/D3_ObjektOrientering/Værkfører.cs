using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3_ObjektOrientering
{
    class Værkfører : Mekaniker
    {
        public int Promoted { get; set; }

        public Værkfører(String name, String adress, int timeLøn, int bestodÅr, int promoted) : base(name,adress,timeLøn,bestodÅr) 
        {
            this.Promoted = promoted;

        }
        public override double BeregnUgeLøn()
        {
            return TimeLøn*TimerPrUge+999;
        }


    }
}

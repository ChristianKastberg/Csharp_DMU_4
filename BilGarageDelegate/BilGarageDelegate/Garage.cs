using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace BilGarageDelegate
{
    class Garage
    {
        private ArrayList biler;

        public Garage()
        {
            biler = new ArrayList();
        }

        public void tilføjBil(Bil b)
        {
            biler.Add(b);
        }

        public void HåndterBiler(Bil.Arbejde arbejde)
        {
            foreach (Bil b in biler)
            {
                arbejde(b);
            }
        }

    }
}

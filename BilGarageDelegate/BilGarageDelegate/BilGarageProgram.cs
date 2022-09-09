using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace BilGarageDelegate
{
    class BilGarageProgram
    {


        static void Main(string[] args)
        {
            Garage garage = new Garage();
            Bil b1 = new Bil("ZC 12 345","Volvo",200000);
            garage.tilføjBil(b1);
            Bil b2 = new Bil("ZC 67 890","Fiat", 10000);
            garage.tilføjBil(b2);
            Bil b3 = new Bil("ZC 11 111","Seat", 20000);
            garage.tilføjBil(b3);

            b1.Snavset = true;
            b2.BytHjul = true;
            b3.Snavset = true;
            b3.BytHjul = true;

            // Simpel delegate:
            //garage.HåndterBiler(new Bil.Arbejde(Applikationer.Vask));
            //garage.HåndterBiler(new Bil.Arbejde(Applikationer.Roter));

            // Multicast delegate:
            Bil.Arbejde md = new Bil.Arbejde(Applikationer.Vask);
            md += new Bil.Arbejde(Applikationer.Roter);
            garage.HåndterBiler(md);

            Console.WriteLine("Slut, tast Enter");
            Console.ReadLine();
        }
    }
}

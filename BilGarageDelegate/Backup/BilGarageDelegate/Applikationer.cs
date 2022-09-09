using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace BilGarageDelegate
{
    class Applikationer
    {
        public static void Vask(Bil b)
        {
            if (b.Snavset)
            {
                Console.Write(b + "Vaskes ...");
                Thread.Sleep(4000);
                    Console.WriteLine(".. færdig");
            }
        }

        public static void Roter(Bil b)
        {
            if (b.BytHjul)
            {
                Console.Write(b + "Får byttet hjul ...");
                Thread.Sleep(4000);
                Console.WriteLine(".. færdig");
            }
        }
    }
}

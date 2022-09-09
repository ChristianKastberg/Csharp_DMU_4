using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3_ObjektOrientering
{
    class App
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("ole", "søndergade 15");
            Mekaniker m1 = new Mekaniker("søren", "Sørensgade 29", 10, 1999);
            Værkfører v1 = new Værkfører("svend", "HundeGade 14 ", 150, 2004, 2012);
            Synsmand s1 = new Synsmand("Jørgen", "JørgensGade 22", 120, 2007, 20);
            Console.WriteLine(p1);
            Console.WriteLine(m1);
            Console.WriteLine(v1);
            Console.WriteLine(s1);
            Console.WriteLine(p1.BeregnUgeLøn());
            Console.WriteLine(m1.BeregnUgeLøn());
            Console.WriteLine(v1.BeregnUgeLøn());
            Console.WriteLine(s1.BeregnUgeLøn());

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3_ObjektOrientering
{
    class Person
    {
        private const int _timerPrUge = 37;


        public String Name { get; set; } // auto-implemented propertues
        public String Adress { get; set; }

        public Person()
        {
           
        }
        public Person(String name, string adress)
        {
            this.Name = name;
            this.Adress = adress;
        }

        public override string ToString()
        {
            return base.ToString() + ": " + Name.ToString()+"   " + Adress.ToString();
        }

        public virtual double BeregnUgeLøn()
        {
            return _timerPrUge*100;
        }
        public int TimerPrUge //og den tilhørende access metode, bemærk readOnly, dvs set!
        {
            get { return _timerPrUge; }
        }

    }
}

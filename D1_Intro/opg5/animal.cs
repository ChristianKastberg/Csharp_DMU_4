using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalLibrary;
using doggo;

namespace solution
{
    class solution
    {
        static void Main(string[] args)
        {
            animal a1 = new animal("hund");
            animal a2 = new animal("kat");
            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.ReadKey();

        }
    }
}


namespace doggo
{

    class animal : Ianimal
    {

        private String species;
        public animal(String species)
        {

            this.species = species;
        }
        public String Species
        {
            get { return species; }
            set { species = value; }
        }

        public bool isDog(String species)
        {
            if (species.Equals("hund")) { return true; }
            else
            {
                return false;
                
            }
        }

        public bool isDog()
        {
            throw new NotImplementedException();
        }
    }
}
    






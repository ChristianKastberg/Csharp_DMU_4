using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProgram
{
    class Person
    {
        
        public String Navn { get; set; }
        public String Adresse { get; set; }


        public Person(Cpr cpr, String navn, String adresse) 
        {
            
            this.Navn = navn;
            this.Adresse = adresse;
        }
        
            
        
    }
}

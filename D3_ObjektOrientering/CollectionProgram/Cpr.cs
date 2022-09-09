using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProgram 
{
    class Cpr
    {
        public String BirthDate{get;set;}
        public String SequenceNumber { get; set; }

        public Cpr(String bDate, String sNumber) 
        {
            this.BirthDate = bDate;
            this.SequenceNumber = bDate;
        }

    }
}

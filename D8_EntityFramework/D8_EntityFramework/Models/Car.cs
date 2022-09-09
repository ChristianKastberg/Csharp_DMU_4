using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D8_EntityFramework.Models
{
    class Car
    {
        public int CarID { get; set; }

        public string CarName { get; set; }
        
        public Car()
        {

        }
        public Car(string carname)
        {
            this.CarName = carname;
        }
    }
}

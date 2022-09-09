using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D8_EntityFramework.Models
{
    class Person
    {
        public int PersonID { get; set; }
        public String Name { get; set; }

        public int Age { get; set; }



        public Person() 
        { 
        }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

    }

}

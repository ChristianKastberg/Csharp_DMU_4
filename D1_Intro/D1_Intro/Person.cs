using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1_Intro
{
    class Person

    {
        private string name;
        private int age;

        public override string ToString()
        {
            return "My Name Is " + name.ToString() + " And I am " + age +" Years old";
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
       public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
   }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using D8_EntityFramework.Models;

namespace D8_EntityFramework.DAL 
{
    public class PersonInitializer : CreateDatabaseIfNotExists<PersonContext>
    {

        protected override void Seed(PersonContext context)
        {
            List<Person> people = new List<Person>();
            Person p1 = new Person("John", 32);
            Person p2 = new Person("Mikey", 44);
            Person p3 = new Person("OldTimer", 154);



        }

    }

}

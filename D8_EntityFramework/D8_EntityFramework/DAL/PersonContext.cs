using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D8_EntityFramework.DAL
{
    public class PersonContext : DbContext
    {
        public DbSet<Person> {get; set;}

    public DbSet<Car> {get; set }
    }
}

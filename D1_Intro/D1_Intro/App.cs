using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1_Intro
{
    class App
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("john", 22);
            Console.WriteLine("{0} {1}", p1.Name, p1.Age);
            Console.WriteLine("                     ");
            Console.WriteLine(p1);
            p1.Name = "michael";
            p1.Age = 33;
            Console.WriteLine("                     ");
            Console.WriteLine("{0} {1}", p1.Name, p1.Age);
            Console.WriteLine("                     ");
            Console.WriteLine(p1);



            Console.ReadKey();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2_loops_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            DateTime d = new DateTime(1990,10 ,1);
            fib(14);
           
            CalculateAge(d, out age);
            Console.WriteLine(age + " This number is from the CalcAge method");

            Console.ReadKey();

        }
        public static long fib(int n) // long da fibbonacci hurtig bliver kæmpe
        {
            if (n <= 2) { return 1; } // ikke helt korrekt de første 3 tal i sekvensen er 0,1,1 
            else
            {
                long olderValue = 1;
                long oldValue = 1;
                long newValue = 1;
                for (int i = 3; i <= n; i++)
                {
                    newValue = oldValue + olderValue;
                    olderValue = oldValue;
                    oldValue = newValue;
                    Console.WriteLine(newValue);
                }
                return newValue;
            }
        }
        public static void CalculateAge(DateTime BirthDateInput, out int age)  
        {
            age = 0;

            int year = BirthDateInput.Year;
            age = DateTime.Now.Year - year; // meget simpel kigger  kun på årstallet ikke måned eller dag
      
        }

       
    }

}

    

using System;
using System.Collections.Generic;

namespace D5_LINQ
{
    class Program
    {
        private static List<Person> people1;

        static void Main(string[] args)
        {

             Console.WriteLine("1. Alle personer med en score under 2");
            Console.WriteLine("                  ");
            Exercise2();
            Console.WriteLine("                  ");
            Console.WriteLine("2.Alle personer med en lige score, altså 0, 2, 4, 6…");
            Console.WriteLine("                  ");
            //Exercise3();
            Console.WriteLine("                  ");
            Console.WriteLine("3.Alle personer med en lige score og weight større end 60");
            Console.WriteLine("                  ");
            //Exercise4(); 
            Console.WriteLine("                  ");
            Console.WriteLine("4.Alle personer med en vægt deleligt med 3");
            Console.WriteLine("                  ");
            //Exercise5();
            Console.WriteLine("                  ");
            Console.WriteLine("5.Alle personer med en score == 3");
            Console.WriteLine("                  ");
            findexc1();
            Console.WriteLine("                  ");
            Console.WriteLine("6.alle personer med score == 3 og 10 år");
            Console.WriteLine("                  ");
            findexc2();
            Console.WriteLine("                  ");
            Console.WriteLine("7.første person med score  på 3 og 10 år");
            Console.WriteLine("                  ");
            findexc3();
            Console.WriteLine("                  ");
            Console.WriteLine("8.første person under 8 år --- you get the drill");
            Console.WriteLine("                  ");
            findexc4();


            //foreach (Person element in people1)
            //{
            //    Console.WriteLine($"{element}");
            //}



            Console.ReadKey();
        }
        public static void Exercise1()
        {
            try
            {
                people1 = Person.ReadCSVFile(@"C:\Users\Charles\OneDrive\Skrivebord\C#\data1.csv");
            }
            catch (Exception ex)
            {
                Console.WriteLine("EXCEPTION: " + ex.Message);
                Console.WriteLine(
           "You should probably set the filename to the Person.ReadCSVFile method to something on your disk!");
            }

        }
        public static void Exercise2()
        {
            try
            {
                people1 = Person.ReadCSVFile(@"C:\Users\Charles\OneDrive\Skrivebord\C#\data1.csv");
                foreach(Person element in people1) 
                {
                    if(element.Score <= 2)
                    {
                        Console.WriteLine(element);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("EXCEPTION: " + ex.Message);
            }
        }

        public static void Exercise3()
        {
            try
            {
                people1 = Person.ReadCSVFile(@"C:\Users\Charles\OneDrive\Skrivebord\C#\data1.csv");
                foreach (Person element in people1)
                {
                    if (element.Score % 2 == 0)
                    {
                        Console.WriteLine(element);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("EXCEPTION: " + ex.Message);
            }
        }
        public static void Exercise4()
        {
            try
            {
                people1 = Person.ReadCSVFile(@"C:\Users\Charles\OneDrive\Skrivebord\C#\data1.csv");
                foreach (Person element in people1)
                {
                    if (element.Weight  >= 60 && element.Score % 2 == 0)
                    {
                        Console.WriteLine(element);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("EXCEPTION: " + ex.Message);
            }
        }
        public static void Exercise5()
        {
            try
            {
                people1 = Person.ReadCSVFile(@"C:\Users\Charles\OneDrive\Skrivebord\C#\data1.csv");
                foreach (Person element in people1)
                {
                    if (element.Weight % 3 ==0)
                    {
                        Console.WriteLine(element);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("EXCEPTION: " + ex.Message);
            }
        }
        public static void findexc1()
        {
            var people = people1;
            foreach(Person element in people)
            {
                if(element.Score == 3)
                {
                    Console.WriteLine(element);
                }
            }

      }
        public static void findexc2()
        {
            var people2 = people1;
            foreach (Person element in people2)
            {
                if (element.Score == 3 && element.Age <= 10)
                {
                    Console.WriteLine(element);
                    break;
                }
            }

        }
        public static void findexc3()
        {
            var people3 = people1;
            foreach (Person element in people3)
            {
                if (element.Score == 3 && element.Age <= 10)
                {
                    Console.WriteLine(element);
                }
            }

        }
        public static void findexc4()
        {
            var people4 = people1;
            foreach (Person element in people4)
            {
                if (element.Age <= 8 && element.Score == 3)
                {
                    Console.WriteLine(element);
                    break;
                }
            }

        }
    }
}

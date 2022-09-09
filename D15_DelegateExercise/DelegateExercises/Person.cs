using System;
using System.Collections.Generic;

namespace DelegateExercises {

    public delegate string FormatPersonName(string firstname, string lastname);

    public class People : List<Person>
    {
        public void PrintPeople(FormatPersonName formatter)
        {
            this.ForEach(p => p.PrintPersonName(formatter));
        }
    }

    public class Person {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void PrintPersonName(FormatPersonName formatter)
        {
            //Console.WriteLine(formatter.Invoke(FirstName, LastName));
            Console.WriteLine(formatter(FirstName, LastName));
        }

        public static People CreateListOfPeople() {
            return new People()
            {
                new Person() { FirstName = "Stephen", LastName = "King" },
                new Person() { FirstName = "George", LastName = "Martin" },
                new Person() { FirstName = "Ernest", LastName = "Hemingway" },
                new Person() { FirstName = "William", LastName = "Shakespeare" }
            };
        }
    }

    public class PersonUserClass {

        public static string FormatFullNameLastNameFirst(string FirstName, string LastName)
        {
            return $"{LastName}, {FirstName}";
        }

        public static string FormatFullNameAllCaps(string FirstName, string LastName)
        {
            return $"{LastName.ToUpper()}, {FirstName.ToUpper()}";
        }

        public static string FormatFullNameLowerCase(string FirstName, string LastName)
        {
            return $"{LastName.ToLower()}, {FirstName.ToLower()}";
        }

        public static string FormatShortName(string FirstName, string LastName)
        {
            return $"{FirstName.Substring(0, 1)}. {LastName}";
        }

        public static void Main(string[] args) {
            var people = Person.CreateListOfPeople();

            ////////////////////////////////
            // Start here            
            ////////////////////////////////

            while (true) {
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Hvordan vil du have udskrevet navnene?");
                Console.WriteLine("1: Efternavn efterfulgt af fornavn");
                Console.WriteLine("2: Efternavn efterfulgt af fornavn, store bogstaver");
                Console.WriteLine("3: Efternavn efterfulgt af fornavn, små bogstaver");
                Console.WriteLine("4: Kun forbogstav af fornavn efterfulgt af efternavn");
                Console.WriteLine();
                Console.WriteLine("q: For at afslutte!");
                Console.Write("> ");
                var input = Console.ReadLine();
                switch (input.ToUpper()) {
                    case "1":
                       // people.PrintPeople(FormatFullNameLastNameFirst);
                        //nedenstående gør det samme
                        people.ForEach(p => p.PrintPersonName((F, L) => FormatFullNameLastNameFirst(F, L)));
                        break;
                    case "2":
                        people.PrintPeople(FormatFullNameAllCaps);
                        break;
                    case "3":
                        people.PrintPeople(FormatFullNameLowerCase);
                        break;
                    case "4":
                        people.PrintPeople(FormatShortName);
                        break;
                    case "Q": return;
                    default:
                        Console.WriteLine("Ukendt valg, prøv igen");
                        break;
                }
            }
        }  
    }
}

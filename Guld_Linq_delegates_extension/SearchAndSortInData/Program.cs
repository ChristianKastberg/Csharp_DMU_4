using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAndSortInData {

    public delegate bool Selector(Person p);

    public static class MyExtensions {
        //static void SetAccepted(this List<Person> lst, Predicate<Person> predicate) {
        public static void SetAcceptedS(this List<Person> lst, Selector s) {
            var people = lst.FindAll(p => s(p));
            people.ForEach(p => p.Accepted = true);
        }

        public static void SetAcceptedP(this List<Person> lst, Predicate<Person> pred) {
            var people = lst.FindAll(pred);
            people.ForEach(p => p.Accepted = true);
        }

        public static void Reset(this List<Person> people) {
            people.ForEach(p => p.Accepted = false);
        }

        public static void Print(this List<Person> people) {
            people.ForEach(p => Console.WriteLine(p));
        }
    }

    class Program {



        static List<Person> people1 = new List<Person>();

       

        static List<Person> GetPeople1() {
            // Return data from data1.csv
            return new List<Person>() {
                new Person("Saul;60;63;7"),       new Person("Mel;9;117;5"),
                new Person("Preston;50;100;10"),  new Person("Evan;23;28;2"),
                new Person("Alison;24;93;4"),     new Person("Nikia;90;110;7"),
                new Person("Micheal;15;10;10"),   new Person("Brittany;21;83;8"),
                new Person("Ward;18;17;2"),       new Person("Elmo;46;105;5"),
                new Person("Bertram;60;88;6"),    new Person("Cristin;31;86;7"),
                new Person("Monroe;12;49;2"),     new Person("Aundrea;16;42;3"),
                new Person("Ayanna;67;60;10"),    new Person("Lucio;51;102;1"),
                new Person("Armando;93;105;3"),   new Person("Audrie;56;42;5"),
                new Person("Mirtha;56;45;7"),     new Person("Voncile;20;28;0"),
                new Person("Chae;80;13;0"),       new Person("Halina;97;71;7"),
                new Person("Alex;13;42;5"),       new Person("Adan;99;100;5"),
                new Person("Natashia;18;92;9"),   new Person("Forrest;66;102;2"),
                new Person("Taina;9;96;9"),       new Person("Simon;83;75;10"),
                new Person("Kory;46;82;8"),       new Person("Tinisha;65;89;9"),
                new Person("Denny;38;116;2"),     new Person("Harriette;52;67;9"),
                new Person("Conrad;14;114;2"),    new Person("Jeanie;65;72;4"),
                new Person("Mose;5;79;4"),        new Person("Stefan;77;47;9"),
                new Person("Wade;69;7;7"),        new Person("Andrew;43;77;2"),
                new Person("Shameka;35;82;4"),    new Person("Kenna;22;87;3"),
                new Person("Columbus;85;101;3"),  new Person("Denna;98;94;4"),
                new Person("Stephanie;38;77;9"),  new Person("Rigoberto;78;90;8"),
                new Person("Jamila;87;5;9"),      new Person("Seymour;48;58;9"),
                new Person("Warner;31;19;2"),     new Person("Tommie;99;104;4"),
                new Person("Emma;17;51;8"),       new Person("Tim;70;71;8"),
                new Person("Marhta;75;34;5"),     new Person("Joshua;21;13;7"),
                new Person("Luigi;9;84;3"),       new Person("Vito;58;14;8"),
                new Person("Marquis;59;7;3"),     new Person("Kaci;29;6;6"),
                new Person("Necole;18;108;4"),    new Person("Samella;25;69;2"),
                new Person("Hang;82;64;9"),       new Person("Asuncion;30;99;0"),
                new Person("Enoch;83;119;6"),     new Person("Andreas;90;120;1"),
                new Person("Doyle;21;75;7"),      new Person("Loree;66;52;0"),
                new Person("Trudie;55;86;6"),     new Person("Jon;52;104;2"),
                new Person("Chantay;59;6;9"),     new Person("Gwenda;15;37;5"),
                new Person("Piper;50;56;2"),      new Person("Sabine;5;44;4"),
                new Person("Saturnina;67;62;1"),  new Person("Dovie;81;35;9"),
                new Person("Nick;1;74;7"),        new Person("Roxanne;86;82;3"),
                new Person("Francisco;88;23;10"), new Person("Galina;89;34;3"),
                new Person("Shirley;100;81;8"),   new Person("Nada;71;113;2"),
                new Person("Jamee;64;66;0"),      new Person("Tona;35;103;5"),
                new Person("Valencia;77;30;10"),  new Person("Gavin;63;93;0"),
                new Person("Jean;20;120;9"),      new Person("Darrel;28;11;10"),
                new Person("Boris;3;94;0"),       new Person("Alverta;85;12;5"),
                new Person("Otto;71;24;8"),       new Person("Hermelinda;81;118;0"),
                new Person("Jeffrey;78;45;6"),    new Person("Lon;13;120;5"),
                new Person("Stuart;73;101;8"),    new Person("Marcel;1;8;4"),
                new Person("Zita;100;59;5"),      new Person("Damion;48;40;4"),
                new Person("Dona;54;109;4"),      new Person("Elli;57;68;5"),
                new Person("Luther;86;76;4"),     new Person("Alica;61;31;2"),
                new Person("Aletha;37;63;3"),     new Person("Amina;41;105;7"),
            };
        }

        static List<Person> GetPeople2() {
            // Return data from data2.csv
            return new List<Person>() {
                new Person("Valene;57;37;5"),     new Person("Shyla;26;30;3"),
                new Person("Leonarda;10;84;5"),   new Person("Sylvester;56;92;2"),
                new Person("Lionel;79;35;8"),     new Person("Agustin;97;25;8"),
                new Person("Jerald;66;11;0"),     new Person("Edda;35;12;4"),
                new Person("Paz;13;107;6"),       new Person("Caren;7;95;0"),
                new Person("Walter;92;26;7"),     new Person("Kieth;98;78;2"),
                new Person("Aundrea;93;17;5"),    new Person("Jarrett;44;117;8"),
                new Person("Trudi;97;54;9"),      new Person("Carisa;58;69;9"),
                new Person("Marcelo;61;28;5"),    new Person("Mirna;56;34;1"),
                new Person("Israel;58;40;0"),     new Person("Elsa;16;30;4"),
                new Person("Alyson;24;54;4"),     new Person("Justina;47;80;2"),
                new Person("Latonya;55;66;1"),    new Person("Jayson;21;72;3"),
                new Person("Williams;26;94;4"),   new Person("Ivey;34;90;9"),
                new Person("Berry;83;35;10"),     new Person("Cyndy;96;41;2"),
                new Person("Camie;53;59;4"),      new Person("Ramona;22;12;9"),
                new Person("Mohamed;79;64;0"),    new Person("Lucio;5;103;10"),
                new Person("Daniella;94;82;1"),   new Person("Cinthia;82;84;4"),
                new Person("Bernita;11;81;0"),    new Person("Shawnda;23;108;5"),
                new Person("Heath;90;91;5"),      new Person("Corene;3;106;4"),
                new Person("Eryn;48;26;9"),       new Person("Claribel;63;67;8"),
                new Person("Francisca;12;101;6"), new Person("Eleanora;63;84;7"),
                new Person("Arlen;37;79;3"),      new Person("Jody;9;85;3"),
                new Person("Shaunda;64;117;2"),   new Person("Roxy;50;117;5"),
                new Person("Rodger;7;22;8"),      new Person("Robena;34;104;9"),
                new Person("Kena;96;99;3"),       new Person("Danika;6;8;9"),
                new Person("Terrance;3;24;10"),   new Person("Ariel;71;106;3"),
                new Person("Bula;10;33;6"),       new Person("Leland;2;20;6"),
                new Person("Christene;16;49;4"),  new Person("Ka;77;48;1"),
                new Person("Hertha;67;20;9"),     new Person("Hosea;91;104;2"),
                new Person("Paul;17;60;6"),       new Person("Art;10;53;10"),
                new Person("Lanny;12;12;10"),     new Person("Jay;51;101;3"),
                new Person("Junior;1;35;0"),      new Person("Lauren;98;34;3"),
                new Person("Magan;1;55;3"),       new Person("Tory;93;19;9"),
                new Person("Leigha;35;78;8"),     new Person("Felix;55;110;9"),
                new Person("Daine;55;74;4"),      new Person("Nickolas;71;106;4"),
                new Person("Malka;83;95;10"),     new Person("Monte;92;97;5"),
                new Person("Omar;14;53;2"),       new Person("Benito;32;8;8"),
                new Person("Chantal;6;62;2"),     new Person("Pablo;14;45;10"),
                new Person("Obdulia;28;109;8"),   new Person("Roy;8;26;1"),
                new Person("Thanh;13;21;1"),      new Person("Frank;96;118;8"),
                new Person("Marlin;4;91;10"),     new Person("Zackary;75;32;0"),
                new Person("Alia;7;28;7"),        new Person("Barry;87;40;5"),
                new Person("Theo;100;76;8"),      new Person("Clementine;90;19;4"),
                new Person("Aubrey;71;30;9"),     new Person("Phillip;52;44;8"),
                new Person("Josue;25;18;9"),      new Person("Verdell;43;20;8"),
                new Person("Aldo;47;115;8"),      new Person("Natacha;30;98;8"),
                new Person("Alejandrina;41;85;0"),new Person("Ronny;54;111;8"),
                new Person("Ardith;17;16;9"),     new Person("Randal;76;118;0"),
                new Person("Shaina;52;25;10"),    new Person("Forrest;94;5;3"),
                new Person("Rosenda;14;52;7"),    new Person("Noble;97;101;8"),
            };
        }

        public static void Exercise1() {
            try {
               people1 = Person.ReadCSVFile(@"C:\Users\makn\Desktop\dmu_csharp\MK - 2021 efterår\Dag 05 LINQ\Løsninger\SearchAndSortInData\SearchAndSortInData\data1.csv");
            }
            catch (Exception ex) {
                Console.WriteLine("EXCEPTION: " + ex.Message);
                Console.WriteLine("You should probably set the filename to the Person.ReadCSVFile method to something on your disk!");
            }

            var people = people1; 

            // a. All persons with a score below 2
            List<Person> res = people.FindAll(p => p.Score < 2);
            Console.WriteLine("\nScore below 2:");
            res.ForEach(p => Console.WriteLine(p));



            // b.All persons with even score            
            res = people.FindAll(p => p.Score % 2 == 0);
            Console.WriteLine("\nEven Score:");
            res.ForEach(p => Console.WriteLine(p));

            //c.All persons with even score and weight above 60
            res = people.FindAll(p => p.Score % 2 == 0 && p.Weight>60);
            Console.WriteLine("\nEven Score and Weight > 60:");
            res.ForEach(p => Console.WriteLine(p));

            //d.All persons with a weight divisible by 3
            res = people.FindAll(p => p.Weight % 3 == 0);
            Console.WriteLine("\nWeight divisible by 3:");
            res.ForEach(p => Console.WriteLine(p));

        }
        public static void Exercise2()
        {
            var people = people1;

            // a.Use the FindIndex method on the List<T> class to find
            //   the index of the first person with a Score of 3.
            int index = people.FindIndex(p => p.Score == 3);
            Console.WriteLine("\nIndex of first with a score of 3: " + index);

            // b.Use FindIndex to find the index of the first
            // person under 10 years, with a score of 3.
            index = people.FindIndex(p => p.Score == 3 && p.Age < 10);
            Console.WriteLine("First person under 10 years, with a score of 3 : " + index);

            // c.How many people are there under 10 years, with a score of 3?
            var res = people.FindAll(p => p.Score == 3 && p.Age < 10).Count;
            Console.WriteLine("Number of people under 10 years, with a score of 3 : " + res);

            //d.Use FindIndex to find the index of the first person under 8 years, with a score of 3.
            //e.What does the return value mean?
            index = people.FindIndex(p => p.Score == 3 && p.Age < 8);
            Console.WriteLine("First person under 8 years, with a score of 3 : " + index);
            // Index of -1 means that none exists
        }
       
        public static void Exercise3() {
            var people = people1;

            // Sort persons after both Score and Age, (both ascending and descending)
            people.Sort(new Person.SortByAge()); // ascending
            Console.WriteLine("Age-sorted people (ascending)");
            people.Print();

            people.Reverse();
            Console.WriteLine("Age-sorted people (descending)");
            people.Print();

            people.Sort(new Person.SortByScore()); // ascending
            Console.WriteLine("Score-sorted people (ascending)");
            people.Print();

            people.Reverse();
            Console.WriteLine("Score-sorted people (descending)");
            people.Print();
        }

        
        public static void Exercise4()
        {
            var people = people1;

            // people.SetAccepted(p => p.Score >= 6 && p.Age <= 40); 
            people.SetAcceptedP(p => p.Score == 10 && p.Age <= 40);
            Console.WriteLine("\nSetting accepted for young people with a 10 score:");
            people.ForEach(p => Console.WriteLine(p));
        }

        public static void Exercise5() {
            // Sort persons after both Score and Age, (both ascending and descending)
            var people = people1;

            var a = from p in people orderby p.Age select p;
            Console.WriteLine("Age-sorted people (ascending,linq)");
            a.ToList().Print();

            var b = from p in people orderby p.Age descending select p;
            Console.WriteLine("Age-sorted people (descending,linq)");
            b.ToList().Print();

            var c = from p in people orderby p.Score select p;
            Console.WriteLine("Score-sorted people (ascending,linq)");
            c.ToList().Print();

            var d = from p in people orderby p.Score descending select p;
            Console.WriteLine("Score-sorted people (descending,linq)");
            d.ToList().Print();
        }
        /*public static void Exercise6() {
            var people = people1;

            double avg_age = (from p in people select p.Age).Sum();
            avg_age = avg_age / people.Count;

            Console.WriteLine("People sorted by distance to the average Age");
            people.Sort(new Person.SortByAgeDistance(avg_age));
            people.Print();

            Console.WriteLine("People sorted by length of (Weight,Age)");
            people.Sort(new Person.SortByWeightAgeLength());
            people.Print();
        }*/

        public static void Exercise6() {
            int[] numbers = { 34, 8, 56, 31, 79, 150, 88, 7, 200, 47, 88, 20 };

           // 1.Return all two-digit integers sorted in ascending order.
            var a = from an in numbers where an >= 10 && an < 100 orderby an select an;
            foreach (var n in a)
                Console.WriteLine(n);

           // 2.Return all two-digit integers sorted in descending order.
            var b = from an in numbers where an >= 10 && an < 100 orderby an descending select an;
            foreach (var n in b)
                Console.WriteLine(n);

            var c = from an in numbers where an >= 10 && an < 100 orderby an descending select "" + an;
            foreach (var n in c)
                Console.WriteLine(n);

            var d = from an in numbers where an >= 10 && an < 100 orderby an descending select "" + an + (an%2==0?" even": " odd");
            foreach (var n in d)
                Console.WriteLine(n);

                     
        }
        public static void Exercise7() {
            var people = people1;
            
            // Extension solution
            people.Reset();

            // Alternative
            people.ForEach(p => p.Accepted = false);
        }
        public static void Exercise8() {
            
            //Generate a list of 100 random integers. Then use LINQ tok
            Random rnd = new Random();
            List<int> numbers = new List<int>();
            for (int i = 0; i < 100; ++i)
                numbers.Add(rnd.Next());

            // a) Find the number of odd numbers in the list.
            List<int> odd_numbers = (from n in numbers where n % 2 == 1 orderby n select n).ToList();
            int n_odd = odd_numbers.Count();

            // b) Find the number of distinct numbers in the list.            
            int distinct = numbers.Distinct().Count();

            // c) Find the smallest three odd numbers.
            if (n_odd >= 3) {
                int[] smallest_odd_numbers = new int[] { odd_numbers[0], odd_numbers[1], odd_numbers[2], };
            }

            // d) Find all distinct odd numbers.
            int distinct_odd= odd_numbers.Distinct().Count();
        }
        public static void Exercise9() {
            var people = people1;

            var p_res = from p in people
                        group p by p.Name[0] into newp
                        orderby newp.Key
                        select newp;
            foreach (var g in p_res) {
                Console.WriteLine(g.Key);
                foreach (var p in g) {
                    Console.WriteLine(p);
                }
            }
            
        }
        public static void Exercise10() {
            var people1 = GetPeople1();
            var people2 = GetPeople2();

            var joindata = (from p1 in people1
                           join p2 in people2
                           on p1.Name equals p2.Name
                           select new { p1.Name }).Distinct();

            foreach (var d in joindata) {
                Console.WriteLine($"Name : {d.Name}");
            }            
        }

        static void Main(string[] args) {
           // var people1 = new List<Person>();
            //var people1 = Person.ReadCSVFile(@"C:\user\CSharp\Lektion_03\data1.csv");
            //var people2 = Person.ReadCSVFile(@"C:\user\CSharp\Lektion_03\data2.csv");

            Exercise1();
            Exercise2();
            Exercise3();
            Exercise4();
            Exercise5();
            Exercise6();
            Exercise7();
            Exercise8();
            Exercise9();
            Exercise10();

            Console.ReadKey();
        }
    }
}

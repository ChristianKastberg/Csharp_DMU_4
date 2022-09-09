using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAndSortInData {

    public class Person {

        public Person(string data) {
            // Name, Age, Weight, Score 
            var L = data.Split(';');

            Name = L[0];
            Age = int.Parse(L[1]);
            Weight = int.Parse(L[2]);
            Score = int.Parse(L[3]);
            Accepted = false;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public int Score { get; set; }
        public bool Accepted { get; set; }
        public override string ToString() {
            return String.Format("{0,-10} : {1,4} points, {2,4} years, {3,4} kg, {4,4} Accepted", Name, Score, Age, Weight, Accepted?"":"NOT");
        }

        public static List<Person> ReadCSVFile(string filename) {
            List<Person> list = new List<Person>();
            using (var file = new StreamReader(filename)) {
                string line;
                while ((line = file.ReadLine()) != null) {
                    var p = new Person(line);
                    list.Add(p);
                    //Console.WriteLine(p);
                }
            }
            return list;
        }

        public class SortByAge : IComparer<Person> {
            public int Compare(Person x, Person y) {
                return x.Age.CompareTo(y.Age);
            }
        }
        public class SortByScore : IComparer<Person> {
            public int Compare(Person x, Person y) {
                return x.Score.CompareTo(y.Score);
            }
        }
        public class SortByWeight : IComparer<Person> {
            public int Compare(Person x, Person y) {
                return x.Weight.CompareTo(y.Weight);
            }
        }
        public class SortByName : IComparer<Person> {
            public int Compare(Person x, Person y) {
                return x.Name.CompareTo(y.Name);
            }
        }
        public class SortByAgeDistance : IComparer<Person> {
            private double age;
            public SortByAgeDistance(double age) {
                this.age = age;
            }
            public int Compare(Person x, Person y) {
                double xdist = Math.Abs(x.Age - age);
                double ydist = Math.Abs(y.Age - age);
                return xdist.CompareTo(ydist);
            }
        }        
        public class SortByWeightAgeLength : IComparer<Person> {
            public int Compare(Person x, Person y) {
                double xval = Math.Sqrt(x.Weight*x.Weight + x.Age*x.Age);
                double yval = Math.Sqrt(y.Weight*y.Weight + y.Age*y.Age);
                return xval.CompareTo(yval);
            }
        }
    }

    

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace D7_WPF_DataBinding
{
    public class Person
    {
        // fields
        private string name;
        private string weight;
        private string age;
        private string score;
        private bool accepted;

        // properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public string Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Score
        {
            get { return score; }
            set { score = value; }
        }
        public bool Accepted
        {
            get { return accepted; }
            set { accepted = value; }
        }

        public Person(String name, String weight, String age, String score, bool accepted ) 
        {
            this.Name = name;
            this.Weight = weight;
            this.Age = age;
            this.Score = score;
            this.Accepted = accepted;

        }
        

    }
        /// <summary>
        /// Interaction logic for MainWindow.xaml
        /// </summary>
        public partial class MainWindow : Window
    {
        private Person person;
        public MainWindow()
        {
            InitializeComponent();

            person = new Person("Benny","80","32","7", true);

            mainGrid.DataContext = person;
            
        }
    }
}

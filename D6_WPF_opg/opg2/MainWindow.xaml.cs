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

namespace opg2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) // Wrong 
        {
            var x = label1.Content;
            var y = label2.Content;
            x = label2.Content;
            y = label1.Content;


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var x = label3.Content;
            var y = label4.Content;
            x = label4.Content;
            y = label3.Content;
        }
    }
}

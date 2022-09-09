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

namespace D6_WPF_App
{
    /// <summary>
    /// Interaction logic for ExspenseItHome.xaml
    /// </summary>
    public partial class ExspenseItHome : Page
    {
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //View Exspense report 
            ExspenseReportPage exspenseReportPage = new ExspenseReportPage(this.peopleListBox.SelectedItem);
            this.NavigationService.Navigate(exspenseReportPage);
        }
        public ExspenseItHome()
        {
            InitializeComponent();
        }
    }
}

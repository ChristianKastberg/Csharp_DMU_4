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
    /// Interaction logic for ExspenseReportPage.xaml
    /// </summary>
    public partial class ExspenseReportPage : Page
    {
        public ExspenseReportPage()
        {
            InitializeComponent();
        }
        // Custom constructor to pass expense report data
        public ExspenseReportPage(object data) : this()
        {
            // Bind to expense report data.
            this.DataContext = data;
        }
    }
}

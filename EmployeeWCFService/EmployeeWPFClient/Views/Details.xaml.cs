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
using EmployeeWPFClient.ViewModel;

namespace EmployeeWPFClient.Views
{
    /// <summary>
    /// Logique d'interaction pour Details.xaml
    /// </summary>
    public partial class Details : UserControl
    {
        public Details()
        {
            InitializeComponent();
            DataContext = new DetailsVm();
        }
    }
}

using EmployeeWPFClient.Models;
using EmployeeWPFClient.ServiceReference;
using EmployeeWPFClient.ViewModel;
using MahApps.Metro.Controls;
using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Windows;

namespace EmployeeWPFClient
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        MainWindowViewModel _vm = new MainWindowViewModel();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = _vm;
        }

        public void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                _vm.EmployeeList = new ObservableCollection<EmployeeObj>();

                //IEnumerable emploeeList = _vm.EmployeeService.GetAllEmployees();
                IEnumerable emploeeList = _vm.EmployeeService.GetAllEmployeesDummy();


                foreach (Employee item in emploeeList)
                {
                    _vm.EmployeeList.Add(new EmployeeObj
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Gender = item.Gender,
                        Dateofb = item.Dateofb
                    });
                }
            }
            catch (Exception ex)
            {
                _vm.UserNotification = ex.Message;
            }

        }
    }
}

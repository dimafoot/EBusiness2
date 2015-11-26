using EmployeeWPFClient.Models;
using EmployeeWPFClient.ServiceReference;
using EmployeeWPFClient.ViewModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EmployeeWPFClient.Commands
{
    public class GetAllEmployeesCmd : ICommand
    {
        private MainWindowViewModel _source;

        public event EventHandler CanExecuteChanged;

        public MainWindowViewModel Source
        {
            get { return _source; }
            set { _source = value; }
        }

        public GetAllEmployeesCmd(MainWindowViewModel source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
            _source = source;
        }


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            try
            {
                _source.EmployeeList = new ObservableCollection<EmployeeObj>();

                //IEnumerable emploeeList = _source.EmployeeService.GetAllEmployees();
                IEnumerable emploeeList = _source.EmployeeService.GetAllEmployeesDummy();


                foreach (Employee item in emploeeList)
                {
                    _source.EmployeeList.Add(new EmployeeObj
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
                _source.UserNotification = ex.Message;
            }
        }
    }

}

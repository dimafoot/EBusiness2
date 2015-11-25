using EmployeeWPFClient.Models;
using EmployeeWPFClient.ServiceReference;
using EmployeeWPFClient.ViewModel;
using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace EmployeeWPFClient.Commands
{
    public class GetEmployeeCmd : ICommand
    {
        private MainWindowViewModel _source;

        public MainWindowViewModel Source
        {
            get { return _source; }
            set { _source = value; }
        }

        public GetEmployeeCmd(MainWindowViewModel source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
            _source = source;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            try
            {
                Employee employee = _source.EmployeeService.GetEmployeeDB(_source.Id);

                _source.Employee = new EmployeeObj()
                {
                    Id = employee.Id,
                    Name = employee.Name,
                    Gender = employee.Gender,
                    Dateofb = employee.Dateofb,
                    Type = Models.EmployeeType.FullTimeEmployee
                };

                _source.UserNotification = "Employee retrieved";
            }
            catch (Exception ex)
            {
                _source.UserNotification = ex.Message ;
            }
        }
    }
}

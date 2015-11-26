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

                if (employee.Type.ToString() == "FullTimeEmployee")
                {
                    _source.Employee = new FullTimeEmployeeObj()
                    {
                        Id = employee.Id,
                        Name = employee.Name,
                        Gender = employee.Gender,
                        Dateofb = employee.Dateofb,
                        Type = (EmployeeTypeObj)employee.Type, 
                        AnnualSalary = ((FullTimeEmployee)employee).AnnualSalary
                    };

                    _source.FeIsEnabled = "Visible";
                    _source.PeIsEnabled = "Hidden";

                    _source.SelectedType = 1;
                }
                else if (employee.Type.ToString() == "PartTimeEmployee")
                {
                    _source.Employee = new PartTimeEmployeeObj()
                    {
                        Id = employee.Id,
                        Name = employee.Name,
                        Gender = employee.Gender,
                        Dateofb = employee.Dateofb,
                        Type = (EmployeeTypeObj)employee.Type,
                        HourlyPay = ((PartTimeEmployee)employee).HourlyPay,
                        HoursWorked = ((PartTimeEmployee)employee).HoursWorked
                    };

                    _source.PeIsEnabled = "Visible";
                    _source.FeIsEnabled = "Hidden";
                    _source.SelectedType = 2;
                }
                else
                {
                    _source.SelectedType = 0;
                    _source.UserNotification = "Please select an employee";
                }

                _source.UserNotification = "Employee retrieved";
            }
            catch (Exception ex)
            {
                _source.UserNotification = ex.Message ;
            }
        }
    }
}

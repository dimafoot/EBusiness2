using EmployeeWPFClient.Models;
using EmployeeWPFClient.ServiceReference;
using EmployeeWPFClient.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EmployeeWPFClient.Commands
{
    public class SaveEmployeeCmd : ICommand
    {
        private MainWindowViewModel _source;

        public MainWindowViewModel Source
        {
            get { return _source; }
            set { _source = value; }
        }

        public SaveEmployeeCmd(MainWindowViewModel source)
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
                if (_source.SelectedType == 1)
                {
                    Employee employee = new Employee();

                    employee = new FullTimeEmployee
                    {
                        Id = _source.Employee.Id,
                        Name = _source.Employee.Name,
                        Gender = _source.Employee.Gender,
                        Dateofb = _source.Employee.Dateofb,
                        Type = EmployeeType.FullTimeEmployee,
                        AnnualSalary = ((FullTimeEmployeeObj)_source.Employee).AnnualSalary
                    };

                    _source.EmployeeService.SaveEmployee(employee);
                    _source.UserNotification = "Full Time Employee saved";
                    _source.GetAllEmployees();
                }
                else if (_source.SelectedType == 2)
                {
                    Employee employee = new Employee();

                    employee = new PartTimeEmployee
                    {
                        Id = _source.Employee.Id,
                        Name = _source.Employee.Name,
                        Gender = _source.Employee.Gender,
                        Dateofb = _source.Employee.Dateofb,
                        Type = EmployeeType.PartTimeEmployee,
                        HourlyPay = ((PartTimeEmployeeObj)_source.Employee).HourlyPay,
                        HoursWorked = ((PartTimeEmployeeObj)_source.Employee).HoursWorked
                    };

                    _source.EmployeeService.SaveEmployee(employee);
                    _source.UserNotification = "Part Time Employee saved";
                    _source.GetAllEmployees();
                }
                else
                {
                    _source.UserNotification = "Please select an employee";
                }

            }
            catch (Exception ex)
            {
                _source.UserNotification = ex.Message;
            }
        }
    }
}

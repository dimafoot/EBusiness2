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
                IEmployeeService client = new EmployeeServiceClient();


                client.SaveEmployee(new Employee
                {
                    Id = _source.Employee.Id,
                    Name = _source.Employee.Name,
                    Gender = _source.Employee.Gender,
                    Dateofb = _source.Employee.Dateofb
                });

                Employee employee = client.GetEmployeeDB(_source.Id);


                _source.Employee = new Models.EmployeeObj()
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
                _source.UserNotification = ex.Message;
            }
        }
    }
}

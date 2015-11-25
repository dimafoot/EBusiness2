using EmployeeWPFClient.Commands;
using EmployeeWPFClient.Models;
using EmployeeWPFClient.ServiceReference;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace EmployeeWPFClient.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {

        #region champs

        private int _id = 1;
        private EmployeeObj _employee;
        private string _userNotification;

        private ObservableCollection<EmployeeObj> _employeeList;

        IEmployeeService _employeeService;


        #endregion

        #region Get/Set

        public int Id
        {
            get { return _id; }
            set { _id = value; OnPropertyChanged("Id"); }
        }

        public ICommand GetEmployeeCmd { get; }

        public ICommand SaveEmployeeCmd { get; }

        public ICommand WindowsLoadCmd { get; }
        

        public EmployeeObj Employee
        {
            get { return _employee; }

            set { _employee = value; OnPropertyChanged("Employee"); }
        }

        public string UserNotification
        {
            get { return _userNotification; }

            set { _userNotification = value; OnPropertyChanged("UserNotification"); }
        }

        public ObservableCollection<EmployeeObj> EmployeeList
        {
            get
            {
                return _employeeList;
            }

            set
            {
                _employeeList = value; OnPropertyChanged("EmployeeList");
            }
        }

        public IEmployeeService EmployeeService
        {
            get
            {
                return _employeeService;
            }

        }

        #endregion




        public MainWindowViewModel()
        {
            GetEmployeeCmd = new GetEmployeeCmd(this);
            SaveEmployeeCmd = new SaveEmployeeCmd(this);
            WindowsLoadCmd = new WindowsLoadCmd(this);

            _employeeService = new EmployeeServiceClient();

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

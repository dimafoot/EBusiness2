using EmployeeWPFClient.Commands;
using EmployeeWPFClient.Models;
using EmployeeWPFClient.ServiceReference;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System;

namespace EmployeeWPFClient.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {

        #region champs

        private int _id = 0;
        private EmployeeObj _employee;
        private string _userNotification;
        private int _selectedType = 0;

        private string _feIsEnabled = "Hidden";
        private string _peIsEnabled = "Hidden";

        private DetailsVm _detailsVm;




        private ObservableCollection<EmployeeObj> _employeeList;

        IEmployeeService _employeeService;

        private EmployeeObj _selectedEmployee;


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

        public EmployeeObj SelectedEmployee
        {
            get
            {
                return _selectedEmployee;
            }

            set
            {
                _selectedEmployee = value; OnPropertyChanged("SelectedEmployee");

                if (SelectedEmployee != null)
                {
                    Id = SelectedEmployee.Id;
                }
                GetEmployeeCmd.Execute(this);
            }
        }

        public int SelectedType
        {
            get
            {
                return _selectedType;
            }

            set
            {
                _selectedType = value; OnPropertyChanged("SelectedType");
            }
        }

        public string FeIsEnabled
        {
            get {  return _feIsEnabled; }

            set {  _feIsEnabled = value; OnPropertyChanged("FeIsEnabled"); }
        }

        public string PeIsEnabled
        {
            get { return _peIsEnabled; }

            set { _peIsEnabled = value; OnPropertyChanged("PeIsEnabled"); }
        }

        public DetailsVm DetailsVm
        {
            get { return _detailsVm; }
            set { _detailsVm = value; OnPropertyChanged("DetailsVm"); }
        }

        #endregion




        public MainWindowViewModel()
        {
            _detailsVm = new DetailsVm();
            GetEmployeeCmd = new GetEmployeeCmd(this);
            SaveEmployeeCmd = new SaveEmployeeCmd(this);
            WindowsLoadCmd = new GetAllEmployeesCmd(this);

            _employeeService = new EmployeeServiceClient();

        }

        internal void GetAllEmployees()
        {
            WindowsLoadCmd.Execute(this);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

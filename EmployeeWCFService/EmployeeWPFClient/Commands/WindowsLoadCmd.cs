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
    public class WindowsLoadCmd : ICommand
    {
        private MainWindowViewModel _source;

        public event EventHandler CanExecuteChanged;

        public MainWindowViewModel Source
        {
            get { return _source; }
            set { _source = value; }
        }

        public WindowsLoadCmd(MainWindowViewModel source)
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
            
        }
    }

}

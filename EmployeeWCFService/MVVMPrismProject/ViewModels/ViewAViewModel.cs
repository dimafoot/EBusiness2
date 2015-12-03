using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;

namespace MVVMPrismProject.ViewModels
{
    public class ViewAViewModel : BindableBase
    {

        private string _firstName = "LAMGHARI" ;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                SetProperty(ref _firstName, value);
                //UpdatedCommand.RaiseCanExecuteChanged();
            }
        }

        private string _lastName ;

        public string LastName
        {
            get { return _lastName; }
            set
            {
                SetProperty(ref _lastName, value);
                //UpdatedCommand.RaiseCanExecuteChanged();
            }
        }

        private DateTime? _lastUpdated;

        public DateTime? LastUpdated
        {
            get { return _lastUpdated; }
            set { SetProperty(ref _lastUpdated, value); }
        }

        public DelegateCommand UpdatedCommand { get; set; }

        public ViewAViewModel()
        {
            //UpdatedCommand = new DelegateCommand(Execute,CanExecute);
            UpdatedCommand = new DelegateCommand(Execute, CanExecute).ObservesProperty(() => FirstName).ObservesProperty(() => LastName);
        }

        private bool CanExecute()
        {
            return !string.IsNullOrWhiteSpace(FirstName) && !string.IsNullOrWhiteSpace(LastName);
        }

        private void Execute()
        {
            LastUpdated = DateTime.Now;
        }
    }

    //static class ViewModelLocator
    //{
    //    static ViewAViewModel ViewAViewModel { get; set; }
    //}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using PrismProjectMVVM2.Events;

namespace PrismProjectMVVM2.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        private string _firstName ;

        public string FirstName
        {
            get { return _firstName; }
            set { SetProperty(ref _firstName, value); }
        }

        private DateTime? _lastUpdated;

        public DateTime? LastUpdated
        {
            get { return _lastUpdated; }
            set { SetProperty(ref _lastUpdated, value); }
        }

        private readonly IEventAggregator _eventAggregator;


        public DelegateCommand UpdatedCommand { get; set; }



        public ViewAViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            UpdatedCommand = new DelegateCommand(Execute, CanExecute).ObservesProperty(() => FirstName);
        }

        private bool CanExecute()
        {
            return !string.IsNullOrWhiteSpace(FirstName);
        }

        private void Execute()
        {
            LastUpdated = DateTime.Now;
            _eventAggregator.GetEvent<UpdateEvent>().Publish(LastUpdated.ToString());
        }
    }
}

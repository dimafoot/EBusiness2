using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using PrismSampleMVVM.Events;

namespace PrismSampleMVVM.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        private string _firstName="LAMGHARI";

        private readonly IEventAggregator _eventAggregator;

        public string FirstName
        {
            get { return _firstName; }
            set { SetProperty(ref _firstName, value); }
        }

        private DateTime? _lastUpdate;

        public DateTime? LastUpdate
        {
            get { return _lastUpdate; }
            set { SetProperty(ref _lastUpdate, value); }
        }

        public DelegateCommand UpdateCommand { get; set; }

        public ViewAViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            UpdateCommand = new DelegateCommand(Execute,CanExecute).ObservesProperty(() => FirstName);
        }

        private bool CanExecute()
        {
            return !string.IsNullOrWhiteSpace(FirstName);
        }

        private void Execute()
        {
            LastUpdate = DateTime.Now;
            _eventAggregator.GetEvent<UpdateEvent>().Publish(LastUpdate.ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using PrismMVVMProject.Events;

namespace PrismMVVMProject.ViewModels
{
    public class WinBaseViewModel : BindableBase
    {
        private readonly IEventAggregator _eventAggregator;


        private string _name="Me";

        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private DateTime? _lastUpdate;

        public DateTime? LastUpdate
        {
            get { return _lastUpdate; }
            set { SetProperty(ref _lastUpdate, value); }
        }


        public DelegateCommand UpdateCommand { get; set; }
        public WinBaseViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            //UpdateCommand = new DelegateCommand(Execute, CanExecute).ObservesProperty(() => Name);
        }

        private bool CanExecute()
        {
            return !string.IsNullOrWhiteSpace(Name);
        }

        private void Execute()
        {
            LastUpdate = DateTime.Now;
            _eventAggregator.GetEvent<UpdateEvent>().Publish(LastUpdate.ToString());
        }


        #region IRegionManager

        private readonly IRegionManager _regionManager;

        public DelegateCommand<string> NavigateCommand { get; set; }

        public WinBaseViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            NavigateCommand = new DelegateCommand<string>(Navigate);
        }

        private void Navigate(string obj)
        {
            _regionManager.RequestNavigate("ContentRegion", obj);
        }


        #endregion

    }
}

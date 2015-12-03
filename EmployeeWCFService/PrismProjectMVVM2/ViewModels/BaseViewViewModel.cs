using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace PrismProjectMVVM2.ViewModels
{
    public class BaseViewViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;

        private DateTime? _lastUpdated;

        public DateTime? LastUpdated
        {
            get { return _lastUpdated; }
            set { SetProperty(ref _lastUpdated, value); }
        }


        public DelegateCommand NavigateCommand { get; set; }
        public DelegateCommand<string> NavigateCommand2 { get; set; }


        public BaseViewViewModel()
        {
            NavigateCommand = new DelegateCommand(Navigate);
            _regionManager = new RegionManager();
            NavigateCommand2 = new DelegateCommand<string>(Navigate);

        }

        public BaseViewViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            NavigateCommand2 = new DelegateCommand<string>(Navigate);
        }

        private void Navigate()
        {
            LastUpdated = DateTime.Now;
        }

        private void Navigate(string uri)
        {
            _regionManager.RequestNavigate("ContentRegion", uri);
        }

    }
}

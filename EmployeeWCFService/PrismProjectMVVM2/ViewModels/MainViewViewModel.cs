using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace PrismProjectMVVM2.ViewModels
{
    public class MainViewViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;

        public DelegateCommand<string> NavigateCommand { get; set; }


        public MainViewViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            NavigateCommand = new DelegateCommand<string>(Navigate);

        }

        private void Navigate(string uri)
        {
            _regionManager.RequestNavigate("ContentRegion", uri);
        }
    }
}

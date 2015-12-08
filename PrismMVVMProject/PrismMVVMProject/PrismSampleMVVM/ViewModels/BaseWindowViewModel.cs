using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace PrismSampleMVVM.ViewModels
{
    public class BaseWindowViewModel : BindableBase
    {

        #region IRegionManager

        private readonly IRegionManager _regionManager;

        public DelegateCommand<string> NavigateCommand { get; set; }
        public DelegateCommand<string> NavigateCommand2 { get; set; }


        public BaseWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            NavigateCommand = new DelegateCommand<string>(Navigate);
            NavigateCommand2 = new DelegateCommand<string>(Navigate2);

        }

        private void Navigate(string obj)
        {
            _regionManager.RequestNavigate("ContentRegion", obj);
        }

        private void Navigate2(string obj)
        {
            _regionManager.RequestNavigate("ContentRegion2", obj);
        }

        #endregion
    }
}

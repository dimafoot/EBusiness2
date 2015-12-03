using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using EmployeeWPFClient.Annotations;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace MVVMPrismProject.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;

        public DelegateCommand<string> NavigateCommand { get; set; }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            NavigateCommand = new DelegateCommand<string>(Navigate);
        }

        private void Navigate(string uri)
        {
            _regionManager.RequestNavigate("ContentRegion",uri);
        }
    }
}

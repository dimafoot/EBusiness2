using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMPrismProject.Events;
using Prism.Events;
using Prism.Mvvm;

namespace PrismProjectMVVM2.ViewModels
{
    public class ViewBViewModel : BindableBase
    {
        private string _message = "ViewB ";

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public ViewBViewModel(IEventAggregator eventAggregator)
        {
            eventAggregator.GetEvent<UpdateEvent>().Subscribe(Updated);
        }

        private void Updated(string obj)
        {
            Message = obj;
        }
    }
}

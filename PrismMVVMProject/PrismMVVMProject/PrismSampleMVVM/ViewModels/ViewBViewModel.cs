using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Events;
using Prism.Mvvm;
using PrismSampleMVVM.Events;

namespace PrismSampleMVVM.ViewModels
{
    public class ViewBViewModel : BindableBase
    {
        private string _messageB ;

        public string MessageB
        {
            get { return _messageB; }
            set { SetProperty(ref _messageB, value); }
        }


        public ViewBViewModel(IEventAggregator eventAggregator)
        {
            eventAggregator.GetEvent<UpdateEvent>().Subscribe(Updated);
        }

        private void Updated(string obj)
        {
            MessageB = obj;
        }
    }
}

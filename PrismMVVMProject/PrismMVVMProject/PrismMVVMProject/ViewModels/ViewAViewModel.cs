using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Events;
using Prism.Mvvm;
using PrismMVVMProject.Events;

namespace PrismMVVMProject.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        private string _messageA;

        public string MessageA
        {
            get { return _messageA; }
            set { SetProperty(ref _messageA, value); }
        }

        public ViewAViewModel(IEventAggregator eventAggregator)
        {
            //eventAggregator.GetEvent<UpdateEvent>().Subscribe(Updated);
        }

        private void Updated(string obj)
        {
            MessageA = obj;
        }
    }
}

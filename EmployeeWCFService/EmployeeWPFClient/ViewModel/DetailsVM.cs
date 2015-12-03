using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using EmployeeWPFClient.Annotations;

namespace EmployeeWPFClient.ViewModel
{
    public class DetailsVm : INotifyPropertyChanged
    {
        private string _textItem = "Test";


        public DetailsVm()
        {
                
        }


        public string TextItem
        {
            get { return _textItem; }
            set { _textItem = value; OnPropertyChanged("TextItem");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

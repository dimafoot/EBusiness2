using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using ProjectPismMVVMRelease.Events;
using ProjectPismMVVMRelease.Models;

namespace ProjectPismMVVMRelease.ViewModels
{

    public class ViewAViewModel : BindableBase
    {
        public ObservableCollection<Client> ListClients { get; set; }

        private string _firstName ;

        private readonly IEventAggregator _eventAggregator;

        private int _countList;

        public int CountList
        {
            get { return _countList; }
            set { SetProperty(ref _countList, value); }
        }

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

        private int _idToRemove;

        public int IdToRemove
        {
            get { return _idToRemove; }
            set { SetProperty(ref _idToRemove,value); }
        }

        public DelegateCommand RemoveCommand { get; set; }

        public DelegateCommand UpdateCommand { get; set; }

        public ViewAViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            UpdateCommand = new DelegateCommand(Execute, CanExecute).ObservesProperty(() => FirstName);

            RemoveCommand = new DelegateCommand(RemoveExecute, RemoveCanExecute).ObservesProperty(() => IdToRemove);

            eventAggregator.GetEvent<UpdateListClientEvent>().Subscribe(ListClientUpdated);
        }

        private bool RemoveCanExecute()
        {
            return true;
        }

        private void RemoveExecute()
        {
            if (ListClients.Count < IdToRemove + 1) return;

            var cl = new Client
            {
                Id = ListClients[IdToRemove + 1].Id,
                Name = ListClients[IdToRemove + 1].Name,
                CreationDate = ListClients[IdToRemove + 1].CreationDate
            };

            _eventAggregator.GetEvent<RemoveClientEvent>().Publish(cl);
        }

        private void ListClientUpdated(ObservableCollection<Client> obj)
        {
            ListClients = obj;
            CountList = obj.Count;
        }

        private bool CanExecute()
        {
            return !string.IsNullOrWhiteSpace(FirstName);
        }

        private void Execute()
        {
            LastUpdate = DateTime.Now;

            var cl = new Client
            {
                Id = CountList + 1,
                Name = FirstName,
                CreationDate = DateTime.Now
            };

            _eventAggregator.GetEvent<UpdateEvent>().Publish(LastUpdate.ToString());
            _eventAggregator.GetEvent<UpdateClientEvent>().Publish(cl);
        }
    }

}

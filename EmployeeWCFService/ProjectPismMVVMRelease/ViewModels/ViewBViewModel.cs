using System;
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
    public class ViewBViewModel : BindableBase
    {
        private readonly IEventAggregator _eventAggregator;

        private Client _client;

        public Client Client
        {
            get { return _client; }
            set
            {
                SetProperty(ref _client, value);
            }
        }

        //private List<Client> _clients = new List<Client>();

        //public List<Client> Clients
        //{
        //    get { return _clients; }
        //    set { SetProperty(ref _clients, value); }
        //}


        private  ObservableCollection<Client> _clients = new ObservableCollection<Client>() ;

        public ObservableCollection<Client> Clients
        {
            get { return _clients; }
            set { SetProperty(ref _clients, value); }
        }

        private int _idToRemove;

        public int IdToRemove
        {
            get { return _idToRemove; }
            set { SetProperty(ref _idToRemove, value); }
        }

        public DelegateCommand RemoveCommand { get; set; }


        private string _messageB;

        public string MessageB
        {
            get { return _messageB; }
            set
            {
                SetProperty(ref _messageB, value);
                //_eventAggregator.GetEvent<UpdateListClient>().Publish(_clients);
            }
        }


        public ViewBViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;

            eventAggregator.GetEvent<UpdateEvent>().Subscribe(Updated);
            eventAggregator.GetEvent<UpdateClientEvent>().Subscribe(ClientUpdated);

            RemoveCommand = new DelegateCommand(RemoveExecute, RemoveCanExecute).ObservesProperty(() => IdToRemove);

        }

        private bool RemoveCanExecute()
        {
            return true;
        }

        private void RemoveExecute()
        {
            _clients.Remove((Client)Clients[IdToRemove]);

            //_clients.Remove((Client) Clients.Where( o => o.Id.Equals(IdToRemove)));
        }

        private void ClientUpdated(Client obj)
        {
            Client = obj;
            Clients.Add(obj);
            _eventAggregator.GetEvent<UpdateListClientEvent>().Publish(_clients);

        }

        private void Updated(string obj)
        {
            MessageB = obj;
        }
    }
}

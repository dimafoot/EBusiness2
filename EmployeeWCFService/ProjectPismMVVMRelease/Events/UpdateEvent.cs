using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Events;
using ProjectPismMVVMRelease.Models;

namespace ProjectPismMVVMRelease.Events
{
    public class UpdateEvent : PubSubEvent<String>
    {
    }

    public class UpdateClientEvent : PubSubEvent<Client>
    {
    }

    public class RemoveClientEvent : PubSubEvent<Client>
    {
    }

    public class UpdateListClientEvent : PubSubEvent<ObservableCollection<Client>>
    {
    }
}

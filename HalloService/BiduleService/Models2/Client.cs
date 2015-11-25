using System.Collections.Generic;

namespace BiduleService
{
    public class Client
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }


        public static List<Client> getClients()
        {
            List<Client> clients = new List<Client>();
 
            Client client1 = new Client()
            {
                Id = 1, Nom = "LAMGHARI",Prenom = "Mohammed"
            };
            clients.Add(client1);

            Client client2 = new Client()
            {
                Id = 2,
                Nom = "AmraniI",
                Prenom = "Mohammed"
            };
            clients.Add(client2);

            Client client3 = new Client()
            {
                Id = 3,
                Nom = "Mojarni",
                Prenom = "Mohammed"
            };
            clients.Add(client3);

            return clients;
        } 
    }
}
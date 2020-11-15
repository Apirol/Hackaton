using System;
using System.Collections.Generic;
using System.Text;
using Data.DB;
using Data.Models;
using Service.ClientService;
using System.Linq;

namespace Service.ClientService
{
    public class ClientService : IClientService
    {
        private readonly DB db;


        public ClientService(DB db)
        {
            this.db = db;
        }

        public void AddClient(Client client)
        {
            db.Client.Add(client);
            db.SaveChanges();
        }

        public void DeleteClient(Client client)
        {
            db.Client.Remove(client);
        }

        public List<Client> GetAllClients()
        {
            return db.Client.ToList();
        }

        public Client GetClient(Guid id)
        {
            return db.Client.ToList().Find(x => x.ID == id);
        }
    }
}

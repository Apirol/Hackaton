using System;
using System.Collections.Generic;
using Data.Models;

namespace Service.ClientService
{
    public interface IClientService
    {
        void AddClient(Client client);
        void DeleteClient(Client client);

        Client GetClient(Guid id);
    }
}

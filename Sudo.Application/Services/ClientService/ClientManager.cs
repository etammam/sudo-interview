using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sudo.Application.Persistence;
using Sudo.Application.Persistence.Database.Entities;

namespace Sudo.Application.Services.ClientService
{
    public class ClientManager : IClient
    {
        private readonly IStore _storeManager;

        public ClientManager(IStore storeManager)
        {
            _storeManager = storeManager;
        }

        public void SubmitNewClient(Client client)
        { 
            _storeManager.StoreToJson(client);
        }
    }
}

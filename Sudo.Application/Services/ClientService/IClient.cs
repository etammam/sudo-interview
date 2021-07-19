using System.Threading.Tasks;
using Sudo.Application.Persistence.Database.Entities;

namespace Sudo.Application.Services.ClientService
{
    public interface IClient
    {
        void SubmitNewClient(Client client);
    }
}

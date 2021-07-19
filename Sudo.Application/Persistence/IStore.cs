using System.Threading.Tasks;

namespace Sudo.Application.Persistence
{
    public interface IStore
    {
        string GenerateNewJsonFile();
        void StoreToJson(object value);
    }
}

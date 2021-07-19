using Microsoft.AspNetCore.Mvc;
using Sudo.APIs.Utilities;
using Sudo.Application.Persistence.Database.Entities;
using Sudo.Application.Services.ClientService;

namespace Sudo.APIs.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClient _clientManager;

        public ClientController(IClient clientManager)
        {
            _clientManager = clientManager;
        }
        [HttpPost(Router.Client.Create)]
        public IActionResult CreateNewClient([FromBody]Client client)
        {
            _clientManager.SubmitNewClient(client);
            return Ok();
        }
    }
}
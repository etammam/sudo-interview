using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sudo.Application.Persistence.Database.Entities;
using Sudo.Application.Services.ClientService;
using Sudo.WebApp.Models;

namespace Sudo.WebApp.Pages
{
    public class Submission : PageModel
    {
        private readonly IClient _clientService;

        public Submission(IClient clientService)
        {
            _clientService = clientService;
        }

        [BindProperty]
        public ClientVm Client { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            var client = new Client(){
                FirstName = Client.FirstName,
                LastName = Client.LastName,
                Email = Client.Email,
                Subscribed = Client.Subscribed,
                DateOfBirth = Client.DateOfBirth
            };
            _clientService.SubmitNewClient(client);
            return RedirectToPage("./Submitted");
        }
    }
}

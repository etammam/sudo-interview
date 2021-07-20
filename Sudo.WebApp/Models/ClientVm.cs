using System;
using System.ComponentModel.DataAnnotations;

namespace Sudo.WebApp.Models
{
    public class ClientVm
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [EmailAddress(ErrorMessage = "please type a valid email address")]
        [Required]
        public string Email { get; set; }
        public bool Subscribed { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}

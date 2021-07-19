using System;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Sudo.Application.Persistence.Database.Entities
{
    public class Client
    {
        [JsonPropertyName("firstName")]
        [JsonProperty("firstName")]
        public string FirstName { get; set; }
        [JsonPropertyName("last_name")]
        [JsonProperty("last_name")]
        public string LastName { get; set; }
        [JsonPropertyName("emailAddress")]
        [JsonProperty("emailAddress")]
        public string Email { get; set; }
        public bool Subscribed { get; set; }
        [JsonPropertyName("dob")]
        [JsonProperty("dob")]
        public DateTime DateOfBirth { get; set; }
    }
}

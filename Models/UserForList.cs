using BlazorSignupForm.Models;
using Newtonsoft.Json;

namespace BlazorSignupForm.Services.Interfaces
{
    public class UserForList
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("gender")]
        public Gender Gender { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("photo")]
        public string Photo { get; set; }
    }
}
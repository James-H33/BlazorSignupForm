using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BlazorSignupForm.Models;
using BlazorSignupForm.Services.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace BlazorSignupForm.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient _http;
        private readonly string _baseUrl = "http://localhost:3000";

        public UserService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<UserForList>> GetAll()
        {
            try {
                var response = await _http.GetAsync($"{_baseUrl}/user");
                var result = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<UserForList>>(result);
            } catch (Exception err) {
                Console.WriteLine(err);
                return new List<UserForList>();
            }
        }

        public async Task<bool> Signup(UserSignup model)
        {
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            var payload = JsonConvert.SerializeObject(model, settings);
            var content = new StringContent(payload, Encoding.UTF8, "application/json");

            try {
                var response = await _http.PostAsync($"{_baseUrl}/user/signup", content);
                var result = await response.Content.ReadAsStringAsync();
                return true;
            } catch (Exception err) {
                Console.WriteLine(err);
                return false;
            }
        }
    }
}
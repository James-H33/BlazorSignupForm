using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorSignupForm.Models;

namespace BlazorSignupForm.Services.Interfaces
{
    public interface IUserService
    {
        Task<bool> Signup(UserSignup model);
        Task<List<UserForList>> GetAll();
    }
}
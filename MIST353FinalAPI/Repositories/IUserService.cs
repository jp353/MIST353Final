using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MIST353FinalAPI.Entities;

namespace MIST353FinalAPI.Repositories
{
    public interface IUserService 
    {
        public Task<List<User>> GetUserData(int UID);
        public Task<ActionResult<int>> AddUser(User user);

    }
}

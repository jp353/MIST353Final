using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using MIST353FinalAPI.Entities;
using MIST353FinalAPI.Repositories;


namespace MIST353FinalAPI.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    [ApiController]
    public class UserServiceController
    {
        private readonly IUserService userService;

        public UserServiceController(IUserService userService)
        {
            this.userService = userService;
        }
        [HttpGet("{UID}")]
        public async Task<List<User>> GetUserData(int UID)
        {
            var userData = await userService.GetUserData(UID);
            return userData;
        }
        [HttpPost("/addUser")]
        public async Task<ActionResult<int>> AddUser(User user)
        {
            var userDetails = await userService.AddUser(user);
            return userDetails;

        }
    }
}

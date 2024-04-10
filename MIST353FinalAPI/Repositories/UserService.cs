using MIST353FinalAPI.Data;
using MIST353FinalAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace MIST353FinalAPI.Repositories
{
    public class UserService : IUserService
    {
        private readonly DbContextClass _dbContextClass;
        public UserService(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public async Task<List<User>> GetUserData(int UID)
        {
            var param = new SqlParameter("@UID", UID);

            var userData = await Task.Run(() => _dbContextClass.User.FromSqlRaw("exec spUserData @UID", param).ToListAsync());
            return userData;
        }

        public async Task<ActionResult<int>> AddUser (User user)
        {
            var userFirstName = new SqlParameter("@UFName", user.UFName);
            var userLastName = new SqlParameter("@ULName", user.ULName);
            var userPassword = new SqlParameter("@UPassword", user.UPassword);
            var userEmail = new SqlParameter("@UEmail", user.UEmail);

            var userDetails = await Task.Run(() => _dbContextClass.Database.ExecuteSqlRaw("exec spAddUser @UFName,@ULName,@UPassword,@UEamil", userFirstName, userLastName, userPassword, userEmail));
            return userDetails;

        }
    }
}

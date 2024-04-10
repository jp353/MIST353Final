// Created by Kayla Guyton
using MIST353FinalAPI.Data;
using MIST353FinalAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlTypes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MIST353FinalAPI.Repositories
{
    public class PostSub : IPostSub
    {
        private readonly DbContextClass _dbContextClass;
        public PostSub(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }

        // output should be ActionResult<int>. See class code for how to do a post.
        public async Task<ActionResult<int>> CartAddSubscription(int cartid, DateTime cdate, decimal price, int subid)
        {
            var cartidparam = new SqlParameter("@CartID", cartid);
            var cdateparam = new SqlParameter("@CDate", cdate);
            var moneyparam = new SqlParameter("@Price", price);
            var subidparam = new SqlParameter("@SubID", subid);

            // This line was wrong. See class code for how to do a post.
            var subscriptionDetails = await Task.Run(() => _dbContextClass.Database.ExecuteSqlRaw("exec spCartAddSubscription @CartID, @CDate, @Price, @SubID", cartidparam, cdateparam, moneyparam, subidparam));
            return subscriptionDetails;

        }
    }
 }

// Created by Kayla Guyton
using MIST353FinalAPI.Data;
using MIST353FinalAPI.Entities;
using MIST353FinalAPI.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace MIST353FinalAPI.Repositories
{

   public class CartService : ICartService
    {
        private readonly DbContextClass _dbContext;
        public CartService(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Cart>> GetCartID(int CartID)
        {
            var param = new SqlParameter("CartID", CartID);
            var cartDetails = await Task.Run(() => _dbContext.Cart.FromSqlRaw("spCartViewByCartID @CartID", param).ToListAsync());
            return cartDetails;
        }

     //   public async Task<string> CreateCart(Cart cart)
        // {
       //     var newCartIdOut = new SqlParameter("@NewCartIDOut", cart.cartIdOut);

       //     var userID = new SqlParameter("@UID", cart.UID);

       //     var newCartID = new SqlParameter("@NewCartID", cart.CartID);

       //     var cartCreate = await Task.Run(() => _dbContext.Database.ExecuteSqlRaw("exec spCartCreate @NewCartIDOut, @UID, @NewCartID", newCartIdOut, userID, newCartID));
          
      //      return cartCreate;
        }
    }

// }

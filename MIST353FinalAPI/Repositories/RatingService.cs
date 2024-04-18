using MIST353FinalAPI.Entities;
using MIST353FinalAPI.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using MIST353FinalAPI.Data;
using MIST353FinalAPI.Data;
using MIST353FinalAPI.Entities;

namespace MIST353FinalAPI.Repositories
{
    public class RatingService : IRatingService
    {
        private readonly DbContextClass _dbContextClass;

        public RatingService(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }

        public async Task<List<Rating>> GetRatings(int RID)
        {
            var param = new SqlParameter("@RID", RID);

            var ratingDetails = await _dbContextClass.Rating
                .FromSqlRaw("EXEC spLeaveFeedback @RID", param)
                .ToListAsync();

            return ratingDetails;
        }

        public async Task<Rating> AddRating(Rating rating)
        {
            _dbContextClass.Rating.Add(rating);
            await _dbContextClass.SaveChangesAsync();
            return rating;
        }
    }
}
using MIST353FinalAPI.Entities;
using MIST353FinalAPI.Entities;
using System.Threading.Tasks;

namespace MIST353FinalAPI.Repositories
{
    public interface IRatingService
    {
        Task<List<Rating>> GetRatings(int RID);
        Task<Rating> AddRating(Rating rating);
    }
}
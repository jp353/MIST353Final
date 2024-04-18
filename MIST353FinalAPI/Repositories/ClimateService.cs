using MIST353FinalAPI.Data;
using MIST353FinalAPI.Entities;
using MIST353FinalAPI.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MIST353FinalAPI.Data;
using MIST353FinalAPI.Entities;


namespace MIST353FinalAPI.Repositories
{
    public class ClimateService : IClimateService
    {
        private readonly DbContextClass _dbContextClass;

        public ClimateService(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }

        public async Task<List<Climate_Event>> GetClimateEvents(int RNum)
        {
            var param = new SqlParameter("@RNum", RNum);
            var ClimateEventDetails = await Task.Run(() => _dbContextClass.Climate_Event.FromSqlRaw("EXEC spSearchClimateData @RNum", param).ToListAsync());
            return ClimateEventDetails;
        }
    }
}
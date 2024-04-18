using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MIST353FinalAPI.Entities;

namespace MIST353FinalAPI.Repositories
{
    public interface IClimateService
    {
        Task<List<Climate_Event>> GetClimateEvents(int RNum);
    }
}

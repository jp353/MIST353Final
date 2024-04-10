// Created by Kayla Guyton
using System.Threading.Tasks;
using MIST353FinalAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MIST353FinalAPI.Repositories
{
    public interface IPostSub
    {
        public Task<ActionResult<int>> CartAddSubscription(int cartid, DateTime cdate, decimal price, int subid);
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using MIST353FinalAPI.Entities;
using Microsoft.Extensions.Hosting;
using MIST353FinalAPI.Repositories;
using System;
namespace MIST353FinalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : Controller
    {
        private readonly ICartService cartService;
        private readonly IPostSub PostSub;
        public CartController(ICartService cartService, IPostSub PostSub)
        {
            this.cartService = cartService;
            this.PostSub = PostSub;
        }

        [HttpGet("{cartid}")]
        public async Task<List<Cart>> GetCartID(int cartid)
        {
            var cartDetails = await cartService.GetCartID(cartid);
            if (cartDetails == null)
            {
                //return NotFound();
            }
            return cartDetails;
        }
        [HttpPost("api/CartAddSubscription/cart={cartid}&cdate={price}&cartid={cdate}&price={subid}")]
        public async Task<ActionResult<int>> CartAddSubscription(int cartid, DateTime cdate, decimal price, int subid)
        {
            var cartDetails = await PostSub.CartAddSubscription(cartid, cdate, price, subid);

            if (cartDetails == null)

            {
                //return NotFound();
            }
            return cartDetails;
        }
    }
}

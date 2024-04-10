using MIST353FinalAPI.Entities;
namespace MIST353FinalAPI.Repositories
{
    public interface ICartService
    {
      //  public Task<string> CreateCart(Cart cart);
        public Task<List<Cart>> GetCartID(int CartID);

    }
}
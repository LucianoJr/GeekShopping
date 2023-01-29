using GeekShopping.CartAPI.Data.ValueObjects;

namespace GeekShopping.CartAPI.Repository
{
    public interface ICartRepository
    {
        Task<CartVO> FindCartByUserId(string userID);
        Task<CartVO> SaveOrUpdateCart(CartVO cart);
        Task<bool> RemoveFromCart(long cartDetailsID);
        Task<bool> ApplyCoupon(string userId, string couponCode);
        Task<bool> RemoveFromCart(string userID);
        Task<bool> ClearCart(string userId);
    }
}

using DemoAPI.DataModel.Repository.Interface;

namespace DemoAPI.Services
{
    public class CartService:ICartService
    {
        readonly ICartRepository _cartRepository;

        public CartService(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public void AddBookToCart(int userId, int bookId)
        {
           _cartRepository.AddBookToCart(userId, bookId);
        }

        public int ClearCart(int userId)
        {
         return _cartRepository.ClearCart(userId);
        }

        public void DeleteCart(string cartId)
        {
            _cartRepository.DeleteCart(cartId); 
        }

        public void DeleteOneCartItem(int userId, int bookId)
        {
            _cartRepository.DeleteOneCartItem(userId, bookId);  
        }

        public string GetCartId(int userId)
        {
            return _cartRepository.GetCartId(userId);
        }

        public int GetCartItemCount(int userId)
        {
            return _cartRepository.GetCartItemCount(userId);    
        }

        public void MergeCart(int tempUserId, int permUserId)
        {
            throw new System.NotImplementedException();
        }
    }
}

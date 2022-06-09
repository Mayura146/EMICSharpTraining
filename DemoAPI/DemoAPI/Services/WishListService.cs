using DemoAPI.DataModel.Repository.Interface;

namespace DemoAPI.Services
{
    public class WishListService:IWishListService
    {
        private readonly IWishListRepository _repository;   
        public WishListService(IWishListRepository wishListRepository)
        {
            _repository = wishListRepository;
        }

        public int ClearWishlist(int userId)
        {
            return _repository.ClearWishlist(userId);   
        }

        public string GetWishlistId(int userId)
        {
            return _repository.GetWishlistId(userId);
        }

        public void ToggleWishlistItem(int userId, int bookId)
        {
          _repository.ToggleWishlistItem(userId, bookId);   
        }
    }
}

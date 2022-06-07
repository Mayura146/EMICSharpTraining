namespace DemoAPI.DataModel.Repository.Interface
{
    public interface IWishListRepository
    {
        void ToggleWishlistItem(int userId, int bookId);
        int ClearWishlist(int userId);
        string GetWishlistId(int userId);
    }
}

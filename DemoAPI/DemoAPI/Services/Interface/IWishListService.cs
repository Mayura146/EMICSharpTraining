using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAPI.DataModel.Repository.Interface
{
    public interface IWishListService
    {
        void ToggleWishlistItem(int userId, int bookId);
        int ClearWishlist(int userId);
        string GetWishlistId(int userId);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAPI.DataModel.Repository.Interface
{
    public interface ICartService
    {
        void AddBookToCart(int userId, int bookId);

        void DeleteOneCartItem(int userId, int bookId);
        int GetCartItemCount(int userId);
        void MergeCart(int tempUserId, int permUserId);
        int ClearCart(int userId);
        void DeleteCart(string cartId);
        string GetCartId(int userId);
    }
}

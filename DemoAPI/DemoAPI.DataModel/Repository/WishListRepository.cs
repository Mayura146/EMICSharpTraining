using DemoAPI.DataModel.Enities;
using DemoAPI.DataModel.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoAPI.DataModel.Repository
{
    public class WishListRepository:IWishListRepository
    {
        private readonly BookStoreContext _dbContext;

        public WishListRepository(BookStoreContext context)
        {
            _dbContext = context;
        }
        public void ToggleWishlistItem(int userId, int bookId)
        {
            string wishlistId = GetWishlistId(userId);
            WishlistItem existingWishlistItem = _dbContext.WishlistItems.FirstOrDefault(x => x.ProductId == bookId && x.WishlistId == wishlistId);

            if (existingWishlistItem != null)
            {
                _dbContext.WishlistItems.Remove(existingWishlistItem);
                _dbContext.SaveChanges();
            }
            else
            {
                WishlistItem wishlistItem = new WishlistItem
                {
                    WishlistId = wishlistId,
                    ProductId = bookId,
                };
                _dbContext.WishlistItems.Add(wishlistItem);
                _dbContext.SaveChanges();
            }
        }

        public int ClearWishlist(int userId)
        {
            try
            {
                string wishlistId = GetWishlistId(userId);
                List<WishlistItem> wishlistItem = _dbContext.WishlistItems.Where(x => x.WishlistId == wishlistId).ToList();

                if (!string.IsNullOrEmpty(wishlistId))
                {
                    foreach (WishlistItem item in wishlistItem)
                    {
                        _dbContext.WishlistItems.Remove(item);
                        _dbContext.SaveChanges();
                    }
                }
                return 0;
            }
            catch
            {
                throw;
            }
        }

        public string GetWishlistId(int userId)
        {
            try
            {
                Wishlist wishlist = _dbContext.Wishlists.FirstOrDefault(x => x.UserId == userId);

                if (wishlist != null)
                {
                    return wishlist.WishlistId;
                }
                else
                {
                    return CreateWishlist(userId);
                }

            }
            catch
            {
                throw;
            }
        }

        string CreateWishlist(int userId)
        {
            try
            {
                Wishlist wishList = new Wishlist
                {
                    WishlistId = Guid.NewGuid().ToString(),
                    UserId = userId,
                    DateCreated = DateTime.Now.Date
                };

                _dbContext.Wishlists.Add(wishList);
                _dbContext.SaveChanges();

                return wishList.WishlistId;
            }
            catch
            {
                throw;
            }
        }
    }
}

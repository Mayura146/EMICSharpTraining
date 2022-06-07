using DemoAPI.DataModel.Enities;
using DemoAPI.DataModel.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAPI.DataModel.Repository
{
    public class CartRepository: ICartRepository
    {
        readonly BookStoreContext _bookStoreContext;

        public CartRepository(BookStoreContext bookStoreContext)
        {
            _bookStoreContext = bookStoreContext;
        }

        public void AddBookToCart(int userId, int bookId)
        {
            string cartId=GetCartId(userId);
            int quantity = 1;
            CartItem existingCartItem = _bookStoreContext.CartItems.
                FirstOrDefault(x => x.ProductId == bookId && x.CartId == cartId);
            if(existingCartItem != null)
            {
                existingCartItem.Quantity += 1;
                _bookStoreContext.Entry(existingCartItem).State=Microsoft.EntityFrameworkCore.EntityState.Modified;
                _bookStoreContext.SaveChanges();
            }

            else
            {
                CartItem cartItems = new CartItem
                {
                    CartId = cartId,
                    ProductId = bookId,
                    Quantity = quantity
                };
                _bookStoreContext.CartItems.Add(cartItems);
                _bookStoreContext.SaveChanges();
            }
            
        }

        public int ClearCart(int userId)
        {
            try
            {
                string cartId=GetCartId(userId);    
                List<CartItem> cartItems=_bookStoreContext.CartItems.Where(x=>x.CartId==cartId).ToList();
                if (!string.IsNullOrEmpty(cartId))
                {
                    foreach (CartItem cartItem in cartItems)
                    {
                        _bookStoreContext.CartItems.Remove(cartItem);
                        _bookStoreContext.SaveChanges();
                    }
                }

                return 0;
            }
            catch
            {
                throw;
            }
        }

        public void DeleteOneCartItem(int userId, int bookId)
        {
            try
            {
                string cartId = GetCartId(userId);
                CartItem cartItem = _bookStoreContext.CartItems.FirstOrDefault(x => x.ProductId == bookId && x.CartId == cartId);
                cartItem.Quantity -= 1;
                _bookStoreContext.Entry(cartItem).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _bookStoreContext.SaveChanges();
            }

            catch
            {
                throw;
            }
        }

        public string GetCartId(int userId)
        {
            try
            {
                Cart cart = _bookStoreContext.Carts.FirstOrDefault(x => x.UserId == userId);
                if (cart != null)
                {
                    return cart.CartId;
                }

                else

                {
                    return CreateCart(userId);
                }
            }
            catch
            {
                throw;
            }
            }
        

        public int GetCartItemCount(int userId)
        {
            string cartId=GetCartId(userId);
            if(!string.IsNullOrEmpty(cartId))
            {
                int cartItemCount=_bookStoreContext.CartItems.Where(x=>x.CartId==cartId)
                    .Sum(x=>x.Quantity);
                return cartItemCount;
            }

            else
            {
                return 0;
            }
        }

        public void MergeCart(int tempUserId, int permUserId)
        {
            throw new NotImplementedException();
        }

            string CreateCart(int userId)
        {
            try
            {
                Cart shoppingCart = new Cart
                {
                    CartId = Guid.NewGuid().ToString(),
                    UserId = userId,
                    DateCreated = DateTime.Now.Date
                };
                return shoppingCart.CartId;
            }
            catch
            {
                throw;
            }
        }

        public void DeleteCart(string cartId)
        {
            Cart cart = _bookStoreContext.Carts.Find(cartId);
            _bookStoreContext.Remove(cart);
            _bookStoreContext.SaveChanges();
        }
    }
}

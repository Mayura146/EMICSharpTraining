using DemoAPI.DataModel.DTO;
using DemoAPI.DataModel.Enities;
using DemoAPI.DataModel.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DemoAPI.DataModel.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly BookStoreContext _bookStoreContex;

        public BookRepository(BookStoreContext bookStoreContex)
        {
            _bookStoreContex = bookStoreContex;
        }

        public int AddBook(Book book)
        {
            _bookStoreContex.Books.Add(book);
            _bookStoreContex.SaveChanges();
            return 1;

        }

        public string DeleteBook(int bookId)
        {
            try
            {
                Book book = _bookStoreContex.Books.Find(bookId);
                _bookStoreContex.Books.Remove(book);
                _bookStoreContex.SaveChanges();
                return (book.CoverFileName);

            }

            catch
            {
                throw;
            }
        }

        public List<Book> GetAllBooks()
        {
            return _bookStoreContex.Books.ToList();
        }

        public List<Category> GetAllCategories()
        {
            List<Category> categories = new List<Category>();
            categories = (from c in _bookStoreContex.Categories select c).ToList();
            return categories;
        }

        public Book GetBook(int id)
        {
            try
            {
                Book book = _bookStoreContex.Books.FirstOrDefault(x => x.BookId == id);
                if (book != null)
                {
                    _bookStoreContex.Entry(book).State = EntityState.Detached;
                    return book;
                }
                return null;
            }
            catch
            {
                throw;
            }
        }


        public List<CartIitemDto> GetBooksAavilableInCart(string cartId)
        {
            List<CartIitemDto> cartIitems = new List<CartIitemDto>();
            List<CartItem> cartItems1 = _bookStoreContex.CartItems.Where(x => x.CartId == cartId).ToList();
            foreach (CartItem i in cartItems1)
            {
                Book book = GetBook(i.ProductId);
                CartIitemDto obj = new CartIitemDto
                {
                    Book = book,
                    Quantity = i.Quantity
                };
                cartIitems.Add(obj);
            }
            return cartIitems;

                    }

        public List<Book> GetBooksAvailableInWhishList(string whishId)
        {

            List<Book> wishlist = new List<Book>();
            List<WishlistItem> wishlistItems = _bookStoreContex.WishlistItems.Where(x => x.WishlistId == whishId).ToList();
            foreach (WishlistItem i in wishlistItems)
            {
                Book book = GetBook(i.ProductId);
                wishlist.Add(book);
            }
            return wishlist;

        }

        public int UpdateBook(Book book)
        {
            try
            {
                Book oldbookData = GetBook(book.BookId);
                if (oldbookData.CoverFileName != null)
                {
                    if (book.CoverFileName != null)
                    {
                        //   book.CoverFileName=oldbookData.CoverFileName;
                        oldbookData.CoverFileName = book.CoverFileName;
                    }
                }
                _bookStoreContex.Entry(oldbookData).State = EntityState.Modified;
                _bookStoreContex.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }

        }
    }
}

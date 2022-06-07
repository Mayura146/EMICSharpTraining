using DemoAPI.DataModel.DTO;
using DemoAPI.DataModel.Enities;
using System.Collections.Generic;

namespace DemoAPI.Services.Interface
{
    public interface IBookService
    {
        List<Book> GetAllBooks();
        int AddBook(Book book);
        int UpdateBook(Book book);

        Book GetBook(int id);
        string DeleteBook(int bookId);
        List<Category> GetAllCategories();
        List<CartIitemDto> GetBooksAavilableInCart(string cartId);
        List<Book> GetBooksAvailableInWhishList(string whishId);
    }
}

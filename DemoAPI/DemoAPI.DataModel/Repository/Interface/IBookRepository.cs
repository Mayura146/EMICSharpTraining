using DemoAPI.DataModel.DTO;
using DemoAPI.DataModel.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAPI.DataModel.Repository.Interface
{
    public interface IBookRepository
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

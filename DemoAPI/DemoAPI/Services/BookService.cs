using DemoAPI.DataModel.DTO;
using DemoAPI.DataModel.Enities;
using DemoAPI.DataModel.Repository.Interface;
using DemoAPI.Services.Interface;
using System.Collections.Generic;

namespace DemoAPI.Services
{
    public class BookService:IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public int AddBook(Book book)
        {
          return _bookRepository.AddBook(book);
        }

        public string DeleteBook(int bookId)
        {
            return _bookRepository.DeleteBook(bookId);
        }

        public List<Book> GetAllBooks()
        {
            return _bookRepository.GetAllBooks();
        }

        public List<Category> GetAllCategories()
        {
        return _bookRepository.GetAllCategories(); 
        }

        public Book GetBook(int id)
        {
            return _bookRepository.GetBook(id);
        }

        public List<CartIitemDto> GetBooksAavilableInCart(string cartId)
        {
            return _bookRepository.GetBooksAavilableInCart(cartId);
        }

        public List<Book> GetBooksAvailableInWhishList(string whishId)
        {
            return _bookRepository.GetBooksAvailableInWhishList(whishId);
        }

        public int UpdateBook(Book book)
        {
            return _bookRepository.UpdateBook(book);
        }
    }
}

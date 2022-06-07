using DemoAPI.DataModel.Enities;
using DemoAPI.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace DemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        // GET: api/Books
        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            return _bookService.GetAllBooks().ToList();
        }

        // GET: api/Books/5
        [HttpGet("{id}")]
        public ActionResult<Book> GetBook(int id)
        {
            return _bookService.GetBook(id);


        }

        // PUT: api/Books/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        public int PutBook(Book book)
        {
            return _bookService.UpdateBook(book);

        }

        // POST: api/Books
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public int PostBook(Book book)
        {
            return _bookService.AddBook(book);


        }

        // DELETE: api/Books/5
        [HttpDelete("{id}")]
        public string DeleteBook(int id)
        {
            return _bookService.DeleteBook(id);


        }


    }
}

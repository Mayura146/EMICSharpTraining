
using AutoMapper;
using DemoAPI.DataModel.DTO;
using DemoAPI.DataModel.Repository.Interface;
using DemoAPI.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        IMapper _mapper;
        private readonly DataModel.Repository.Interface.ICartService _cartService;
        private readonly IBookService _bookService;

        public ShoppingCartController(ICartService cartService, IBookService bookService, IMapper mapper)
        {
            _cartService = cartService;
            _bookService = bookService;
            _mapper=mapper;
        }
        [HttpGet("{userID}")]
         public async Task<List<CartIitemDto>> GetCountItem(int userID)
        {
            string cartId = _cartService.GetCartId(userID);
            var data =  _bookService.GetBooksAavilableInCart(cartId).ToList();
            var response = _mapper.Map<List<CartIitemDto>>(data);
            return response;
        }

        [HttpPost]
        [Route("AddtoCart/{userId}/{bookId}")]
        public int AddBooksToCart(int userId,int bookId)
        {
            _cartService.AddBookToCart(userId, bookId); 
            return _cartService.GetCartItemCount(userId);
        }

        [HttpPut("{userId}/{bookId}")]
        public int DeleteOneItemfromCart(int userId,int bookId)
        {
            _cartService.DeleteOneCartItem(userId, bookId);
            return _cartService.GetCartItemCount(userId);
        }

        [HttpDelete("{userId}")]
        public int ClearCart(int userId)
        {
         return   _cartService.ClearCart(userId);
        }

      

     }
}

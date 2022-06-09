using DemoAPI.DataModel.Enities;
using DemoAPI.DataModel.Repository.Interface;
using DemoAPI.Services;
using DemoAPI.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WishListController : ControllerBase
    {
        readonly IWishListService _wishlistService;
        readonly IBookService _bookService;
        readonly IUserService _userService;

        public WishListController(IWishListService wishlistService, IBookService bookService, IUserService userService)
        {
            _wishlistService = wishlistService;
            _bookService = bookService;
            _userService = userService;
        }

      
        [HttpGet("{userId}")]
        public async Task<List<Book>> Get(int userId)
        {
            return await Task.FromResult(GetUserWishlist(userId)).ConfigureAwait(true);
        }

    
        [Authorize]
        [HttpPost]
        [Route("ToggleWishlist/{userId}/{bookId}")]
        public async Task<List<Book>> Post(int userId, int bookId)
        {
            _wishlistService.ToggleWishlistItem(userId, bookId);
            return await Task.FromResult(GetUserWishlist(userId)).ConfigureAwait(true);
        }

        [Authorize]
        [HttpDelete("{userId}")]
        public int Delete(int userId)
        {
            return _wishlistService.ClearWishlist(userId);
        }

        List<Book> GetUserWishlist(int userId)
        {
            bool user = _userService.isUserExists(userId);
            if (user)
            {
                string Wishlistid = _wishlistService.GetWishlistId(userId);
                return _bookService.GetBooksAvailableInWhishList(Wishlistid);
            }
            else
            {
                return new List<Book>();
            }

        }
    }
}

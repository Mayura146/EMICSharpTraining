﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BookStore.DataModel.Entites
{
    public partial class Wishlist
    {
        public string WishlistId { get; set; }
        public int UserId { get; set; }
        public DateTime DateCreated { get; set; }
    }
}

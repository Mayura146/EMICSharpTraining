﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BookStore.DataModel.Entites
{
    public partial class WishlistItem
    {
        public int WishlistItemId { get; set; }
        public string WishlistId { get; set; }
        public int ProductId { get; set; }
    }
}

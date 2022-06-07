using System;
using System.Collections.Generic;

#nullable disable

namespace DemoAPI.DataModel.Enities
{
    public partial class Cart
    {
        public string CartId { get; set; }
        public int UserId { get; set; }
        public DateTime DateCreated { get; set; }
    }
}

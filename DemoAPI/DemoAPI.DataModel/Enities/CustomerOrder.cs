using System;
using System.Collections.Generic;

#nullable disable

namespace DemoAPI.DataModel.Enities
{
    public partial class CustomerOrder
    {
        public string OrderId { get; set; }
        public int UserId { get; set; }
        public DateTime DateCreated { get; set; }
        public decimal CartTotal { get; set; }
    }
}

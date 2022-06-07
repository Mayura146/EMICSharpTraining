using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAPI.DataModel.DTO
{
    public class OrderDto
    {
        public string OrderId { get; set; }
        public List<CartIitemDto> OrderDetails { get; set; }
        public decimal CartTotal { get; set; }
        public DateTime OrderDate { get; set; }
    }
}

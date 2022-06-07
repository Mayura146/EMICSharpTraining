using DemoAPI.DataModel.Enities;

namespace DemoAPI.DataModel.DTO
{
    public class CartIitemDto
    {
        public Book Book { get; set; }
        public int Quantity { get; set; }
    }
}

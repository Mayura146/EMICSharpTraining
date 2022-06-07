using DemoAPI.DataModel.DTO;
using DemoAPI.DataModel.Enities;
using AutoMapper;
namespace DemoAPI.Mapper
{
    public class ProfileMapper:Profile
    {
        public ProfileMapper()
        {
            CreateMap<CartItem, CartIitemDto>();
        }
    }
}

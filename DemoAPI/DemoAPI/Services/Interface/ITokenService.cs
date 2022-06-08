using DemoAPI.DataModel.Enities;

namespace DemoAPI.Services.Interface
{
    public interface ITokenService
    {
        string CreateToken(UserMaster userInfo);
    }
}

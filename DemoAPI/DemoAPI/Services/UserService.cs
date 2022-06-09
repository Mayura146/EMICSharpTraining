using DemoAPI.DataModel.DTO;
using DemoAPI.DataModel.Enities;
using DemoAPI.DataModel.Repository.Interface;

namespace DemoAPI.Services
{
    public class UserService:IUserService
    {

        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserMaster AuthenticateUser(UserMaster loginCredentials)
        {
            return _userRepository.AuthenticateUser(loginCredentials);
        }

        public bool CheckUserAvailabity(string userName)
        {
           return _userRepository.CheckUserAvailabity(userName);
        }

        public bool isUserExists(int userId)
        {
          return _userRepository.isUserExists(userId);
        }

        public int RegisterUser(UserMaster userData)
        {
          return _userRepository.RegisterUser(userData);
        }
    }
}

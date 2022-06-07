using DemoAPI.DataModel.Enities;
using DemoAPI.DataModel.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAPI.DataModel.Repository
{
    public class UserRepository:IUserRepository
    {
        private readonly BookStoreContext _bookstoreContext;

        public UserRepository(BookStoreContext bookstoreContext)
        {
            _bookstoreContext = bookstoreContext;
        }

        public UserMaster AuthenticateUser(UserMaster loginCredentials)
        {
            UserMaster userMaster = new UserMaster();
            var userDetails=_bookstoreContext.UserMasters.FirstOrDefault(u=>u.Username== loginCredentials.Username

            && u.Password==loginCredentials.Password);
            if (userDetails!=null)
            {
               var user = new UserMaster
                {
                    Username = userDetails.Username,
                    UserId = userDetails.UserId,
                    UserTypeId = userDetails.UserId
                };

                return user;
            }

            else
            {
                return userDetails;
            }
        }

        public bool CheckUserAvailabity(string userName)
        {
        string user=_bookstoreContext.UserMasters.FirstOrDefault(x=>x.Username== userName)?.ToString();
            if(user!=null)
            {
                return true;
            }
            else
                return false;
        }

        public bool isUserExists(int userId)
        {

            string user = _bookstoreContext.UserMasters.FirstOrDefault(x => x.UserId == userId)?.ToString();
            if (user != null)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
        public int RegisterUser(UserMaster userData)
        {
            try
            {
                userData.UserTypeId = 2;
                _bookstoreContext.UserMasters.Add(userData);
                _bookstoreContext.SaveChanges();
                return 1;
            }

            catch
            {
                throw;
            }
        }
    }
}

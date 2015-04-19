using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ChoresNet.Common;

namespace ChoresNet.Service
{

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AuthenticationService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AuthenticationService.svc or AuthenticationService.svc.cs at the Solution Explorer and start debugging.
    public class AuthenticationService : IAuthenticationService
    {
        private readonly UserRepository _userRepository = new UserRepository();

        public User GetUserById(Guid userId)
        {
            return _userRepository.GetUserById(userId);
        }

        public User GetUserByName(string userName)
        {
            return _userRepository.GetUserByName(userName);
        }

        public void UpdateUser(User user)
        {
            var databaseUser = _userRepository.GetUserById(user.Id);
            if (databaseUser == null)
                _userRepository.SaveUser(user);
            else
            {
                databaseUser.UserName = user.UserName;
                databaseUser.PasswordHash = user.PasswordHash;
            }
        }

        public void DeleteUser(User user)
        {
            _userRepository.DeleteUser(user);
        }
    }
}

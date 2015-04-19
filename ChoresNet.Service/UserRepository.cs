using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ChoresNet.Common;

namespace ChoresNet.Service
{
    public class UserRepository
    {
        public static List<User> Users = new List<User>();

        public void SaveUser(User user)
        {
            if(Users.All(x => x.Id != user.Id && x.UserName != user.UserName))
                Users.Add(user);
        }

        public User GetUserById(Guid userId)
        {
            if (userId == null)
                return null;
            return Users.SingleOrDefault(x => x.Id.Equals(userId));
        }

        public User GetUserByName(string userName)
        {
            return Users.SingleOrDefault(x => x.UserName.Equals(userName));
        }

        public void DeleteUser(User user)
        {
            if (Users.Any(x => x.Id == user.Id))
                Users.Remove(user);
        }
    }
}
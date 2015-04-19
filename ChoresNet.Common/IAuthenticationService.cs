using System;
using System.ServiceModel;

namespace ChoresNet.Common
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAuthenticationService" in both code and config file together.
    [ServiceContract]
    public interface IAuthenticationService
    {
        [OperationContract]
        User GetUserById(Guid userId);

        [OperationContract]
        User GetUserByName(string userId);

        [OperationContract]
        void UpdateUser(User user);

        [OperationContract]
        void DeleteUser(User user);
    }
}

using System;
using System.Threading.Tasks;
using ChoresNet.Web.Proxies;
using Microsoft.AspNet.Identity;
using DateTimeOffset = System.DateTimeOffset;
using User = ChoresNet.Common.User;

namespace ChoresNet.Web.Security
{
    public class ServiceUserStore : IUserStore<User, Guid>, IUserPasswordStore<User, Guid>, IUserLockoutStore<User, Guid>, IUserTwoFactorStore<User, Guid>
    {
        private readonly AuthenticationServiceClient _service = new AuthenticationServiceClient();

        #region IUserStore implementation

        public void Dispose()
        {
            //No implementation required
        }

        public Task CreateAsync(User user)
        {
            user.Id = Guid.NewGuid();
            _service.UpdateUser(user);
            return Task.FromResult<object>(null);
        }

        public Task UpdateAsync(User user)
        {
            _service.UpdateUser(user);
            return Task.FromResult<object>(null);
        }

        public Task DeleteAsync(User user)
        {
            _service.DeleteUser(user);
            return Task.FromResult<object>(null);
        }

        public Task<User> FindByIdAsync(Guid userId)
        {
            var user = _service.GetUserById(userId);
            return Task.FromResult<User>(user);
        }

        public Task<User> FindByNameAsync(string userName)
        {
            var user = _service.GetUserByName(userName);
            return Task.FromResult<User>(user);
        }

        #endregion

        #region IPassword implementation

        public Task SetPasswordHashAsync(User user, string passwordHash)
        {
            user.PasswordHash = passwordHash;
            return Task.FromResult<object>(null);
        }

        public Task<string> GetPasswordHashAsync(User user)
        {
            return Task.FromResult<string>(user.PasswordHash);
        }

        public Task<bool> HasPasswordAsync(User user)
        {
            return Task.FromResult<bool>(String.IsNullOrEmpty(user.PasswordHash));
        }

        #endregion

        #region IUserLockoutStore

        public Task<DateTimeOffset> GetLockoutEndDateAsync(User user)
        {
            var end = user.LockoutEnd;
            return Task.FromResult<DateTimeOffset>(end);
        }

        public Task SetLockoutEndDateAsync(User user, DateTimeOffset lockoutEnd)
        {
            user.LockoutEnd = lockoutEnd;
            return Task.FromResult<object>(null);
        }

        public Task<int> IncrementAccessFailedCountAsync(User user)
        {
            var count = user.LockoutCounter++;
            return Task.FromResult<int>(count);
        }

        public Task ResetAccessFailedCountAsync(User user)
        {
            user.LockoutCounter = 0;
            return Task.FromResult<object>(null);
        }

        public Task<int> GetAccessFailedCountAsync(User user)
        {
            return Task.FromResult<int>(user.LockoutCounter);
        }

        public Task<bool> GetLockoutEnabledAsync(User user)
        {
            return Task.FromResult<bool>(user.LockoutEnabled);
        }

        public Task SetLockoutEnabledAsync(User user, bool enabled)
        {
            user.LockoutEnabled = enabled;
            return Task.FromResult<object>(null);
        }

        #endregion

        #region IUserTwoFactorStore

        public Task SetTwoFactorEnabledAsync(User user, bool enabled)
        {
            return Task.FromResult<object>(null);
        }

        public Task<bool> GetTwoFactorEnabledAsync(User user)
        {
            return Task.FromResult<bool>(false);
        }

        #endregion
    }
}
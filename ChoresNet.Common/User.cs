using System;
using System.Runtime.Serialization;
using Microsoft.AspNet.Identity;

namespace ChoresNet.Common
{
    [DataContract]
    public class User : IUser<Guid>
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public string PasswordHash { get; set; }

        [DataMember]
        public DateTimeOffset LockoutEnd { get; set; }

        [DataMember]
        public int LockoutCounter { get; set; }

        [DataMember]
        public bool LockoutEnabled { get; set; }
    }
}
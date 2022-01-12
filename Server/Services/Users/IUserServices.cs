using PwaProject2.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PwaProject2.Server.Services.Users
{
    public interface IUserServices
    {
        List<UserResult> GetAllUsers();
    }
}

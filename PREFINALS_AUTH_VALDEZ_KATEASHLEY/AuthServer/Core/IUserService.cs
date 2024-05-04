using System;
namespace AuthServer.Core
{

    public interface IUserService
    {
        User GetUserByUsername(string username);
        void CreateUser(string username, string passwordHash);
    }
}

using System;
using System.Collections.Generic;


namespace AuthServer.Core
{
    public class UserService : IUserService
    {
        private Dictionary<string, User> _userStorage;

        public UserService()
        {
            _userStorage = new Dictionary<string, User>();
        }

        public User GetUserByUsername(string username)
        {
            _userStorage.TryGetValue(username, out User user);
            return user;
        }

        public void CreateUser(string username, string passwordHash)
        {
            _userStorage[username] = new User(username, passwordHash);
        }
    }
}

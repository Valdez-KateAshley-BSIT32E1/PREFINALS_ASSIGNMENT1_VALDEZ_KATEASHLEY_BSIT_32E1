namespace AuthServer.Core
{
    public class AuthService : IAuthService
    {
        private IUserService _userService;

        public AuthService(IUserService userService)
        {
            _userService = userService;
        }

        public string GenerateToken(string username)
        {
            // For simplicity, let's assume token is just the username
            return username;
        }
    }
}

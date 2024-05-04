namespace AuthServer.Core
{
    public interface IAuthService

    {
        string GenerateToken(string username);
    }
}

 

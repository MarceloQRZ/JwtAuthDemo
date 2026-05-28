namespace JwtAuthDemo.Services.Interfaces
{
    public interface IAuthService
    {
        string GenerateToken(string username);
    }
}
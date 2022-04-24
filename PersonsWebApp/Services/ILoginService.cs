using PersonsWebApp.DAL.Entities;

namespace PersonsWebApp.Services
{
    public interface ILoginService
    {
        Task<LoginResponse?> LoginAsync(UserDto userDto);
        Task<LoginResponse?> RefreshAsync(string oldToken);
    }
}

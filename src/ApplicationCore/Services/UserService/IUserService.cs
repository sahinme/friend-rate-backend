using System.Threading.Tasks;
using Microsoft.Nnn.ApplicationCore.Entities.Users;
using Nnn.ApplicationCore.Services.UserService.Dto;

namespace Microsoft.Nnn.ApplicationCore.Interfaces
{
    public interface IUserService
    {
        Task<UserDto> CreateUser(CreateUserDto input);
        Task<UserDto> GetUserById(int id);
        Task<UserDto> GetUserByName(string username);
        Task UpdateUser(UpdateUserDto input);
        Task<bool> Login(LoginDto input);
        Task DeleteUser(long id);
    }
}
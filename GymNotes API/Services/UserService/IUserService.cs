using GymNotes.Models;

namespace GymNotes.Services.UserService
{
    public interface IUserService
    {
        Task<List<User>> GetUsers();
    }
}

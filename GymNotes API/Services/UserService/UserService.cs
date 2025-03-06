using GymNotes.Data;
using GymNotes.Models;
using Microsoft.EntityFrameworkCore;

namespace GymNotes.Services.UserService
{
    

    public class UserService : IUserService
    {
        private readonly DataContext _dataContext;

        public UserService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<User>> GetUsers()
        {
            var users = await _dataContext.Users.ToListAsync();
            return users;
        }
    }
}

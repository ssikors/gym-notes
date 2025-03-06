using GymNotes.Data;
using GymNotes.Models;
using GymNotes.Services.UserService;
using GymNotes.Services.WorkoutService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymNotes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
    
        private readonly DataContext _dataContext;
        private readonly IUserService _userService;
        private readonly IWorkoutService _workoutService;

        public UserController(DataContext dataContext, IUserService userService, IWorkoutService workoutService)
        {
            _dataContext = dataContext;
            _userService = userService;
            _workoutService = workoutService;

        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAllUsers()
        {
            var users = await _userService.GetUsers();

            return Ok(users);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _dataContext.Users.FindAsync(id);

            if (user is null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpPost]
        public async  Task<IActionResult> CreateUser(UserDto userDto)
        {
            _dataContext.Users.Add(new User { Email = userDto.Email, Name = userDto.Name });    
            
            await _dataContext.SaveChangesAsync();
            
            return Ok(userDto);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUser(User user)
        {
            var dbUser = await _dataContext.Users.FindAsync(user.Id);

            if (dbUser is null)
            {
                return BadRequest();
            }

            dbUser.Name = user.Name;
            dbUser.Email = user.Email;

            await _dataContext.SaveChangesAsync();

            return Ok(dbUser);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _dataContext.Users.FindAsync(id);

            if (user is null)
            {
                return NotFound();
            }

            _dataContext.Users.Remove(user);
            await _dataContext.SaveChangesAsync();
            return Ok();
        }

        [HttpPost]
        [Route("workouts")]
        public async Task<IActionResult> GetUserWorkouts(User user)
        {
            var workouts = _workoutService.GetWorkoutsByUserId(user.Id);
            return Ok(workouts);
        }
    }
}

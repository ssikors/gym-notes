using GymNotes.Models;
using GymNotes.Services.WorkoutService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace GymNotes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkoutController : ControllerBase
    {
        private readonly IWorkoutService _workoutService;

        public WorkoutController(IWorkoutService workoutService)
        {
            _workoutService = workoutService;
        }

        [HttpGet]
        [Route("/excercises")]
        public IActionResult GetAllExcercises()
        {
            var excercises = _workoutService.GetExcercises();
            return Ok(excercises);
        }

        [HttpPost]
        [Route("/excercises/add")]
        public IActionResult AddExcercise(ExcerciseDto excerciseDto)
        {
            _workoutService.AddExcercise(excerciseDto);
            return Ok(excerciseDto);
        }
    }
}

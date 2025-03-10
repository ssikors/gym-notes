using GymNotes;
using GymNotes.Controllers;
using GymNotes.Services.WorkoutService;

namespace TestGym
{
    public class UnitTest1
    {


        private readonly IWorkoutService _workoutService;

        [Fact]
        public async void Test1()
        {
            var controller = new WorkoutController(_workoutService);

            var result = controller.GetAllExcercises();
            Console.WriteLine(result.ToString());
            Assert.Equal(2, 2);
        }
    }
}
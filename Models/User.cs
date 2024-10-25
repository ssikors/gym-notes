namespace GymNotes.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }

        public ICollection<Workout>? Workouts { get; set; }
    }
}

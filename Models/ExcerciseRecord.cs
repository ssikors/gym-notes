namespace GymNotes.Models
{
    public class ExcerciseRecord
    {
        public int Id { get; set; }
        public string? Notes { get; set; }
        public int? Sets { get; set; }

        public DateTime? LastPerformed { get; set; }
        public required Workout Workout { get; set; }
        public required Excercise Excercise { get; set; }

        public ICollection<ExcerciseSet>? ExcerciseSets { get; set;}
    }
}

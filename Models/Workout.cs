namespace GymNotes.Models
{
    public class Workout
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Notes { get; set; }
        public DateTime? PerformedAt { get; set; }

        public required User User { get; set; }
        public ICollection<ExcerciseRecord>? ExcerciseRecords { get; set; }

    }
}

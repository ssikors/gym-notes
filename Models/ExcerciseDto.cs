namespace GymNotes.Models
{
    public class ExcerciseDto
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public string? BodyPart { get; set; }
    }
}

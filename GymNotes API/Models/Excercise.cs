namespace GymNotes.Models
{
    public class Excercise
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public string? BodyPart { get; set; }
    }
}

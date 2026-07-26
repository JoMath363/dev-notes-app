namespace DevNotes.Api.Models
{
    public class Note
    {
        public Guid Id = Guid.NewGuid();
        public string? Title { get; set; }
        public string? Content { get; set; }

        public DateTime CreatedAt = new DateTime();
    }
}

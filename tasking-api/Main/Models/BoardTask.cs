namespace tasking_api.Main.Models
{
    public class BoardTask
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? Deadline { get; set; }
    }
}

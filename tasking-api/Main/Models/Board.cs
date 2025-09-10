namespace tasking_api.Main.Models
{
    public class Board
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Task> Tasks { get; set; }
    }
}

namespace TaskManager.Presentation.Models
{
    public class WorkItemsGridModel
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public string Title { get; set; }

        public string State { get; set; }

        public int Effort { get; set; }
    }
}
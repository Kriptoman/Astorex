using System;

namespace TaskManager.Presentation.Models
{
    public class CreateWorkItemModel
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public string Title { get; set; }

        public string State { get; set; }

        public string StateId { get; set; }

        public string SprintId { get; set; }

        public int Effort { get; set; }

        public string Reason { get; set; }

        public string Description { get; set; }

        public DateTime DateStarted { get; set; }

        public DateTime DateEnded { get; set; }

        public string Developer { get; set; }

        public int AssignedTo { get; set; }

        public int BacklogPriority { get; set; }
    }
}

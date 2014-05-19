using System;

namespace TaskManager.Presentation.Models
{
    public class ProjectsModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime StartedAt { get; set; }

        public DateTime LastChanges { get; set; }
    }
}
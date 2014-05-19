using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace TaskManager.Presentation.Models
{
    public class WorkItemModel
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public string Title { get; set; }

        public string StateId { get; set; }

        public IEnumerable<SelectListItem> States { get; set; }

        public string SprintId { get; set; }

        public IEnumerable<SelectListItem> Sprints{ get; set; }

        public int Effort { get; set; }

        public string Reason { get; set; }

        public string Description { get; set; }

        public DateTime? DateStarted { get; set; }

        public DateTime? DateEnded { get; set; }

        public int AssignedTo { get; set; }

        public IEnumerable<SelectListItem> Developers { get; set; }

        public int BacklogPriority { get; set; }
    }
}


using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace TaskManager.Presentation.Models
{
    public class SprintModel
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public string ProjectId { get; set; }

        public IEnumerable<SelectListItem> Projects { get; set; }

        public DateTime? StartDate { get; set; }

        public int Duration { get; set; }
    }
}
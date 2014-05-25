using System;
using System.Collections.Generic;

namespace TaskManager.Presentation.Models
{
    public class WorkItemModel
    {
        public int Id { get; set; }

        public string TypeId { get; set; }

        public string StateId { get; set; }

        public string SprintId { get; set; }

        public int AssignedTo { get; set; }

        public int BacklogPriority { get; set; }

        public int Effort { get; set; }

        public string Title { get; set; }

        public string Reason { get; set; }

        public string Description { get; set; }

        public DateTime? DateStarted { get; set; }

        public DateTime? DateEnded { get; set; }

        public IEnumerable<EmployeeModel> Developers { get; set; }
        
        public IEnumerable<SprintModel> Sprints { get; set; }

        public IEnumerable<WorkItemsStateModel> States { get; set; }

        public IEnumerable<WorkItemsTypeModel> Types { get; set; }

    }
}


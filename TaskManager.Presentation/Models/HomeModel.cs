using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TaskManager.Presentation.Models
{
    public class HomeModel
    {
        [Display(Name = "Sprints:")]
        public IList<SprintModel> Sprints { get; set; }

        [Display(Name = "Employees:")]
        public IList<EmployeeModel> Employees { get; set; }
    }
}

using System.Collections.Generic;
using TaskManager.Presentation.Models;

namespace TaskManager.Presentation.Repositories
{
    public class AdditionalRepository : Repository
    {
        public IEnumerable<EmployeeModel> GetEmployees()
        {
            return ExecuteProcedure<EmployeeModel>("get_all_employes");
        }

        public IEnumerable<StatesModel> GetStates()
        {
            return ExecuteProcedure<StatesModel>("get_all_states");
        }

        public IEnumerable<ProjectsModel> GetProjects()
        {
            return ExecuteProcedure<ProjectsModel>("get_all_projects");
        }

        public IEnumerable<StaffModel> GetPersonal()
        {
            return ExecuteProcedure<StaffModel>("get_all_employes");
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using TaskManager.Presentation.Models;

namespace TaskManager.Presentation.Repositories
{
    public class SprintsRepository : Repository
    {
        public IEnumerable<SprintModel> GetAll()
        {
            return ExecuteProcedure<SprintModel>("get_all_sprints");
        }

        public SprintModel GetById(int id)
        {
            return ExecuteProcedure<SprintModel>("create_sprint", id).FirstOrDefault();
        }

        public void Create(SprintModel model)
        {
            ExecuteProcedure("create_sprint", new
                {
                    model.Description,
                    model.StartDate,
                    model.Duration,
                    model.ProjectId
                });
        }

        public void Delete(int sprintId)
        {
            ExecuteProcedure("delete_sprint", new {sprintId});
        }

        public void Modify(SprintModel model)
        {
            ExecuteProcedure("update_sprint", model);
        }
    }
}

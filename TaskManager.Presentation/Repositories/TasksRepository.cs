using System.Collections.Generic;
using System.Linq;
using TaskManager.Presentation.Models;

namespace TaskManager.Presentation.Repositories
{
    public class TasksRepository : Repository
    {
        public IEnumerable<HomeModel> GetTasksByUser(string userName)
        {
            return ExecuteProcedure<HomeModel>("get_work_items_by_dev", new { userName });
        }

        public void Create(WorkItemModel model)
        {
            ExecuteProcedure("create_work_item", new
                {
                    model.Title,
                    model.Type,
                    model.SprintId,
                    model.StateId,
                    model.Reason,
                    model.Effort,
                    model.Description,
                    model.BacklogPriority,
                    model.DateEnded,
                    model.DateStarted,
                    model.AssignedTo
                });
        }

        public void Delete(int taskId)
        {
            ExecuteProcedure("delete_work_item", new { taskId });
        }

        public void Modify(WorkItemModel model)
        {
            ExecuteProcedure("update_work_item", model);
        }

        public WorkItemModel GetWorkItem(int id)
        {
            return ExecuteProcedure<WorkItemModel>("get_work_item_by_id", id).FirstOrDefault();
        }
    }
}
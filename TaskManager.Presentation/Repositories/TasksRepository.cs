using System.Collections.Generic;
using System.Linq;
using TaskManager.Presentation.Models;

namespace TaskManager.Presentation.Repositories
{
    public class TasksRepository : Repository
    {
        public IEnumerable<WorkItemsGridModel> GetWorkItemsBySprint(int? sprintId = null)
        {
            return ExecuteProcedure<WorkItemsGridModel>("get_work_items_by_sprint", new { sprintId });
        }

        public IEnumerable<WorkItemsGridModel> GetWorkItemsByUser(string userName)
        {
            return ExecuteProcedure<WorkItemsGridModel>("get_work_items_by_dev", new { userName });
        }

        public IEnumerable<WorkItemsGridModel> GetFilteredWorkItems(int? sprintId, int? userId)
        {
            return ExecuteProcedure<WorkItemsGridModel>("get_work_items_grid", new { sprintId, userId });
        }

        public void Create(WorkItemModel model)
        {
            ExecuteProcedure("create_work_item", new
                {
                    model.TypeId,
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
            return ExecuteProcedure<WorkItemModel>("get_work_item_by_id", new { id }).FirstOrDefault();
        }

        public IEnumerable<WorkItemsTypeModel> GetWorkItemTypes()
        {
            return ExecuteProcedure<WorkItemsTypeModel>("get_all_workitems_types");
        }

        public IEnumerable<WorkItemsStateModel> GetWorkItemStates()
        {
            return ExecuteProcedure<WorkItemsStateModel>("get_all_workitems_states");
        }
    }
}
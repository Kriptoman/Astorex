using System.Globalization;
using System.Linq;
using System.Web.Mvc;
using TaskManager.Infrastructure.Constants;
using TaskManager.Presentation.Models;
using TaskManager.Presentation.Repositories;

namespace TaskManager.Web.Controllers
{
    public class WorkItemsController : Controller
    {
        public const string Name = "workitems";

        private readonly TasksRepository _tasksRepository;
        private readonly SprintsRepository _sprintsRepository;
        private readonly AdditionalRepository _additionalRepository;

        public WorkItemsController()
        {
            _tasksRepository = new TasksRepository();
            _sprintsRepository = new SprintsRepository();
            _additionalRepository = new AdditionalRepository();
        }

        [HttpGet]
        public ActionResult Index(string type)
        {
            return RedirectToAction(Actions.GetWorkItem, new {id = 0});
        }

        [HttpPost]
        public ActionResult Create(WorkItemModel model)
        {
            if (TryValidateModel(model))
            {
                _tasksRepository.Create(model);

                Json(new { success = true, message = "OK" });
            }

            return Json(new { success = false, message = "Error"});
        }

        [HttpPost]
        public ActionResult Edit(WorkItemModel model)
        {
            if (TryValidateModel(model))
            {
                _tasksRepository.Modify(model);

                Json(new { success = true, message = "OK" });
            }

            return Json(new { success = false, message = "Error" });
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            _tasksRepository.Delete(id);

            return View(Views.Home);
        }

        public ViewResult Getworkitem(int id)
        {
            var model = _tasksRepository.GetWorkItem(id);

            model.Developers = _additionalRepository.GetEmployees();
            model.Sprints = _sprintsRepository.GetAll();
            model.States = _tasksRepository.GetWorkItemStates();
            model.Types = _tasksRepository.GetWorkItemTypes();

            return View(Views.WorkItem, model);
        }

        public ViewResult GetWorkItemsGrid(int? sprintId, int? userId)
        {
            var model = _tasksRepository.GetFilteredWorkItems(sprintId, userId).ToList();

            return View(Views.WorkItemsGrid, model);
        }
    }
}

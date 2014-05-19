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
        public ViewResult Index(string type)
        {
            var model = new WorkItemModel();

            model.Type = type;
            model.Sprints = _sprintsRepository
                .GetAll()
                .Select(spr => new SelectListItem
                {
                    Text = spr.Description,
                    Value = spr.Id.ToString(CultureInfo.InvariantCulture)
                });

            model.Developers = _additionalRepository.GetDevelopers()
                .Select(spr => new SelectListItem
                {
                    Text = spr.FirstName + " " + spr.LastName,
                    Value = spr.Id.ToString(CultureInfo.InvariantCulture)
                });

            model.States = _additionalRepository.GetStates()
                .Select(spr => new SelectListItem
                {
                    Text = spr.Title,
                    Value = spr.Id.ToString(CultureInfo.InvariantCulture)
                });

            return View(Views.TaskDesk, model);
        }

        [HttpPost]
        public ActionResult Create(WorkItemModel model)
        {
            if (TryValidateModel(model))
            {
                _tasksRepository.Create(model);
            }

            return RedirectToAction(Actions.Index, HomeController.Name);
        }

        [HttpPost]
        public ActionResult Edit(WorkItemModel model)
        {
            _tasksRepository.Modify(model);

            return View(Views.Home);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            _tasksRepository.Delete(id);

            return View(Views.Home);
        }

        public ActionResult Getworkitem(int id)
        {
            _tasksRepository.GetWorkItem(id);

            return View(Views.Home);
        }
    }
}

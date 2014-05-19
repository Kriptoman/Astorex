using System.Globalization;
using System.Linq;
using System.Web.Mvc;
using TaskManager.Infrastructure.Constants;
using TaskManager.Presentation.Models;
using TaskManager.Presentation.Repositories;

namespace TaskManager.Web.Controllers
{
    public class SprintsController : Controller
    {
        public const string Name = "sprints";

        private readonly SprintsRepository _sprintsRepository;
        private readonly AdditionalRepository _additionalRepository;

        public SprintsController()
        {
            _sprintsRepository = new SprintsRepository();
            _additionalRepository = new AdditionalRepository();
        }

        [HttpGet]
        public ActionResult Index()
        {
            var model = new SprintModel();
            var projects = _additionalRepository.GetProjects();

            model.Projects = projects.Select(pr => new SelectListItem
                {
                    Text = pr.Name,
                    Value = pr.Id.ToString(CultureInfo.InvariantCulture)
                });

            return View(Views.CreateSprint, model);
        }

        [HttpPost]
        public ActionResult Create(SprintModel model)
        {
            _sprintsRepository.Create(model);

            return View(Views.Home);
        }

        [HttpPost]
        public ActionResult Edit(SprintModel model)
        {
            _sprintsRepository.Modify(model);

            return View(Views.Home);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            _sprintsRepository.Delete(id);

            return View(Views.Home);
        }
    }
}

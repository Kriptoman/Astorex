using System.Linq;
using System.Web.Mvc;
using TaskManager.Infrastructure.Constants;
using TaskManager.Presentation.Models;
using TaskManager.Presentation.Repositories;

namespace TaskManager.Web.Controllers
{
    public class HomeController : Controller
    {
        public const string Name = "home";

        private readonly SprintsRepository _sprintsRepository;
        private readonly AdditionalRepository _additionalRepository;

        public HomeController()
        {
            _sprintsRepository = new SprintsRepository();
            _additionalRepository = new AdditionalRepository();
        }

        [HttpGet]
        public ViewResult Index()
        {
            var model = new HomeModel
                {
                    Sprints = _sprintsRepository.GetAll().OrderBy(m => m.StartDate).ToList(),
                    Employees = _additionalRepository.GetEmployees().OrderBy(m => m.UserId).ToList()
                };

            return View(Views.Home, model);
        }

        [HttpPost]
        public ActionResult Index(LoginModel model)
        {
            return View(Views.Login);
        }
    }
}

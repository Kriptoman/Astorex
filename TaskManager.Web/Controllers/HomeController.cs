using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using TaskManager.Infrastructure.Constants;
using TaskManager.Presentation.Models;
using TaskManager.Presentation.Repositories;

namespace TaskManager.Web.Controllers
{
    public class HomeController : Controller
    {
        public const string Name = "home";

        private readonly SprintsRepository _sprintsRepository;

        public HomeController()
        {
            _sprintsRepository = new SprintsRepository();
        }

        [HttpGet]
        public ViewResult Index()
        {
            var model = new HomeModel
                {
                    Sprints = _sprintsRepository.GetAll().ToList()
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

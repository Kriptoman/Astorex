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

        private readonly TasksRepository _workitemsRepository ;

        public HomeController()
        {
            _workitemsRepository = new TasksRepository();
        }

        [HttpGet]
        public ViewResult Index()
        {
            var cookie = Request.Cookies.Get(".ASPXAUTH");
            var ticket = FormsAuthentication.Decrypt(cookie.Value);
            var userName = ticket.Name;

            var model = _workitemsRepository.GetTasksByUser(userName);

            return View(Views.Home, model);
        }

        [HttpPost]
        public ActionResult Index(LoginModel model)
        {
            return View(Views.Login);
        }
    }
}

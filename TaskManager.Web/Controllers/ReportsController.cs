using System.Globalization;
using System.Linq;
using System.Web.Mvc;
using TaskManager.Infrastructure.Constants;
using TaskManager.Presentation.Models;
using TaskManager.Presentation.Repositories;

namespace TaskManager.Web.Controllers
{
    public class ReportsController : Controller
    {
        public const string Name = "reports";

        private readonly AdditionalRepository _additionalRepository;

        public ReportsController()
        {
            _additionalRepository = new AdditionalRepository();
        }

        [HttpGet]
        public ActionResult Index()
        {
            var model = new ReportsModel();
            var staff = _additionalRepository.GetPersonal();

            model.Staff = staff.Select(s => new SelectListItem
                {
                    Text = s.FirstName + " " + s.LastName,
                    Value = s.Id.ToString(CultureInfo.InvariantCulture)
                });

            return View(Views.Reports, model);
        }
    }
}

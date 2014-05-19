using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TaskManager.Infrastructure.Constants;
using TaskManager.Presentation.Models;
using TaskManager.Presentation.Repositories;

namespace TaskManager.Web.Controllers
{
    public class LoginController : Controller
    {
        public const string Name = "login";

        [HttpGet]
        public ViewResult Index()
        {
            return View(Views.Login);
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            var repository = new UsersRepository();
            var verify = repository.Login(model.Password, model.Username);

            try
            {
                if (verify)
                {
                    var ticket = new FormsAuthenticationTicket(1, 
                                                           model.Username,
                                                           DateTime.Now,
                                                           DateTime.Now.AddSeconds(30),
                                                           model.Persistent,
                                                           "");

                    var strEncryptedTicket = FormsAuthentication.Encrypt(ticket);
                    var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, strEncryptedTicket);
                    Response.Cookies.Add(cookie);

                    return RedirectToAction(Actions.Index, HomeController.Name);
                }
            }
            catch (Exception)
            {
                
            }

            return View(Views.Login);
        }

        [HttpPost]
        public ActionResult LogOut(LoginModel model)
        {
            Response.Cookies.Remove(".ASPXAUTH");

            return View(Views.Login);
        }
    }
}

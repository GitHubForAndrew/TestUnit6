using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.Owin.Security;
using TestUnit6.Models;
using TestUnit6.Models.Views;
using TestUnit6.Infrastructure.Abstract;

namespace TestUnit6.Controllers
{
    public class LoginController : Controller
    {
        IAuhtProvider authProvider;

        public LoginController(IAuhtProvider authProvider)
        {
            this.authProvider = authProvider;
        }

        public ActionResult Index()
        {
            ViewBag.ReturnUrl = Url.Action("Index", "Home");
            return View();
        }

        [HttpPost]
        public ActionResult Index(AccountViewModel account, string returnUrl)
        {
            if (!ModelState.IsValid) return View();
            
            if (authProvider.Auhtenticate(account.Username, account.Password))
            {
                return Redirect(returnUrl ?? Url.Action("Index", "Home"));
            }
            else
            {
                ModelState.AddModelError("", "Неверные логин или пароль!");
                return View();
            }
        }
    }
}
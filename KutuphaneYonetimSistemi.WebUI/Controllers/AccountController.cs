using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KutuphaneYonetimSistemi.WebUI.Models;

namespace KutuphaneYonetimSistemi.WebUI.Controllers
{
    public class AccountController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View(new LoginModel());
        }

        public ActionResult Login(LoginModel model)
        {
            if (model.Username!=null && model.Password!=null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("Index", model);
            }
        }

        [HttpGet]
        public ActionResult Logout()
        {
            return RedirectToAction("Index");
        }
    }
}